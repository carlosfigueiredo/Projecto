using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.VO;
using WindowsFormsApplication1.DAO;

namespace WindowsFormsApplication1.BUS
{
    public class UtilizadorExteriorBUS
    {
        public int InsertUtilizador(UtilizadorExteriorVO Utilizador)
        {
            try
            {
                return UtilizadorExteriorDAO.InsertUtilizador(Utilizador);
            }
            catch
            {
                throw;
            }
        }
    }
}
