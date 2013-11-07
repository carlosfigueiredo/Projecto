using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.VO;
using WindowsFormsApplication1.DAO;

namespace WindowsFormsApplication1.BUS
{
    public class ConcelhoBUS
    {
        public static List<ConcelhoVO> GetConcelhos(int id)
        {
            try
            {
                return ConcelhoDAO.GetConcelhos(id);
            }
            catch
            {
                throw;
            }
        }
        public static List<ConcelhoVO> GetConcelhos1(int id)
        {
            try
            {
                return ConcelhoDAO.GetConcelhos1(id);
            }
            catch
            {
                throw;
            }
        }

    }


    }

