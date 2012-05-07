using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Osoba
    {
        String ImePrezime;
        String JMBG;
        public Osoba(String i, String j)
        {
            ImePrezime = i;
            JMBG = j;
        }

        public String Ime
        {
            get { return ImePrezime; }
            set { ImePrezime = value; }
        }

        public String Jmbg
        {
            get { return JMBG; }
            set { JMBG = value; }
        }
    }
}

