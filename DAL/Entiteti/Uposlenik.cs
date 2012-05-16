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
        string picpath;
        public Uposlenik(String i, String j, String pass,string pic) : base(i,j)
        {
            password = pass;
            picpath = pic;
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
        public string Picpath
        {
            get { return picpath; }
            set { picpath = value; }
        }
    }
}