using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    [Serializable]
    public class Dogadjaj
    {
        long id;
        String imePrvogUcesnika;
        String imeDrugogUcesnika;
        double kvota_1, kvota_2, kvota_X, kvota_1X, kvota_X2, kvota_12;
        int rezultat;
        string datumodrzavanja;
        int satnicaodrzavanja;
        public Dogadjaj(String ipu, String idu, double K1, double KX, double K2, double K1X, double KX2, double K12, string vo,int so)
        {
            imePrvogUcesnika = ipu;
            imeDrugogUcesnika = idu;
            kvota_1 = K1;
            kvota_X = KX;
            kvota_2 = K2;
            kvota_1X = K1X;
            kvota_X2 = KX2;
            kvota_12 = K12;
            datumodrzavanja = vo;
            satnicaodrzavanja = so;
            rezultat = -1;
        }
        ~Dogadjaj() { }
        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        public string ImePrvogUcesnika
        {
            get { return imePrvogUcesnika; }
            set { imePrvogUcesnika = value; }
        }
        public string ImeDrugogUcesnika { 
            get { return imeDrugogUcesnika; }
            set { imeDrugogUcesnika = value; }
        }
        public double Kvota_1
        {
            get { return kvota_1; }
            set { kvota_1 = value; }
        }
        public double Kvota_2 { 

            get { return kvota_2; }
            set { kvota_2 = value; }
        }
        public double Kvota_X { 
            get { return kvota_X; }
            set { kvota_X = value; }
        }
        public double Kvota_1X { 
            get { return kvota_1X; }
            set { kvota_1X = value; }
        }
        public double Kvota_X2 { 
            get { return kvota_X2; }
            set { kvota_X2 = value; }
        }
        public double Kvota_12 { 
            get { return kvota_12; }
            set { kvota_X2 = value; }
        }
        public string DatumOdrzavanja
        {
            get { return datumodrzavanja; }
            set { datumodrzavanja = value; }
        }
        public int SatnicaOdrzavanja
        {
            get { return satnicaodrzavanja; }
            set { satnicaodrzavanja = value; }
        }
        public int Rezultat
        {
            get { return rezultat; }
            set { rezultat = value; }
        }
    }
}
