using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System;
using System.Reflection;

namespace Backend.Business.Bussiness.SQL {

    public class executeScript
    {

        /// <summary>
        /// Configure a SQL Connection
        /// </summary>
        /// <returns>
        /// SqlConnection: new SQL Connection.
        /// </returns>
        public static SqlConnection configureConnection()
        {            
            try
            {
                string sqlConnectionString = @"Integrated Security=True;Persist Security Info=False;Initial Catalog=master;Data Source=localhost";
                SqlConnection conn = new SqlConnection(sqlConnectionString);
                return conn;
            }
            catch (SqlException e)
            {
                MessageBox.Show("SQL SERVER CONNECTION ERROR: " + e.Message,"SQL connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        /// <summary>
        /// Read and execute a sql script
        /// </summary>
        /// <param name="conn">SqlConnection: Sql Connection</param>
        /// <param name="filename">string: SQL Script name</param>
        public static void runScript(SqlConnection conn, string filename)
        {             
            try
            {                
                string scriptPath = getSqlScriptDomain(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory), filename);

                IEnumerable<string> commandString = getCommandFromScript(scriptPath);
                executeQuery(conn, commandString);                
            }
            catch (Exception e)
            {
                MessageBox.Show("SQL SERVER CONNECTION ERROR: " + e.Message, "SQL connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

        }

        /// <summary>
        /// Create script path from baseDirectory and script name.
        /// </summary>
        /// <param name="baseDirectory">string: Project base directory</param>
        /// <param name="filename">string: Script name</param>
        /// <returns></returns>
        private static string getSqlScriptDomain(string baseDirectory, string filename) {

            string debugPath = Path.GetDirectoryName(baseDirectory);
            string binPath = Path.GetDirectoryName(debugPath);
            string gestioDispositivosPath = Path.GetDirectoryName(binPath);
            string gestioDispositivosPath2 = Path.GetDirectoryName(gestioDispositivosPath);

            string scriptPath = gestioDispositivosPath2 + @"\gestionDispositivos.Backend\Business\Bussiness.SQL\" + filename;
            
            return scriptPath;
        }

        /// <summary>
        /// Load and get command from sql script.
        /// </summary>
        /// <param name="scriptPath">string: Script path</param>
        /// <returns>
        ///  IEnumerable<string>: Set of script lines.
        /// </returns>
        private static IEnumerable<string> getCommandFromScript(string scriptPath)
        { 
            string script = File.ReadAllText(scriptPath);
            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

            return commandStrings;
        }

        /// <summary>
        /// Open connection and execute script. Then close connection.
        /// </summary>
        /// <param name="conn">SqlConnection: SQL Connection</param>
        /// <param name="commandStrings">IEnumerable<string>: set of script lines.</param>
        private static void executeQuery(SqlConnection conn, IEnumerable<string> commandStrings) {

            if (conn != null)
            {
                conn.Open();
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        using (var command = new SqlCommand(commandString, conn))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                conn.Close();
            }
        }


    }





}
