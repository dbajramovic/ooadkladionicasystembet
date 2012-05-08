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
        public class UposlenikDAO : IDaoCrud<Uposlenik>
        {
            #region IDaoCrud<Uposlenik> Members
            protected MySqlCommand c;

            public long create(Uposlenik entity)
            {
                try
                {
                    c = new MySqlCommand("INSERT INTO uposlenik (ImePrezime,JMBG,Password) VALUES ('" + entity.ImePrezime + "','"+entity.Jmbg+"','" + entity.Password + "')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Uposlenik> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from uposlenik", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Uposlenik> uposlenici = new List<Uposlenik>();
                    while (r.Read())
                    {
                        Uposlenik u = new Uposlenik(r.GetString("ImePrezime"),r.GetString("JMBG"),r.GetString("Password"));
                        u.IDUposlenika = r.GetInt32("IDUposlenik");
                        uposlenici.Add(u);
                    }
                    return uposlenici;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Uposlenik read(Uposlenik entity)
            {
                throw new NotImplementedException();
            }

            public Uposlenik update(Uposlenik entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Uposlenik entity)
            {
                throw new NotImplementedException();
            }

            public Uposlenik getById(int id)
            {
                c = new MySqlCommand("SELECT * from uposlenik WHERE IdUposlenik='" + id + "'", con);
                MySqlDataReader r = c.ExecuteReader();
                r.Read();
                Uposlenik cla = new Uposlenik(r.GetString("ImePrezime"), r.GetString("JMBG"),r.GetString("Password"));
                cla.IDUposlenika = r.GetInt32("IDUposlenik");
                r.Close();
                return cla;
            }

            public List<Uposlenik> getByExample(string name, string value)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}
