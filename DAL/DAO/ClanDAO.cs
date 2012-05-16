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
            protected MySqlCommand c,c1;

            public long create(Clan entity)
            {
                try
                {
                    c = new MySqlCommand("INSERT INTO clan (ImePrezime,JMBG) VALUES ('" + entity.ImePrezime+ "','"+entity.Jmbg+"')", con);
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
                    {
                        Clan f = new Clan(r.GetString("ImePrezime"), r.GetString("JMBG"),r.GetString("Picpath"));
                        f.DajIDClana=r.GetInt32("IDClana");
                        f.Picpath = r.GetString("Picpath");
                        clanovi.Add(f);
                    }
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
                c1 = new MySqlCommand("UPDATE clan SET ImePrezime= '" + entity.ImePrezime + "',JMBG='" + entity.Jmbg + "','"+entity.Picpath+"' ,PicPatch='"+entity.Picpath+" WHERE  IDClana="+entity.DajIDClana, con);
                c1.ExecuteNonQuery();
                return entity;
            }

            public void delete(Clan entity)
            {
                throw new NotImplementedException();
            }

            public Clan getById(int id)
            {
                c = new MySqlCommand("SELECT * from clan WHERE IdClana='" + id + "'", con);
                MySqlDataReader r = c.ExecuteReader();
                r.Read();
                Clan cla = new Clan(r.GetString("ImePrezime"), r.GetString("JMBG"),r.GetString("Picpath"));
                cla.DajIDClana = r.GetInt32("IDClana");
                cla.Picpath = r.GetString("Picpath");
                r.Close();
                return cla;
            }

            public List<Clan> getByExample(string name, string value)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}
