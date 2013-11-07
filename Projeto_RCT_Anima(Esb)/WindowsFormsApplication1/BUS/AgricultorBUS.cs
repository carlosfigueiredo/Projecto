using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.VO;

namespace WindowsFormsApplication1.BUS
{
    public class AgricultorBUS
    {

        public int InsertAgricultor(AgricultorVO Agricultor)
        {
            try
            {
                return AgricultorDAO.InsertAgricultor(Agricultor);
            }
            catch
            {
                throw;
            }
        }

        public List<AgricultorVO> GetLoginAgricultor()
        {
            try
            {
                return AgricultorDAO.GetLoginAgricultor();
            }
            catch
            {
                throw;
            }
        }
        public int GetIdAgricultor(string username)
        {
            try
            {
                return AgricultorDAO.GetIdAgricultor(username);
            }
            catch
            {
                throw;
            }
        }

    }
}
