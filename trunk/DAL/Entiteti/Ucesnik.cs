using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Ucesnik
    {
        int id;
        private string ime, picpath;
        public Ucesnik(string i, string p)
        {
            ime = i;
            picpath = p;
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Picpath
        {
            get { return picpath; }
            set { picpath = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public override string ToString()
        {
            return Ime;
        }
    }
}
