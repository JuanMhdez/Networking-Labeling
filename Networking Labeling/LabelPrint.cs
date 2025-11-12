using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Networking_Labeling
{
    internal class LabelPrint
    {
        //Conexión al Config
        INIFile localConfig = new INIFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Net Labeling\config.ini");

        public void printDatabase(string serial, string printer, out int error, out string msg)
        {
            try
            {
                /*EDITAR A LA BASE DE DATOS*/
                // Configuraciones
                string server = localConfig.Read("SERVER", "name");
                string logUser = localConfig.Read("SERVER", "logUser");
                string logPass = localConfig.Read("SERVER", "logPass");
                string labelFormat = localConfig.Read("PRINTER", "labelFormat");

                //Conexión a la base de datos
                using (SqlConnection connection = new SqlConnection("server=" + server + ";UID=" + logUser + ";password=" + logPass + ""))
                {
                    //Inicia Conexión
                    connection.Open();

                    //Query
                    string query = "INSERT INTO Data.PrintRecordCleanRoom(Serial, LabelName, PrinterName, IsPrinted)"
                                 + " VALUES(@Value_1,@Value_2,@Value_3,@Value_4)";

                    //Ejecución del Query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        //Llenado de datos
                        command.Parameters.Add("@Value_1", SqlDbType.NVarChar, 50).Value = serial;
                        command.Parameters.Add("@Value_2", SqlDbType.NVarChar, 50).Value = labelFormat;
                        command.Parameters.Add("@Value_3", SqlDbType.NVarChar, 30).Value = printer;
                        command.Parameters.Add("@Value_4", SqlDbType.Bit).Value = 0;
                        command.CommandType = CommandType.Text;

                        //Ejecución
                        command.ExecuteNonQuery();
                    }

                    //Return
                    msg = string.Empty;
                    error = 0;
                }
            }
            catch (Exception ex)
            {
                //Return
                msg = "Error al generar la etiqueta";
                error = 1;

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ",Error al generar la etiqueta:" + ex.Message + "\n");
            }
        }

        public void printBTXML(string serial, string printer, string partnum, string vpps, string duns, out int error, out string msg)
        {
            try
            {
                int printCount = 1;

                //Generación del XML de impresión
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;
                string timestamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                string timestampname = DateTime.Now.ToString("yyyyMMddHHmmss");
                string xmlname = timestampname + "_" + printCount;

                //Configuuraciones
                string label_format = localConfig.Read("PRINTER", "format");
                string serverPath = localConfig.Read("PRINTER", "server");
                string path = localConfig.Read("PRINTER", "path");

                using (XmlWriter xmlWriter = XmlWriter.Create(path + xmlname + ".btxml", settings))
                {
                    //Header del XML
                    xmlWriter.WriteRaw("<?xml version= '1.0' encoding = 'UTF-8'?>\r\n");
                    xmlWriter.WriteStartElement("XMLScript");
                    xmlWriter.WriteAttributeString("Version", "2.0");
                    xmlWriter.WriteStartElement("Command");
                    xmlWriter.WriteStartElement("Print");
                    xmlWriter.WriteAttributeString("JobName", "Job_" + timestamp);
                    xmlWriter.WriteStartElement("Format");
                    xmlWriter.WriteString(serverPath + label_format + ".btw");
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("PrintSetup");
                    xmlWriter.WriteStartElement("Printer");
                    xmlWriter.WriteString(printer);
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                                      
                    xmlWriter.WriteStartElement("NamedSubString");
                    xmlWriter.WriteAttributeString("Name", "PN");
                    xmlWriter.WriteStartElement("Value");
                    xmlWriter.WriteString(serial);
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                   
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                    xmlWriter.Close();
                }

                //Return
                msg = string.Empty;
                error = 0;
            }
            catch (Exception ex)
            {
                //Return
                msg = "Error al generar la etiqueta";
                error = 1;

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ",Error al generar la etiqueta:" + ex.Message + "\n");
            }

        }
    }
}