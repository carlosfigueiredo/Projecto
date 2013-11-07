using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.VO;
using WindowsFormsApplication1.BUS;
using System.Collections;


namespace WindowsFormsApplication1
{

    

    public partial class Formnovaexploracao : Form
    {

        //private MySqlConnection conexao;
        //private DataSet conexaoDataSet;
        //private MySqlDataAdapter conexaoDataAdapter;
        public Formnovaexploracao()
        {
            //cbdistritoexpl.Items.Insert(0,new ListViewItem("fd",""));

            
            InitializeComponent();
            
            
    //define o dataset
            //  mDataSet = new DataSet();
 
    //define string de conexao e cria a conexao
            // mConn = new MySqlConnection(" Persist Security Info=False;server=localhost;database=bmnd;uid=root");

            //try{
        //abre a conexao
       //  mConn.Open();
       //}
            //catch(System.Exception e)
       //{
       // MessageBox.Show(e.Message.ToString());
      // }
 
       //verificva se a conexão esta aberta
            //if (mConn.State == ConnectionState.Open)
      //{
        //cria um adapter usando a instrução SQL para acessar a tabela Clientes
          //mAdapter = new  MySqlDataAdapter("SELECT * FROM agricultor", mConn);
        //preenche o dataset via adapter
          //mAdapter.Fill(mDataSet, "agricultor");
        //atribui a resultado a propriedade DataSource do DataGrid
        //DataGrid.DataSource = mDataSet;
          //DataGrid.DataMember = "agricultor";
   // }
        }

        public string variavelLocal { get; set; }

        //Construtor com parametros do novo Form
        public Formnovaexploracao(string variavel)
        {
            InitializeComponent();

            //atribuis à variável local o parametro que foi passado no construtor do novo Form
            variavelLocal = variavel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(variavelLocal);
        }
       

        private void Formnovaexploracao_Load(object sender, EventArgs e)
        {
            //conexaoDataSet = new DataSet();
            //conexao = new MySqlConnection("Server=localhost;Database=bmnd;User=root;Password=");

            cbdistritoexpl.DataSource = DistritoBUS.GetDistritos();
            cbdistritoexpl.DisplayMember = "nome";
            cbdistritoexpl.ValueMember = "idDistrito";

            cbconcelhoexpl.DataSource = ConcelhoBUS.GetConcelhos(Convert.ToInt32(cbdistritoexpl.SelectedValue));
            cbconcelhoexpl.DisplayMember = "nome";
            cbconcelhoexpl.ValueMember = "idConcelho";

            //cbdistritoexpl.Items.Insert(0, "test");

            cbtipoprodexpl.DataSource = TipoProducaoBUS.GetTipoProducao();
            cbtipoprodexpl.DisplayMember = "descricaoProducao";
            cbtipoprodexpl.ValueMember = "idTipoProducao";
           
            

        }


        private void exploracao()
        {
            if((tbnregexplo.Text != "") && (tbnifexp.Text != "") && (tbnomeexp.Text != "") && (tbmarcaexpl.Text != "") && (tbmoradaexpl.Text != "") && (tbcodpostexpl.Text != "") && (tbtelefexpl.Text != "") && (tbsistemaexplo.Text != "") && (tbparcelexpl.Text != "") && (tbfregexpl.Text != "")){

                try
                {
                    //AgricultorVO Agricultor = new AgricultorVO();
                    //Agricultor.NomeDetentor = tbnome.Text;
                    //Agricultor.MoradaDetentor = tbmorada.Text;
                    //Agricultor.Nif = tbnif.Text;
                    //Agricultor.Telefone = tbtlm.Text;
                    //Agricultor.Email = tbemail.Text;
                    //Agricultor.Password = tbpass.Text;
                    //Agricultor.Username = tbuser.Text;

                    //AgricultorBUS Agricultorbus = new AgricultorBUS();

                    //if (Agricultorbus.InsertAgricultor(Agricultor) == 1)
                    //    MessageBox.Show("Agricultor inserido");
                    //else
                    //    MessageBox.Show(" falha");
                    //AgricultorVO Agricultor = new AgricultorVO();
                    TipoProducaoVO TipoProducao = new TipoProducaoVO();
                    AssociacaoVO Associacao = new AssociacaoVO();
                    ExploracaoVO Exploracao = new ExploracaoVO();
                    AgricultorBUS Agricultor = new AgricultorBUS();
                    Exploracao.NRegistoExploracao = tbnregexplo.Text;
                    Exploracao.Nif = tbnifexp.Text;
                    Exploracao.NomeExploracao = tbnomeexp.Text;
                    Exploracao.Marca = tbmarcaexpl.Text;
                    Exploracao.Local = tbmoradaexpl.Text;
                    Exploracao.CodPostal = tbcodpostexpl.Text;
                    Exploracao.IdAgricultor = Convert.ToInt32(Agricultor.GetIdAgricultor(variavelLocal));
                    Exploracao.IdConcelho = Convert.ToInt32(cbconcelhoexpl.SelectedValue);
                    Exploracao.Telefone = tbtelefexpl.Text;
                    Exploracao.SistemaExploracao = tbsistemaexplo.Text;
                    Exploracao.ParcelarioRef = tbparcelexpl.Text;
                    Exploracao.Freguesia = tbfregexpl.Text;
                    Associacao.Nome = tbnomeass.Text;
                    Associacao.NomeFuncionario = tbnomefuncass.Text;
                    Associacao.ContactoFuncionario = tbcontactfuncass.Text;
                    Associacao.EmailGeral = tbemailgeralass.Text;
                    Associacao.EmailContacto = tbemailcontacass.Text;
                    Associacao.Morada = tbmoradaass.Text;
                    Associacao.Telefone = tbteleass.Text;
                    TipoProducao.IdTipoProducao = Convert.ToInt32(cbtipoprodexpl.SelectedValue);
                    

                    ExploracaoBUS Exploracaobus = new ExploracaoBUS();

                    if (Exploracaobus.InsertExploracao(Exploracao, Associacao, TipoProducao) == 1)
                        MessageBox.Show("Exploração inserida");
                    else
                        MessageBox.Show(" falha");



                    tbnregexplo.Clear();
                    tbnifexp.Clear();
                    tbnomeexp.Clear();
                    tbmarcaexpl.Clear();
                    tbmoradaexpl.Clear();
                    tbcodpostexpl.Clear();
                    tbtelefexpl.Clear();
                    tbsistemaexplo.Clear();
                    tbparcelexpl.Clear();
                    tbfregexpl.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro a criar exploração!");
                    throw ex;
                    //conexao.Close();

                }


            }


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tbtipoprod_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void btinsertexplo_Click(object sender, EventArgs e)
        {
            exploracao();
        }

        private void cbdistritoexpl_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (!cbdistritoexpl.Text.Equals(""))
            {
                //cbdistritoexpl.DataSource = DistritoBUS.GetDistritos();
                cbdistritoexpl.DisplayMember = "nome";
                cbdistritoexpl.ValueMember = "idDistrito";

                cbconcelhoexpl.DataSource = ConcelhoBUS.GetConcelhos(Convert.ToInt32(cbdistritoexpl.SelectedValue));
                cbconcelhoexpl.DisplayMember = "nome";
                cbconcelhoexpl.ValueMember = "idConcelho";
            }
        }

       

        
    }
}
