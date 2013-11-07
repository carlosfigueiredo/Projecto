using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.VO;
using WindowsFormsApplication1.DAO;

namespace WindowsFormsApplication1.BUS
{
    public class ExploracaoBUS
    {
        public int InsertExploracao(ExploracaoVO Exploracao, AssociacaoVO Associacao, TipoProducaoVO TipoProducao)
        {
            try
            {
                return ExploracaoDAO.InsertExploracao(Exploracao, Associacao, TipoProducao);
            }
            catch
            {
                throw;
            }
        }

    }
}
