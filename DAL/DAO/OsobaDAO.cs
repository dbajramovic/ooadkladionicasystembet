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
        public class OsobaDAO : IDaoCrud<Osoba>
        {
            #region IDaoCrud<Osoba> Members
            protected MySqlCommand c;

            public long create(Osoba entity)
            {
                try
                {
                    c = new MySqlCommand("insert into osoba values ('" + entity.Ime + "','" + entity.Jmbg + "')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Osoba> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from osoba", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Osoba> osobe = new List<Osoba>();
                    while (r.Read())
                        osobe.Add(new Osoba(r.GetString("ime i prezime"), r.GetString("JMBG")));
                    return osobe;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Osoba read(Osoba entity)
            {
                throw new NotImplementedException();
            }

            public Osoba update(Osoba entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Osoba entity)
            {
                throw new NotImplementedException();
            }

            public Osoba getById(int id)
            {
                throw new NotImplementedException();
            }

            public List<Osoba> getByExample(string name, string value)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}
