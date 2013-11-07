using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.VO;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.DAO
{
    public class TipoProducaoDAO
    {
        public static List<TipoProducaoVO> GetTipoProducao()
        {
            List<TipoProducaoVO> listaTipoProducao = new List<TipoProducaoVO>();



            MySqlCommand cmd = new MySqlCommand("GetTipoProducao",
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
                        TipoProducaoVO TipoProducao = new TipoProducaoVO();

                        TipoProducao.IdTipoProducao = Convert.ToInt32(dr["idTipoProducao"]);
                        TipoProducao.DescricaoProducao = Convert.ToString(dr["descricaoProducao"]);

                        listaTipoProducao.Add(TipoProducao);

                    }
                    dr.Close();


                    return listaTipoProducao;
                }
                else
                {
                    return listaTipoProducao;
                }
            }
            catch (MySqlException ex)
            {
                new Exception(ex.Message);
                return listaTipoProducao;
            }
            finally
            {
                Classtratarconexao.FecharConexao(cmd.Connection);
            }
        }

    }
}
