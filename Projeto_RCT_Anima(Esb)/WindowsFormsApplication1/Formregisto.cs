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
    public partial class Formregisto : Form
    {
        public Formregisto()
        {
            InitializeComponent();
            tbpassregist.PasswordChar = '*';
            string a = Encript.Encriptar("exptestenm");
            string b = Encript.Desencriptar(a);
            tbconfrimpassregist.PasswordChar = '*';
            this.BringToFront();
        }

        private void Formregisto_Load(object sender, EventArgs e)
        {

            cbdistritoregist.DataSource = DistritoBUS.GetDistritos1();
            cbdistritoregist.DisplayMember = "nome";
            cbdistritoregist.ValueMember = "idDistrito";

            cbconcelhoregist.DataSource = ConcelhoBUS.GetConcelhos1(Convert.ToInt32(cbdistritoregist.SelectedValue));
            cbconcelhoregist.DisplayMember = "nome";
            cbconcelhoregist.ValueMember = "idConcelho";
        }

        private void cbconcelhoregist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbdistritoregist_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!cbdistritoregist.Text.Equals(""))
            {
                //cbdistritoexpl.DataSource = DistritoBUS.GetDistritos();
                cbdistritoregist.DisplayMember = "nome";
                cbdistritoregist.ValueMember = "idDistrito";

                cbconcelhoregist.DataSource = ConcelhoBUS.GetConcelhos1(Convert.ToInt32(cbdistritoregist.SelectedValue));
                cbconcelhoregist.DisplayMember = "nome";
                cbconcelhoregist.ValueMember = "idConcelho";
            }
        }

        private void chkbcontrato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbcontrato.Checked == true)
            {
                btregistar.Enabled = true;

            }
            else
            {
                btregistar.Enabled = false;
            }
        }

        private void lltermos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Formtermos frm = new Formtermos();
            frm.Owner = this;

            frm.Show();
        }

        private void btcancelarreg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btregistar_Click(object sender, EventArgs e)
        {
            utilizador();
        }

        private void utilizador()
        {
            if ((tbnomeregist.Text != "") && (tbnomeagriregis.Text != "") && (tbnemailregist.Text != "") && (tbpassregist.Text != "") && (tbconfrimpassregist.Text != "") && (tbmarcaregist.Text != "") && (tbteleregist.Text != "") && (tbmoradaregist.Text != "") && (tbncodposregist.Text != "") && (tbracapredregist.Text != "") && (tbnumcabregist.Text != ""))
            {

                try
                {

                    UtilizadorExteriorVO Utilizador = new UtilizadorExteriorVO();
                    UtilizadorExteriorBUS Utilizadorbus = new UtilizadorExteriorBUS();
                    Utilizador.nome = tbnomeagriregis.Text;
                    Utilizador.username = tbnomeregist.Text;
                    Utilizador.email = tbnemailregist.Text;
                    Utilizador.password = tbpassregist.Text;
                    Utilizador.marcaExploracao = tbmarcaregist.Text;
                    Utilizador.telefone = tbteleregist.Text;
                    Utilizador.morada = tbmoradaregist.Text;
                    Utilizador.codigoPostal = tbncodposregist.Text; 
                    Utilizador.idConcelho = Convert.ToInt32(cbconcelhoregist.SelectedValue);
                    Utilizador.RacaPredominante = tbracapredregist.Text;
                    Utilizador.numeroCabecas = Convert.ToInt32(tbnumcabregist.Text);


                    if (Utilizadorbus.InsertUtilizador(Utilizador) == 1)
                        MessageBox.Show("Utilizador Criado!");
                    else
                        MessageBox.Show(" falha");


                    tbnomeagriregis.Clear();
                    tbnomeregist.Clear();
                    tbnemailregist.Clear();
                    tbpassregist.Clear();
                    tbmarcaregist.Clear();
                    tbteleregist.Clear();
                    tbmoradaregist.Clear();
                    tbncodposregist.Clear();
                    tbracapredregist.Clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro a criar Conta!");
                    throw ex;
                    //conexao.Close();

                }


            }


        }
    }

}