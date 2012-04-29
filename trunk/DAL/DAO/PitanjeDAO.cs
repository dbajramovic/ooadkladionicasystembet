using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Entiteti;
using DAL.Interfejsi;
using MySql.Data.MySqlClient;


namespace DAL
{
    partial class DAL
    {
        public class PitanjeDAO : IDaoCrud<Pitanje>
        {
            #region IDaoCrud<Pitanje> Members
            protected MySqlCommand c;

            public long create(Pitanje entity)
            {
                try
                {
                    c = new MySqlCommand("INSERT INTO kviz (Pitanje,OdgovorA,OdgovorB,OdgovorC,OdgovorD,TacanOdgovor,idKviz) VALUES ('" + entity.TekstPitanja + "','" + entity.OdgovorA + "','"+ entity.OdgovorB+"','"+ entity.OdgovorC+"','"+ entity.OdgovorD+"','"+entity.TacanOdgovor+"','"+entity.Id+"')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Pitanje> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from kviz", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Pitanje> Pitanja = new List<Pitanje>();
                    while (r.Read())
                        Pitanja.Add(new Pitanje(r.GetString("Pitanje"), r.GetString("OdgovorA"),r.GetString("OdgovorB"),r.GetString("OdgovorC"),r.GetString("OdgovorD"),r.GetInt32("TacanOdgovor")));
                    return Pitanja;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Pitanje read(Pitanje entity)
            {
                throw new NotImplementedException();
            }

            public Pitanje update(Pitanje entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Pitanje entity)
            {
                throw new NotImplementedException();
            }

            public Pitanje getById(int id)
            {
                throw new NotImplementedException();
            }

            public List<Pitanje> getByExample(string name, string value)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}
