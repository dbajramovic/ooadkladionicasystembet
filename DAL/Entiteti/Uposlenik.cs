using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Uposlenik/*: Osoba*/
    {
        double IDUposlenika;
        String password;

        public Uposlenik(/*String i, String j,*/ double u, String pass)
        {
            /* ImePrezime = i;
             JMBG = j;*/
            IDUposlenika = u;
            password = pass;
        }
        ~Uposlenik() { }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public double UposlenikID
        {
            get { return IDUposlenika; }
            set { IDUposlenika = value; }
        }
    }
}