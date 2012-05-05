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
        public class TiketDAO : IDaoCrud<Tiket>
        {
            #region IDaoCrud<Tiket> Members
            protected MySqlCommand c1,c2;

            public long create(Tiket entity)
            {
                int brojac = 0;
                try
                {
                    c1 = new MySqlCommand("INSERT INTO tiketi (Datum,Clan,Uplata,Dobitak) VALUES ('" + Convert.ToString(entity.Datum) + "','" + Convert.ToString(entity.Da_Li_Je_Clan_Uplatio) + "','" + entity.Uplata + "','" + entity.Dobitak + "')", con);
                    c1.ExecuteNonQuery();
                    foreach (Dogadjaj d in entity.Dogadjaji)
                    {
                        c2 = new MySqlCommand("INSERT INTO tikdog (IDTiketa,IDDogadjaja) VALUES ('" + entity.ID_Tiketa + "','" + entity.Dogadjaji[brojac].Id + "')", con);
                        brojac++;
                    }
                    return c1.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Tiket> getAll()
            {
                try
                {
                    c1 = new MySqlCommand("select * from tiketi", con);
                    MySqlDataReader r = c1.ExecuteReader();
                    List<Tiket> tiketi = new List<Tiket>();
                    while (r.Read())
                    {
                        Tiket t = new Tiket(r.GetDateTime("datum"));
                        t.Dobitak = r.GetDouble("Dobitak");
                        t.Uplata = r.GetDouble("Uplata");
                        t.Da_Li_Je_Clan_Uplatio = r.GetBoolean("Clan");
                        tiketi.Add(t);
                    }
                    return tiketi;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Tiket read(Tiket entity)
            {
                throw new NotImplementedException();
            }

            public Tiket update(Tiket entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Tiket entity)
            {
                throw new NotImplementedException();
            }

            public Tiket getById(int id)
            {
                throw new NotImplementedException();
            }

            public List<Tiket> getByExample(string name, string value)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}


