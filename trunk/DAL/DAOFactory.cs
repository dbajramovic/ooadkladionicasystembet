using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DAL
{
    partial class DAL
    {
        public class DAOFactory             // Inner klasa 
        {
            // Method factory dizajn pattern
            // public enum FactoryTip { MySQL }
            // public static DAOFactory GetDAOFactory(FactoryTip tip){
            //    switch (tip)
            //    {
            //        case FactoryTip.MySQL:
            //            return new MySQLDAOFactory();
            //    }
            //}

            private static DAOFactory instanca = null;
            public static DAOFactory Instanca
            {
                get { return (instanca == null) ? instanca = new DAOFactory() : instanca; }
            }

            private DAOFactory() { }

            public DogadjajDAO getDogadjajDAO()
            {
                return new DogadjajDAO();
            }
            public TiketDAO getTiketDAO()
            {
                return new TiketDAO();
            }
            public OsobaDAO getOsobaDAO()
            {
                return new OsobaDAO();
            }
            public ClanDAO getClanDAO()
            {
                return new ClanDAO();
            }
            public UposlenikDAO getUposlenikDAO()
            {
                return new UposlenikDAO();
            }
            public UcesnikDAO getUcesnikDAO()
            {
                return new UcesnikDAO();
            }
            public TakmicenjeDAO getTakmicenjeDAO()
            {
                return new TakmicenjeDAO();
            }
        }
    }
}
