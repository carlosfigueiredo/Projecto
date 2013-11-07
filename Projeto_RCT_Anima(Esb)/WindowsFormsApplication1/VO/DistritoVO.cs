using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.VO
{
    public class DistritoVO
    {
        private int _idDistrito;
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int IdDistrito
        {
            get { return _idDistrito; }
            set { _idDistrito = value; }
        }
        

    }
}
