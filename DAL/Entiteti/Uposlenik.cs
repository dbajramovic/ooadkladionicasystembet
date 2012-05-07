using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Uposlenik: Osoba
    {
        long iduposlenika;
        String password;

        public Uposlenik(String i, String j, String pass) : base(i,j)
        {
            password = pass;
        }
        ~Uposlenik() { }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public long IDUposlenika
        {
            get { return iduposlenika; }
            set { iduposlenika = value; }
        }
    }
}