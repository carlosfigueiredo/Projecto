using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Formtermos : Form
    {
        public Formtermos()
        {
            InitializeComponent();
            
        }

        private void btfechar_Click(object sender, EventArgs e)
        {

            Close();


        }

        private void Formtermos_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }

        private void Formtermos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
