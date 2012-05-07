using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Osoba
    {
        String imeprezime;
        String JMBG;
        public Osoba(String i, String j)
        {
            imeprezime = i;
            JMBG = j;
        }

        public String ImePrezime
        {
            get { return imeprezime; }
            set { imeprezime = value; }
        }

        public String Jmbg
        {
            get { return JMBG; }
            set { JMBG = value; }
        }
    }
}

