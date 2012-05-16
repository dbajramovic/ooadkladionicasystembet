using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Clan :  Osoba 
    {
        double IDClana;
        string picpath;
        public Clan(string i, string j, string p) : base(i, j) { picpath = p; }
        ~Clan() { }

        public double DajIDClana
        {
            get { return IDClana; }
            set { IDClana = value; }
        }
        public string Picpath
        {
            get { return picpath; }
            set { picpath = value; }
        }
    }

}