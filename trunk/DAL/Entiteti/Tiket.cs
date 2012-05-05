using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Entiteti;


namespace DAL.Entiteti
{
    public class Tiket
    {
        long id;
        DateTime datum;
        bool je_li_clan_uplatio;
        List<Dogadjaj> dogadjaji = new List<Dogadjaj>();
        List<int> lista_tipova = new List<int>();
        double uplata;
        double dobitak;
        public Tiket(DateTime d)
        {
            datum = d;
            je_li_clan_uplatio = false;
        }
        ~Tiket() { }
        public long ID_Tiketa
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
        public bool Da_Li_Je_Clan_Uplatio
        {
            get { return je_li_clan_uplatio; }
            set { je_li_clan_uplatio = value; }
        }
        public double Uplata
        {
            get { return uplata; }
            set { uplata = value; }
        }
        public double Dobitak
        {
            get { return dobitak; }
            set { dobitak = value; }
        }
        public void DodajDogadjaj(Dogadjaj d,int tip)
        {
            foreach (Dogadjaj a in dogadjaji)
            {
                if (a.Id == d.Id) throw new Exception("Događaj već dodan!");
            }
            if (Convert.ToDateTime(d.DatumOdrzavanja) < DateTime.Now) throw new Exception("Događaj već prošao!");
            dogadjaji.Add(d);
            lista_tipova.Add(tip);
        }
        public List<Dogadjaj> Dogadjaji
        {
            get { return dogadjaji; }
            set { dogadjaji = value; }
        }
        public List<int> ListaTipova
        {
            get { return lista_tipova; }
            set { lista_tipova = value; }
        }
    }
}

