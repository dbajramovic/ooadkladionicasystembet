using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Takmicenje
    {
        string naziv;
        int id;
        List<Ucesnik> lista_ucesnika;
        public Takmicenje(string n) { naziv = n; lista_ucesnika = new List<Ucesnik>(); }
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public List<Ucesnik> Listaucesnika
        {
            get { return lista_ucesnika; }
            set { lista_ucesnika = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public void DodajUcesnika(Ucesnik u)
        {
            lista_ucesnika.Add(u);
        }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
