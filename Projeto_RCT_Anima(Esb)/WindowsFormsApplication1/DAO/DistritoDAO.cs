using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.VO;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.DAO
{
    public class DistritoDAO
    {

        public static List<DistritoVO> GetDistritos()
        {
            List<DistritoVO> listaDistritos = new List<DistritoVO>();

            

            MySqlCommand cmd = new MySqlCommand("GetDistritos",
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
                        DistritoVO Distrito = new DistritoVO();

                        Distrito.IdDistrito = Convert.ToInt32(dr["idDistrito"]);
                        Distrito.Nome = Convert.ToString(dr["nome"]);

                       listaDistritos.Add(Distrito);

                    }
                    dr.Close();


                    return listaDistritos;
                }
                else
                {
                    return listaDistritos;
                }
            }
            catch (MySqlException ex)
            {
                new Exception(ex.Message);
                return listaDistritos;
            }
            finally
            {
                Classtratarconexao.FecharConexao(cmd.Connection);
            }
        }

        public static List<DistritoVO> GetDistritos1()
        {
            List<DistritoVO> listaDistritos = new List<DistritoVO>();



            MySqlCommand cmd = new MySqlCommand("GetDistritos",
                       new MySqlConnection(tratarconexaoexterior.GetConnectionStringExterior()));
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                if (tratarconexaoexterior.AbrirConexao(cmd.Connection))
                {
                    MySqlDataReader dr =
                   cmd.ExecuteReader(CommandBehavior.CloseConnection);


                    while (dr.Read())
                    {
                        DistritoVO Distrito = new DistritoVO();

                        Distrito.IdDistrito = Convert.ToInt32(dr["idDistrito"]);
                        Distrito.Nome = Convert.ToString(dr["nome"]);

                        listaDistritos.Add(Distrito);

                    }
                    dr.Close();


                    return listaDistritos;
                }
                else
                {
                    return listaDistritos;
                }
            }
            catch (MySqlException ex)
            {
                new Exception(ex.Message);
                return listaDistritos;
            }
            finally
            {
                tratarconexaoexterior.FecharConexao(cmd.Connection);
            }
        }
    }
}
