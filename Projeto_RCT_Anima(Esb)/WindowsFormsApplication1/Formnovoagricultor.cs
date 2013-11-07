using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.VO;


namespace WindowsFormsApplication1
{
    public partial class Formnovoagricultor : Form
    {
        public Formnovoagricultor()
        {
            InitializeComponent();
            tbpass.PasswordChar = '*';
            string a = Encript.Encriptar("exptestenm");
            string b = Encript.Desencriptar(a);
        }

        //private MySqlConnection conexao;
        //private DataSet conexaoDataSet;
        //private MySqlDataAdapter conexaoDataAdapter;

        private void Formnovoagricultor_Load(object sender, EventArgs e)
        {

            //conexaoDataSet = new DataSet();
            //conexao = new MySqlConnection("Server=localhost;Database=bmnd;User=root;Password=");

        }

         private void registrar(){

             if ((tbnome.Text != "") && (tbmorada.Text != "") && (tbnif.Text != "") && (tbtlm.Text != "") && (tbemail.Text != "") && (tbuser.Text != "") && (tbpass.Text != ""))
             {

                 try
                 {

                     //MySqlCommand gravar = conexao.CreateCommand();
                     //gravar.CommandText = "Insert into agricultor (nomeDetentor,enderecoDetentor,nif,telefone,email,password,username) VALUE(@nomeDetentor,@enderecoDetentor,@nif,@telefone,@email,@password,@username)";
                     ////gravar.Parameters.AddWithValue("@nomeDetentor", tbnome.Text);
                     ////gravar.Parameters.AddWithValue("@enderecoDetentor", tbmorada.Text);
                     ////gravar.Parameters.AddWithValue("@nif", tbnif.Text);
                     ////gravar.Parameters.AddWithValue("@telefone", tbtlm.Text);
                     ////gravar.Parameters.AddWithValue("@email", tbemail.Text);
                     ////gravar.Parameters.AddWithValue("@password", tbpass.Text);
                     ////gravar.Parameters.AddWithValue("@username", tbuser.Text);
                     //conexao.Open();
                     //gravar.ExecuteNonQuery();

                     AgricultorVO Agricultor = new AgricultorVO();
                     Agricultor.NomeDetentor = tbnome.Text;
                     Agricultor.MoradaDetentor = tbmorada.Text;
                     Agricultor.Nif = tbnif.Text;
                     Agricultor.Telefone = tbtlm.Text;
                     Agricultor.Email = tbemail.Text;
                     Agricultor.Password = tbpass.Text;
                     Agricultor.Username = tbuser.Text;

                     AgricultorBUS Agricultorbus = new AgricultorBUS();

                     if (Agricultorbus.InsertAgricultor(Agricultor) == 1)
                         MessageBox.Show("Agricultor inserido");
                     else
                         MessageBox.Show(" falha");



                     tbnome.Clear();
                     tbmorada.Clear();
                     tbnif.Clear();
                     tbtlm.Clear();
                     tbemail.Clear();
                     tbuser.Clear();
                     tbpass.Clear();

                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Erro a criar utilizador!");
                     throw ex;
                     //conexao.Close();

                 }
                 finally
                 {
                     //conexao.Close();
                     MessageBox.Show("Criado com sucesso!");
                 }



             }
             else
             {
                 MessageBox.Show("Verificar os campos!");

             }

    }

        private void btinsertagric_Click(object sender, EventArgs e)
        {
            registrar();

        }

        

    }

   

}
