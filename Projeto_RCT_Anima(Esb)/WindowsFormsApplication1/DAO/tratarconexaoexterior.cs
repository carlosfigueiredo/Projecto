using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1.DAO
{
    class tratarconexaoexterior
    {

        public static string GetConnectionStringExterior()
        {

            try
            {
                //return ConfigurationSettings.AppSettings["ConexaoBD"];
                //conexaoDataSet = new DataSet();
                //return new MySqlConnection("Server=localhost;Database=bmnd;User=root;Password=").ToString();
                return "datasource=MYSQL5004.Smarterasp.net;port=3306;username=9ac44f_explori;password=explorinova1;Database=db_9ac44f_explori;";
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
