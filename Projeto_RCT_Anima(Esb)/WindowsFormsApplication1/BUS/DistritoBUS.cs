using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.VO;
using WindowsFormsApplication1.DAO;

namespace WindowsFormsApplication1.BUS
{
    public class DistritoBUS
    {

        public static List<DistritoVO> GetDistritos()
        {
            try
            {
                return DistritoDAO.GetDistritos();
            }
            catch
            {
                throw;
            }
        }


        public static List<DistritoVO> GetDistritos1()
        {
            try
            {
                return DistritoDAO.GetDistritos1();
            }
            catch
            {
                throw;
            }
        }

    }
}
