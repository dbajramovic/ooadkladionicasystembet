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
            protected MySqlCommand c;

            public long create(Tiket entity)
            {
                try
                {
                    c = new MySqlCommand("insert into tiketi values ('" + Convert.ToString(entity.Datum) + "','" + Convert.ToString(entity.Da_Li_Je_Clan_Uplatio) + "','" + Convert.ToString(entity.Uplata) + "','" + Convert.ToString(entity.Dobitak) + "')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
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
                    c = new MySqlCommand("select * from tiketi", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Tiket> tiketi = new List<Tiket>();
                    while (r.Read())
                        tiketi.Add(new Tiket(r.GetDateTime("datum"), r.GetBoolean("clanski_broj"), r.GetDouble("uplata"), r.GetDouble("dobitak")));
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


