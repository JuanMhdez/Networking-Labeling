using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Networking_Labeling
{
    internal class DBConnection
    {
        //Conexión MySQL
        MySqlConnection conn = null;

        //Datos Variables
        public string dataBase = "";
        public string query = "";
        string log = "";
        string msg = "";
        int error = 0;

        private void connectBD()
        {
            try
            {
                //Abre la conexión
                conn = new MySqlConnection(dataBase);
                conn.Open();

                //Asignación de resultados
                msg = "";
                error = 0;
            }
            catch (Exception ex)
            {
                //Asignación de resultados
                msg = "Error al conectar a la Base de Datos";
                error = 1;

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yy HH:mm:ss") + ",Error al conectar a la Base de Datos:" + ex.Message + "\n");
            }
        }

        private void disconnectBD()
        {
            try
            {
                if (error == 0)
                {
                    //Cierre de la conexión
                    conn.Close();

                    //Asignación de resultados
                    msg = "";
                    error = 0;
                }
            }
            catch (Exception ex)
            {
                //Asignación de resultados
                msg = "Error al desconectar a la Base de Datos";
                error = 1;

                //Log
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yy HH:mm:ss") + ",Error al desconectar a la Base de Datos:" + ex.Message + "\n");
            }
        }

        public MySqlDataAdapter selectQuery(out string result, out int errors)
        {
            //Reader MySQL
            MySqlDataAdapter reader = new MySqlDataAdapter();

            //Conexión a la BD
            connectBD();

            if (error == 0)
            {
                try
                {
                    //Ejecución del Query
                    var command = new MySqlCommand(query, conn);
                    reader.SelectCommand = command;

                    //Asignación de resultados
                    msg = "";
                    error = 0;
                }
                catch (Exception ex)
                {
                    //Retroalimentación
                    msg = "Error al consultar a la Base de Datos";
                    error = 1;

                    //Log
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\errorLog.txt", DateTime.Now.ToString("MM/dd/yy HH:mm:ss") + ",Error al consultar la Base de Datos:" + ex.Message + "\n");
                }
            }

            //Desconexión a la BD
            disconnectBD();

            //Resultados
            result = msg;
            errors = error;

            //Return
            return reader;
        }
    }
}