using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Pitanje
    {
        long id;
        string tekstpitanja, odgovor_a, odgovor_b, odgovor_c, odgovor_d;
        int tacan_odgovor;
        public Pitanje (string tp,string oa,string ob,string oc,string od, int to)
        {
            tekstpitanja = tp;
            odgovor_a = oa;
            odgovor_b = ob;
            odgovor_c = oc;
            odgovor_d = od;
            tacan_odgovor = to;
        }
        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        public string TekstPitanja
        {
            get { return tekstpitanja; }
            set { tekstpitanja = value; }
        }
        public string OdgovorA
        {
            get { return odgovor_a; }
            set { odgovor_a = value; }
        }
        public string OdgovorB
        {
            get { return odgovor_b; }
            set { odgovor_b = value; }
        }
        public string OdgovorC
        {
            get { return odgovor_c; }
            set { odgovor_c = value; }
        }
        public string OdgovorD
        {
            get { return odgovor_d; }
            set { odgovor_d = value; }
        }
        public int TacanOdgovor
        {
            get { return tacan_odgovor; }
            set { tacan_odgovor = value; }
        }
    }
}
