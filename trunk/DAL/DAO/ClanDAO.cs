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
        public class ClanDAO : IDaoCrud<Clan>
        {
            #region IDaoCrud<Clan> Members
            protected MySqlCommand c;

            public long create(Clan entity)
            {
                try
                {
                    c = new MySqlCommand("insert into clan values ('" + entity.DajIDClana + "')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Clan> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from clan", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Clan> clanovi = new List<Clan>();
                    while (r.Read())
                        clanovi.Add(new Clan(r.GetDouble("id")));
                    return clanovi;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Clan read(Clan entity)
            {
                throw new NotImplementedException();
            }

            public Clan update(Clan entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Clan entity)
            {
                throw new NotImplementedException();
            }

            public Clan getById(int id)
            {
                throw new NotImplementedException();
            }

            public List<Clan> getByExample(string name, string value)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}
