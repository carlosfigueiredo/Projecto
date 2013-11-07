using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.VO;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.DAO
{
    public class ConcelhoDAO
    {
        public static List<ConcelhoVO> GetConcelhos(int id)
        {
            List<ConcelhoVO> listaConcelho = new List<ConcelhoVO>();



            MySqlCommand cmd = new MySqlCommand("GetConcelhos",
                       new MySqlConnection(Classtratarconexao.GetConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("idDistrito", id));

            try
            {
                if (Classtratarconexao.AbrirConexao(cmd.Connection))
                {
                    MySqlDataReader dr =
                   cmd.ExecuteReader(CommandBehavior.CloseConnection);


                    while (dr.Read())
                    {
                        ConcelhoVO Concelho = new ConcelhoVO();

                        Concelho.IdConcelho = Convert.ToInt32(dr["idConcelho"]);
                        Concelho.Nome = Convert.ToString(dr["nome"]);
                        Concelho.IdDistrito = Convert.ToInt32(dr["idDistrito"]);

                        listaConcelho.Add(Concelho);

                    }
                    dr.Close();


                    return listaConcelho;
                }
                else
                {
                    return listaConcelho;
                }
            }
            catch (MySqlException ex)
            {
                new Exception(ex.Message);
                return listaConcelho;
            }
            finally
            {
                Classtratarconexao.FecharConexao(cmd.Connection);
            }
        }

        public static List<ConcelhoVO> GetConcelhos1(int id)
        {
            List<ConcelhoVO> listaConcelho = new List<ConcelhoVO>();



            MySqlCommand cmd = new MySqlCommand("GetConcelhos",
                       new MySqlConnection(tratarconexaoexterior.GetConnectionStringExterior()));
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("idDistrito", id));

            try
            {
                if (tratarconexaoexterior.AbrirConexao(cmd.Connection))
                {
                    MySqlDataReader dr =
                   cmd.ExecuteReader(CommandBehavior.CloseConnection);


                    while (dr.Read())
                    {
                        ConcelhoVO Concelho = new ConcelhoVO();

                        Concelho.IdConcelho = Convert.ToInt32(dr["idConcelho"]);
                        Concelho.Nome = Convert.ToString(dr["nome"]);
                        Concelho.IdDistrito = Convert.ToInt32(dr["idDistrito"]);

                        listaConcelho.Add(Concelho);

                    }
                    dr.Close();


                    return listaConcelho;
                }
                else
                {
                    return listaConcelho;
                }
            }
            catch (MySqlException ex)
            {
                new Exception(ex.Message);
                return listaConcelho;
            }
            finally
            {
                tratarconexaoexterior.FecharConexao(cmd.Connection);
            }
        }

    }
}
