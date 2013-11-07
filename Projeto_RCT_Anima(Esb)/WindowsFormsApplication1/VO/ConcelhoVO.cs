using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.VO
{
    public class ConcelhoVO
    {
        private int _idConcelho;
        private string _nome;
        private int _idDistrito;

        public int IdDistrito
        {
            get { return _idDistrito; }
            set { _idDistrito = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        

        public int IdConcelho
        {
            get { return _idConcelho; }
            set { _idConcelho = value; }
        }
        


    }
}
