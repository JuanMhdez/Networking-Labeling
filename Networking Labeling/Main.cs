using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Networking_Labeling.Runcard;

namespace Networking_Labeling
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //Conexión al Config
        INIFile localConfig = new INIFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Net Labeling\config.ini");

        runcard_wsdlPortTypeClient client = new runcard_wsdlPortTypeClient("runcard_wsdlPort");

        List<string> serialsList = new List<string>();

        int qtyTotal = 0;

        string msg = "";
        int error = 0;

        string opcode = "";
        string seqnum = "";
        string machineId = "";
        string partClass = "";

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(localConfig.FilePath)))
                {
                    //Creación directorio y archivo config
                    Directory.CreateDirectory(Path.GetDirectoryName(localConfig.FilePath));
                    File.Copy(Directory.GetCurrentDirectory() + "\\config.ini", localConfig.FilePath);
                }

                //Obtención de los datos del config
                opcode = localConfig.Read("RUNCARD_INFO", "opcode");
                seqnum = localConfig.Read("RUNCARD_INFO", "seqnum");
                machineId = localConfig.Read("RUNCARD_INFO", "machineID");
                partClass = localConfig.Read("RUNCARD_INFO", "partClass");

                foreach (string part in localConfig.Read("PRINTER", "printers").Split(','))
                    cBoxPrinter.Items.Add(part);

                //Ajuste de controles
                lblMessage.Text = "";
                lblOpcode.Text = opcode;
                lblMachine.Text = machineId;
                cBoxQuantity.SelectedIndex = -1;             
                 
                 string msgDB = "";
                int errorDB = 0;

                //Conexión a la Base de Datos
                DBConnection dB = new DBConnection();
                DataTable dataResult = new DataTable();
                dB.dataBase = "datasource=mlxgumvlnwrc01.molex.com;port=3306;username=Jhernandez;password=Jhernandez123#;database=runcard_networking;";
                dB.query = "SELECT partnum FROM runcard_networking.prod_master_config as pm inner join runcard_networking.prod_step_config as ps on pm.prr_config_id=ps.prr_config_id and ps.prr_config_rev=pm.prr_config_rev where status = 'Active' and opcode = '"+opcode+"' and part_class in ('"+partClass+"');";
                var dBResult = dB.selectQuery(out msgDB, out errorDB);

                if (errorDB == 0)
                {
                    //Almacena los datos obtenidos
                    dBResult.Fill(dataResult);

                    foreach (DataRow row in dataResult.Rows)
                        if (!cBoxPartNum.Items.Contains(row.ItemArray[0]))
                            cBoxPartNum.Items.Add(row.ItemArray[0]);
                }
                else
                {
                    //Bloqueo
                    cBoxPartNum.Enabled = false;

                    //Retroalimentación
                    Message message = new Message();
                    message.message = msgDB;
                    message.icon = "error";
                    message.ShowDialog();
                }
                 
                 
                 
                //Datos Temporales 

              //  cBoxPartNum.Items.Add("2154160029");

            }
            catch (Exception ex)
            {
                //Bloqueo
                cBoxPartNum.Enabled = false;

                //Retroalimentación
                Message message = new Message();
                message.message = "Error al obtener la configuración";
                message.icon = "error";
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ",Error al obtener la configuración:" + ex.Message + "\n");
            }
        }

        private void cBoxPartNum_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cBoxPartNum.Text != "")
            {
                try
                {
                    //Clear Save Data
                    cBoxWorkOrder.Items.Clear();

                    //Get Work Orders
                    var getWorkOrders = client.getAvailableWorkOrders(cBoxPartNum.Text, "", out error, out msg);

                    foreach (workOrderItem order in getWorkOrders)
                        if (!cBoxWorkOrder.Items.Contains(order.workorder))
                            cBoxWorkOrder.Items.Add(order.workorder);

                    //Ajuste de controles
                    cBoxWorkOrder.Enabled = true;
                }
                catch (Exception ex)
                {
                    //Retroalimentación
                    Message message = new Message();
                    message.message = "Error al obtener las ordenes";
                    message.icon = "error";
                    message.ShowDialog();

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ",Error al obtener las ordenes:" + ex.Message + "\n");
                }
            }
        }

        private void cBoxWorkOrder_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cBoxWorkOrder.Text != "")
            {
                //Ajuste de controles
                cBoxPrinter.Enabled = true;
            }
        }

        private void cBoxPrinter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cBoxPrinter.Text != "")
            {
                //Ajuste de controles
                btnChange.Enabled = true;
                cBoxPartNum.Enabled = false;
                cBoxPrinter.Enabled = false;
                cBoxQuantity.Enabled = true;
                cBoxWorkOrder.Enabled = false;
            }
        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            //Ajuste de controles
            cBoxWorkOrder.Enabled = false;
            cBoxQuantity.Enabled = false;
            cBoxPrinter.Enabled = false;
            cBoxPartNum.Enabled = true;
            tBoxSerial.Enabled = false;
            btnChange.Enabled = false;
            btnChange.Enabled = false;
            btnReset.Enabled = false;

            //Retroalimentación
            tLayoutMessage.BackColor = Color.White;
            lblMessage.Text = "";
            lblQty.Text = "0/0";

            //Limpieza de controles
            cBoxWorkOrder.SelectedIndex = -1;
            cBoxPrinter.SelectedIndex = -1;
            cBoxPartNum.SelectedIndex = -1;
            cBoxQuantity.SelectedIndex = -1;
            serialsList.Clear();
            tBoxSerial.Clear();
            pBar.Value = 0;
            qtyTotal = 0;
        }

        private void cBoxQuantity_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cBoxQuantity.Text != "" & cBoxPrinter.Text != "")
            {
                //Ajuste de controles
                btnGenerate.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Cantidad seleccionada/Boleana de control
            int quantity = Convert.ToInt32(cBoxQuantity.Text);
            
            //Ajuste de controles
            cBoxQuantity.Enabled = false;
            btnGenerate.Enabled = false;
            btnReset.Enabled = false;

            //Generación de XML
            generateXML(quantity);
        }

        private void generateXML(int qty)
        {
            try
            {
                //Dato Temporal
                int printCount = 0;

                //Ajuste de Controles
                pBar.Maximum = qty;
                pBar.Minimum = 0;
                pBar.Value = 0;
                pBar.Step = 1;

                do
                {
                    //Generate New Serial
                    var nextSerial = client.generateNewWorkOrderSerial(cBoxWorkOrder.Text, "ftest", machineId, out error, out msg);

                    Thread.Sleep(1000);

                    if (error == 0)
                    {
                        //Datos temporales
                        string lblMsg = "";
                        int lblError = 0;

                        //Print
                        LabelPrint print = new LabelPrint();
                        print.printBTXML(nextSerial, cBoxPrinter.Text, cBoxPartNum.Text, localConfig.Read("TEMPORAL_DATA", "vpps"), localConfig.Read("TEMPORAL_DATA", "dune"), out lblError, out lblMsg);

                        if (lblError == 0)
                        {
                            //Se añade el serial al listado
                            serialsList.Add(nextSerial);

                            //Ajuste de controles
                            pBar.PerformStep();
                            printCount++;

                            //Log
                            File.AppendAllText(Directory.GetCurrentDirectory() + @"\printLog.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ",Impresión:" + nextSerial + "\n");
                        }
                        else
                        {
                            //Retroalimentación
                            lblMessage.Text = lblMsg;
                            tLayoutMessage.BackColor = Color.Crimson;
                            break;
                        }

                        //Log
                        File.AppendAllText(Directory.GetCurrentDirectory() + @"\Log.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "," + msg + "\n");
                    }
                    else if (error == 1 & msg.Contains("quantity limit"))
                    {
                        //Retroalimentación
                        Message message = new Message();
                        message.message = "La orden " + cBoxWorkOrder.Text + " no cuenta con cantidad para generar más seriales";
                        message.icon = "error";
                        message.ShowDialog();

                        //Log
                        File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ",La orden " + cBoxWorkOrder.Text + " no cuenta con cantidad para generar más seriales\n");

                        break;
                    }
                    else
                    {
                        //Retroalimentación
                        Message message = new Message();
                        message.message = "Error al generar el siguiente serial";
                        message.icon = "error";
                        message.ShowDialog();

                        //Log
                        File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ",Error al generar el siguiente serial\n");
                    }
                } while (printCount < qty);

                if (printCount == qty)
                {
                    //Retroalimentación
                    lblMessage.Text = "Escanear cada etiqueta impresa";
                    tLayoutMessage.BackColor = Color.DodgerBlue;

                    //Ajuste de controles
                    lblQty.Text = "0/" + qty.ToString();
                    tBoxSerial.Enabled = true;
                    btnReset.Enabled = true;
                    tBoxSerial.Focus();
                }
            }
            catch (Exception ex)
            {
                //Retroalimentación
                Message message = new Message();
                message.message = "Error al generar los seriales";
                message.icon = "error";
                message.ShowDialog();

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ",Error al generar los seriales:" + ex.Message + "\n");
            }
        }

        private void tBoxSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & tBoxSerial.Text != "")
            {
                try
                {
                    //Dato escaneado
                    string scanData = tBoxSerial.Text;

                    //Get Unit Status
                    var getStatus = client.getUnitStatus(scanData, out error, out msg);
                    string operation = getStatus.opcode;
                    string serial = getStatus.serial;
                    string status = getStatus.status;
                    int step = getStatus.seqnum;

                    Console.WriteLine("Opecode: " + operation);

                    if (status == "IN QUEUE" & operation == opcode | status == "IN PROGRESS" & operation == opcode)
                    {
                        if (scanData.Contains(serial) & serialsList.Contains(serial))
                        {
                            //Transaction Item
                            transactionItem transItem = new transactionItem();
                            transItem.workorder = cBoxWorkOrder.Text;
                            transItem.username = "ftest";
                            transItem.transaction = "MOVE";
                            transItem.serial = serial;
                            transItem.trans_qty = 1;
                            transItem.seqnum = step;
                            transItem.opcode = operation;
                            transItem.warehousebin = "WIP";
                          //  transItem.machine_id = machineId;
                            transItem.warehouseloc = "PRODUCTION FLOOR";

                            //Data/BOM Item
                            dataItem[] inputData = new dataItem[] { };
                            bomItem[] bomData = new bomItem[] { };

                            //Transaction
                            var transaction = client.transactUnit(transItem, inputData, bomData, out msg);

                            if (msg.Contains("ADVANCE"))
                            {
                                //Retroalimentación
                                lblMessage.Text = "Serial " + serial + " Completado";
                                tLayoutMessage.BackColor = Color.LimeGreen;

                                //Logs
                                File.AppendAllText(Directory.GetCurrentDirectory() + @"\Log.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ",Serial validado:" + scanData + "\n");
                                File.AppendAllText(Directory.GetCurrentDirectory() + @"\Log.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "," + msg + "\n");

                                //Remueve de la lista
                                serialsList.Remove(serial);

                                //Count
                                qtyTotal++;

                                //Retroalimentación
                                lblQty.Text = qtyTotal.ToString() + "/" + cBoxQuantity.Text;

                                if (serialsList.Count == 0)
                                {
                                    //Ajuste de controles
                                    cBoxQuantity.SelectedIndex = -1;
                                    tBoxSerial.Enabled = false;
                                    cBoxQuantity.Enabled = true;
                                    pBar.Value = 0;
                                    qtyTotal = 0;

                                    //Timer Start
                                    timerRefresh.Start();
                                }
                            }
                            else
                            {
                                //Retroalimentación
                                lblMessage.Text = "Pase NO otorgado al serial " + serial;
                                tLayoutMessage.BackColor = Color.Crimson;

                                //Log
                                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ",Pase NO otorgado al serial " + serial + ":" + msg + "\n");
                            }
                        }
                        else if (!serialsList.Contains(serial))
                        {
                            //Retroalimentación
                            lblMessage.Text = "El serial " + serial + " no pertenece al Lote de etiquetas";
                            tLayoutMessage.BackColor = Color.Crimson;

                            //Log
                            File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ",El serial " + serial + " no pertenece al Lote de etiquetas\n");
                        }
                    }
                    else
                    {
                        //Get Instructions
                        var getInstructions = client.getWorkOrderStepInstructions(cBoxWorkOrder.Text, step.ToString(), out error, out msg);

                        //Retroalimentación
                        lblMessage.Text = "Serial " + serial + " sin flujo, " + status + ":" + getInstructions.opdesc;
                        tLayoutMessage.BackColor = Color.Crimson;
                    }

                    //Ajuste de controles
                    tBoxSerial.Clear();
                    tBoxSerial.Focus();
                }
                catch (Exception ex)
                {
                    //Retroalimentación
                    Message message = new Message();
                    message.message = "Error al dar el pase";
                    message.icon = "error";
                    message.ShowDialog();

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ",Error al dar el pase:" + ex.Message + "\n");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Ajuste de controles
            cBoxQuantity.SelectedIndex = -1;
            cBoxQuantity.Enabled = true;
            btnGenerate.Enabled = false;
            tBoxSerial.Enabled = false;
            serialsList.Clear();
            tBoxSerial.Clear();
            pBar.Value = 0;
            qtyTotal = 0;

            //Retroalimentación
            lblMessage.Text = "Seleccione la cantidad de etiquetas a imprimir";
            tLayoutMessage.BackColor = Color.DeepSkyBlue;
            lblQty.Text = "0/0";
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            //Timer Stop
            timerRefresh.Stop();

            //Ajuste de controles
            lblQty.Text = "0/0";
        }

        private void btnReset_EnabledChanged(object sender, EventArgs e)
        {
            if (btnReset.Enabled)
                btnReset.BackgroundImage = Properties.Resources.icons8_actualizar_240;
            else
                btnReset.BackgroundImage = Properties.Resources.icons8_actualizar_241;
        }
    }
}

class INIFile
{
    //Variable Ruta
    private string filePath;

    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string section,
    string key,
    string val,
    string filePath);

    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section,
    string key,
    string def,
    StringBuilder retVal,
    int size,
    string filePath);

    public INIFile(string filePath)
    {
        this.filePath = filePath;
    }

    public void Write(string section, string key, string value)
    {
        WritePrivateProfileString(section, key, value.ToLower(), this.filePath);
    }

    public string Read(string section, string key)
    {
        StringBuilder SB = new StringBuilder(255);
        int i = GetPrivateProfileString(section, key, "", SB, 255, this.filePath);
        return SB.ToString();
    }

    public string FilePath
    {
        get { return this.filePath; }
        set { this.filePath = value; }
    }
}