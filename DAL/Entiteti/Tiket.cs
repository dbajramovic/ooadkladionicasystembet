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
        double uplata;
        double dobitak;
        public Tiket(DateTime d, bool clan, double u, double dob)
        {
            datum = d;
            je_li_clan_uplatio = clan;
            uplata = u;
            dobitak = dob;
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
    }
}

