using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.VO
{
    public class ExploracaoVO
    {
        private int _idExploracao;
        private string _NRegistoExploracao;
        private string _nif;
        private string _nomeExploracao;
        private string _marca;
        private DateTime _ano;
        private string _Local;
        private string _CodPostal;
        private string _Telefone;
        private string _sistemaExploracao;
        private int _idConcelho;
        private string _ParcelarioRef;
        private string _freguesia;
        private int _idAgricultor;
        private int _idAssociacao;

        public int IdAssociacao
        {
            get { return _idAssociacao; }
            set { _idAssociacao = value; }
        }

        public int IdAgricultor
        {
            get { return _idAgricultor; }
            set { _idAgricultor = value; }
        }

        public string Freguesia
        {
            get { return _freguesia; }
            set { _freguesia = value; }
        }

        public string ParcelarioRef
        {
            get { return _ParcelarioRef; }
            set { _ParcelarioRef = value; }
        }

        public int IdConcelho
        {
            get { return _idConcelho; }
            set { _idConcelho = value; }
        }

        public string SistemaExploracao
        {
            get { return _sistemaExploracao; }
            set { _sistemaExploracao = value; }
        }

        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        public string CodPostal
        {
            get { return _CodPostal; }
            set { _CodPostal = value; }
        }

        public string Local
        {
            get { return _Local; }
            set { _Local = value; }
        }

        public DateTime Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string NomeExploracao
        {
            get { return _nomeExploracao; }
            set { _nomeExploracao = value; }
        }

        public string Nif
        {
            get { return _nif; }
            set { _nif = value; }
        }

        public string NRegistoExploracao
        {
            get { return _NRegistoExploracao; }
            set { _NRegistoExploracao = value; }
        }

        public int IdExploracao
        {
            get { return _idExploracao; }
            set { _idExploracao = value; }
        }
        


    }
}
