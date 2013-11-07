using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using WindowsFormsApplication1.VO;


namespace WindowsFormsApplication1.DAO
{
    public class AgricultorDAO
    {
        public static int InsertAgricultor(AgricultorVO Agricultor)
        {
            MySqlCommand cmd = new MySqlCommand("InsertAgricultor",
                               new MySqlConnection(Classtratarconexao.GetConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("nomedetentor", Agricultor.NomeDetentor));
            cmd.Parameters.Add(new MySqlParameter("moradadetentor", Agricultor.MoradaDetentor));
            cmd.Parameters.Add(new MySqlParameter("nif", Agricultor.Nif));
            cmd.Parameters.Add(new MySqlParameter("telefone", Agricultor.Telefone));
            cmd.Parameters.Add(new MySqlParameter("email", Agricultor.Email));
            cmd.Parameters.Add(new MySqlParameter("password", Agricultor.Password));
            cmd.Parameters.Add(new MySqlParameter("username", Agricultor.Username));
            try
            {
                if (Classtratarconexao.AbrirConexao(cmd.Connection))
                    cmd.ExecuteNonQuery();
                return 1;
            }
            catch (MySqlException ex)
            {
                new Exception(ex.Message);
                return 0;
            }
            finally
            {
                Classtratarconexao.FecharConexao(cmd.Connection);
            }
        }

        public static int GetIdAgricultor(string username)
        {
            int id = 0;
            MySqlCommand cmd = new MySqlCommand("GetIdAgricultor",
                       new MySqlConnection(Classtratarconexao.GetConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("user", username));
            //cmd.Connection.Open();
            try
            {
                if (Classtratarconexao.AbrirConexao(cmd.Connection))
                {
                    MySqlDataReader dr =
                   cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                        id = Convert.ToInt32(dr["idAgricultor"]);
                    dr.Close();
                    //cmd.Connection.Close(); //eu
                    return id;
                }
                else
                {
                    return id;
                }
            }
            catch (MySqlException ex)
            {
                new Exception(ex.Message);
                return id;
            }
            finally
            {
                Classtratarconexao.FecharConexao(cmd.Connection);
            }
        }

        public static List<AgricultorVO> GetLoginAgricultor()
        {

            List<AgricultorVO> agricultorItemList = new List<AgricultorVO>();

            MySqlCommand cmd = new MySqlCommand("ConsultarLogin",
                  new MySqlConnection(Classtratarconexao.GetConnectionString()));
       cmd.CommandType = CommandType.StoredProcedure; 

        try
       {
           if (Classtratarconexao.AbrirConexao(cmd.Connection))
           {
               MySqlDataReader dr =
              cmd.ExecuteReader(CommandBehavior.CloseConnection);


               while (dr.Read())
               {
                   AgricultorVO Agri = new AgricultorVO();
                   Agri.Password = Convert.ToString(dr["password"]);
                   Agri.Username = Convert.ToString(dr["username"]);
          
                   agricultorItemList.Add(Agri);
               }
               dr.Close();

               //cmd.Connection.Close(); //eu

               return agricultorItemList;
           }
           else
           {
               return agricultorItemList;
           }
       }
       catch (MySqlException ex)
       {
           new Exception(ex.Message);
           return agricultorItemList;
       }
       finally
       {
           Classtratarconexao.FecharConexao(cmd.Connection);
       }

        }



    }
}
