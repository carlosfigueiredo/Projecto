using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.VO
{
    public class TipoProducaoVO
    {
        private int _idTipoProducao;
        private string _descricaoProducao;

        public string DescricaoProducao
        {
            get { return _descricaoProducao; }
            set { _descricaoProducao = value; }
        }

        public int IdTipoProducao
        {
            get { return _idTipoProducao; }
            set { _idTipoProducao = value; }
        }
       

    }
}
