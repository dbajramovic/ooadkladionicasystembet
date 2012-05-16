using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Interfejsi;
using DAL.Entiteti;
using MySql.Data.MySqlClient;

namespace DAL
{
    partial class DAL
    {
        public class UcesnikDAO : IDaoCrud<Ucesnik>
        {
            #region IDaoCrud<Ucesnik> Members
            protected MySqlCommand c;

            public long create(Ucesnik entity)
            {
                try
                {
                    c = new MySqlCommand("INSERT INTO Ucesnik (ImePrezime,JMBG) VALUES ('" + entity.Ime + "','" + entity.Picpath + "')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Ucesnik> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from Ucesnik", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Ucesnik> Ucesnikovi = new List<Ucesnik>();
                    while (r.Read())
                    {
                        Ucesnik f = new Ucesnik(r.GetString("ImePrezime"), r.GetString("JMBG"));
                        f.Id = r.GetInt32("IDUcesnika");
                        Ucesnikovi.Add(f);
                    }
                    return Ucesnikovi;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Ucesnik read(Ucesnik entity)
            {
                throw new NotImplementedException();
            }

            public Ucesnik update(Ucesnik entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Ucesnik entity)
            {
                throw new NotImplementedException();
            }

            public Ucesnik getById(int id)
            {
                c = new MySqlCommand("SELECT * from ucesnik WHERE iducesnik='" + id + "'", con);
                MySqlDataReader r = c.ExecuteReader();
                r.Read();
                Ucesnik cla = new Ucesnik(r.GetString("ime"), r.GetString("picpath"));
                cla.Id = r.GetInt32("iducesnik");
                r.Close();
                return cla;
            }

            public List<Ucesnik> getByExample(string name, string value)
            {
                List<Ucesnik> lista_uc = new List<Ucesnik>();
                c = new MySqlCommand("SELECT * from ucesnik WHERE ime like '" + name + "%' a", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read()) { 
                 Ucesnik cla = new Ucesnik(r.GetString("ime"), r.GetString("picpath"));
                    cla.Id = r.GetInt32("iducesnik");
                    lista_uc.Add(cla);
                }
                r.Close();
                return lista_uc;
            }

            #endregion
        }
    }
}
