using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WindowsFormsApplication1.DAO
{
    
    public class Classtratarconexao
    {
        
        public static string GetConnectionString()

        {

            try
            {
                //return ConfigurationSettings.AppSettings["ConexaoBD"];
                //conexaoDataSet = new DataSet();
               //return new MySqlConnection("Server=localhost;Database=bmnd;User=root;Password=").ToString();
                return "datasource=localhost;port=3306;username=root;password=;Database=bmnd;";
                //MySqlConnection myConn = new MySqlConnection(myConnection);
                
                //return System.Configuration.ConfigurationManager.AppSettings["ConexaoBD"];


            }
            catch (MySqlException)
            {
                return null;
            }

        }

        //open connection to database
        public static bool AbrirConexao(MySqlConnection connection)
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                new Exception(ex.Message);
                //throw new ApplicationException(ex.ToString());
                return false;
            }
        }

        //Close connection
        public static bool FecharConexao(MySqlConnection connection)
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                new Exception(ex.Message);
                return false;
            }
        }

    }
}
