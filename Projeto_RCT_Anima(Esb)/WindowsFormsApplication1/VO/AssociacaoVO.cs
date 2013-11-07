using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.VO
{
    public class AssociacaoVO
    {
        private int _idAssociacao;
        private string _nome;
        private string _nomeFuncionario;
        private string _contactoFuncionario;
        private string _emailGeral;
        private string _emailContacto;
        private string _morada;
        private string _telefone;

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public string Morada
        {
            get { return _morada; }
            set { _morada = value; }
        }
        

        public string EmailContacto
        {
            get { return _emailContacto; }
            set { _emailContacto = value; }
        }
        

        public string EmailGeral
        {
            get { return _emailGeral; }
            set { _emailGeral = value; }
        }
        

        public string ContactoFuncionario
        {
            get { return _contactoFuncionario; }
            set { _contactoFuncionario = value; }
        }
        

        public string NomeFuncionario
        {
            get { return _nomeFuncionario; }
            set { _nomeFuncionario = value; }
        }
        

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
      

        public int IdAssociacao
        {
            get { return _idAssociacao; }
            set { _idAssociacao = value; }
        }
        


    }
}
