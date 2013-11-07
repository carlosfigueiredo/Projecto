using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.VO
{
    public class AgricultorVO
    {
        private int _idAgricultor;
        private string _nomeDetentor;
        private string _moradaDetentor;
        private string _nif;
        private string _telefone;
        private bool _ativo;
        private string _email;
        private string _password;
        private string _username;
        private string _dataRegisto;

        public string DataRegisto
        {
            get { return _dataRegisto; }
            set { _dataRegisto = value; }
        }

        public string MoradaDetentor
        {
            get { return _moradaDetentor; }
            set { _moradaDetentor = value; }
        }

        public string Nif
        {
            get { return _nif; }
            set { _nif = value; }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string NomeDetentor
        {
            get { return _nomeDetentor; }
            set { _nomeDetentor = value; }
        }
        

        public int IdAgricultor
        {
            get { return _idAgricultor; }
            set { _idAgricultor = value; }
        }
        
    }
}
