using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Encript
    {
        public static string Encriptar(string pass){

            string a = 6 + pass + 9;
            char[] ch = a.ToCharArray();
            Array.Reverse(ch);
            //string b = ch.ToString();
            string b = new string(ch);



            return ConvertStringToHex(b); 
            

        }
        public static string Desencriptar(string enc)
        {

            string a = ConvertHexToString(enc);
            char[] ch = a.ToCharArray();
            Array.Reverse(ch);
            //string aa = ch.ToString();
            string aa = new string(ch);
            string b = aa.Remove(0, 1);
            string c = b.Remove(b.Length - 1);


            return c;
            

        }
        public static string ConvertStringToHex(string asciiString)
        {
            string hex = "";
            foreach (char c in asciiString)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            return hex;
        }

        public static string ConvertHexToString(string HexValue)
        {
            string StrValue = "";
            while (HexValue.Length > 0)
            {
                StrValue += System.Convert.ToChar(System.Convert.ToUInt32(HexValue.Substring(0, 2), 16)).ToString();
                HexValue = HexValue.Substring(2, HexValue.Length - 2);
            }
            return StrValue;
        }
        
    }


}
