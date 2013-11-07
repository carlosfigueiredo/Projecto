using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.VO;
using WindowsFormsApplication1.DAO;

namespace WindowsFormsApplication1.BUS
{
    public class TipoProducaoBUS
    {


        public static List<TipoProducaoVO> GetTipoProducao()
        {
            try
            {
                return TipoProducaoDAO.GetTipoProducao();
            }
            catch
            {
                throw;
            }
        }




    }
    
}
