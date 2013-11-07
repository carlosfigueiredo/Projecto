using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.BUS;
using WindowsFormsApplication1.VO;


namespace WindowsFormsApplication1
{
    public partial class Forminicial : Form
    {
        
        public Forminicial()
        {
            InitializeComponent();
            password_txt.PasswordChar='*';
             
    }

        private void btloggin_Click(object sender, EventArgs e)
        {
        try{

            //String myConnection = "datasource=localhost;port=3306;username=root;password=;";
            //MySqlConnection myConn = new MySqlConnection(myConnection);

            //MySqlCommand SelectComand = new MySqlCommand("select * from bmnd.agricultor where username='" + this.username_txt.Text + "'and password='"+ this.password_txt.Text +"' ;", myConn);
            //MySqlDataReader myReader;
            //myConn.Open();
            //myReader = SelectComand.ExecuteReader();
            //int count = 0;
            //while (myReader.Read())
            //{
            //    count = count + 1;
            //}

            AgricultorBUS Agricultorbus = new AgricultorBUS();

            bool var = false;
            for (int i = 0; i < Agricultorbus.GetLoginAgricultor().Count(); i++)
            {
                if (Agricultorbus.GetLoginAgricultor()[i].Username.Equals(username_txt.Text) && Agricultorbus.GetLoginAgricultor()[i].Password.Equals(password_txt.Text))
                    var = true;

            }
                if (var)
                {
                    MessageBox.Show("Username e password Correctos");
                }

                else
                {
                    MessageBox.Show("Username e Password errados...Tente outravez.");
                    //myConn.Close();
                }


        }
            catch(Exception ex){

                MessageBox.Show(ex.Message);
        }
        Formnovaexploracao frm = new Formnovaexploracao(username_txt.Text);

        frm.Show();
        Hide();
        }

        private void Forminicial_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {

        }

        private void panelTarefas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFrente_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxLogotipo_Click(object sender, EventArgs e)
        {

        }

        private void panelPub3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panelPub2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btregistar_Click(object sender, EventArgs e)
        {
            Formnovoagricultor frm = new Formnovoagricultor();

            frm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            Formnovaexploracao frm = new Formnovaexploracao(username_txt.Text);

            frm.Show();
            Hide();

        }


        
    }
}
