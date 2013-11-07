using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.VO;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace WindowsFormsApplication1.DAO
{
    public class ExploracaoDAO
    {
        public static int InsertExploracao(ExploracaoVO Exploracao , AssociacaoVO Associacao , TipoProducaoVO TipoProducao) 
        {
            MySqlCommand cmd = new MySqlCommand("InsertExploracao",
                               new MySqlConnection(Classtratarconexao.GetConnectionString()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("nregistoexploracao", Exploracao.NRegistoExploracao));
            cmd.Parameters.Add(new MySqlParameter("nif", Exploracao.Nif));
            cmd.Parameters.Add(new MySqlParameter("nomeexploracao", Exploracao.NomeExploracao));
            cmd.Parameters.Add(new MySqlParameter("marca", Exploracao.Marca));
            cmd.Parameters.Add(new MySqlParameter("local", Exploracao.Local));
            cmd.Parameters.Add(new MySqlParameter("codpostal", Exploracao.CodPostal));
            cmd.Parameters.Add(new MySqlParameter("telefone", Exploracao.Telefone));
            cmd.Parameters.Add(new MySqlParameter("sistemaexploracao", Exploracao.SistemaExploracao));
            cmd.Parameters.Add(new MySqlParameter("parcelarioref", Exploracao.ParcelarioRef));
            cmd.Parameters.Add(new MySqlParameter("freguesia", Exploracao.Freguesia));
            cmd.Parameters.Add(new MySqlParameter("idagricultor", Exploracao.IdAgricultor));
            //cmd.Parameters.Add(new MySqlParameter("idassociacao", Exploracao.IdAssociacao));
            cmd.Parameters.Add(new MySqlParameter("idconcelho", Exploracao.IdConcelho));
            cmd.Parameters.Add(new MySqlParameter("nome", Associacao.Nome));
            cmd.Parameters.Add(new MySqlParameter("nomeFuncionario", Associacao.NomeFuncionario));
            cmd.Parameters.Add(new MySqlParameter("contactoFuncionario", Associacao.ContactoFuncionario));
            cmd.Parameters.Add(new MySqlParameter("emailGeral", Associacao.EmailGeral));
            cmd.Parameters.Add(new MySqlParameter("emailContacto", Associacao.EmailContacto));
            cmd.Parameters.Add(new MySqlParameter("morada", Associacao.Morada));
            cmd.Parameters.Add(new MySqlParameter("telefoneass", Associacao.Telefone));
            cmd.Parameters.Add(new MySqlParameter("idTipoProducao", TipoProducao.IdTipoProducao));
            cmd.Parameters.Add(new MySqlParameter("descricaoProducao", TipoProducao.DescricaoProducao));

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
        
    }
}
