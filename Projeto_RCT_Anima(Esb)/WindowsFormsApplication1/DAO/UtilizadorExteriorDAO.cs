using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.VO;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1.DAO
{
    public class UtilizadorExteriorDAO
    {
        public static int InsertUtilizador(UtilizadorExteriorVO Utilizador)
        {
            MySqlCommand cmd = new MySqlCommand("InsertUtilizador",
                               new MySqlConnection(tratarconexaoexterior.GetConnectionStringExterior()));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("nome", Utilizador.nome));
            cmd.Parameters.Add(new MySqlParameter("email", Utilizador.email));
            cmd.Parameters.Add(new MySqlParameter("telefone", Utilizador.telefone));
            cmd.Parameters.Add(new MySqlParameter("marcaExploracao", Utilizador.marcaExploracao));
            cmd.Parameters.Add(new MySqlParameter("idConcelho", Utilizador.idConcelho));
            cmd.Parameters.Add(new MySqlParameter("password", Utilizador.password));
            cmd.Parameters.Add(new MySqlParameter("username", Utilizador.username));
            cmd.Parameters.Add(new MySqlParameter("morada", Utilizador.morada));
            cmd.Parameters.Add(new MySqlParameter("codigoPostal", Utilizador.codigoPostal));
            cmd.Parameters.Add(new MySqlParameter("numeroCabecas", Utilizador.numeroCabecas));
            cmd.Parameters.Add(new MySqlParameter("racaPredominante", Utilizador.RacaPredominante));

            try
            {
                if (tratarconexaoexterior.AbrirConexao(cmd.Connection))
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
                tratarconexaoexterior.FecharConexao(cmd.Connection);
            }
        }




    }
}
