using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Encrypt
    {
        string a;
        public Encrypt()
        { a = "w"; }
        public string EncryptString(string ulaz)
        {
            string izlaz="";
            foreach (char c in ulaz)
            {
                izlaz += Convert.ToChar(Convert.ToInt32(c)-13);
            }
            return izlaz;
        }
        public string DecryptString(string ulaz)
        {
            string izlaz = "";
            foreach (char c in ulaz)
            {
                izlaz += Convert.ToChar(Convert.ToInt32(c) + 13);
            }
            return izlaz;
        }
    }
}
