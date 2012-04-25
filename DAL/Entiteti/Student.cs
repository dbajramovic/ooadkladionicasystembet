using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Student
    {
        long id;
        string ime, prezime;
        List<Single> ocjene = new List<Single>();

        public Student(string i, string p)  {
            ime=i;
            prezime=p;
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public long Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
