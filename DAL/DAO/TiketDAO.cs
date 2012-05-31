using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Interfejsi;
using DAL.Entiteti;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DAL
{
    partial class DAL
    {
        public class TiketDAO : IDaoCrud<Tiket>
        {
            #region IDaoCrud<Tiket> Members
            protected MySqlCommand c1,c2,g,d,p,k,g1;

            public long create(Tiket entity)
            {
                int brojac = 0;
                try
                {
                    c1 = new MySqlCommand("INSERT INTO tiketi (Datum,Clan,Uplata,Dobitak) VALUES ('" + Convert.ToString(entity.Datum) + "','" + Convert.ToString(entity.Da_Li_Je_Clan_Uplatio) + "','" + entity.Uplata + "','" + entity.Dobitak + "')", con);
                    c1.ExecuteNonQuery();
                    foreach (Dogadjaj d in entity.Dogadjaji)
                    {
                        c2 = new MySqlCommand("INSERT INTO tikdog (IDTiketa,IDDogadjaja) VALUES ('" + c1.LastInsertedId + "','" + entity.Dogadjaji[brojac].Id + "')", con);
                        c2.ExecuteNonQuery();
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
                        Tiket tik = new Tiket(Convert.ToDateTime(r.GetString("Datum")));
                        tik.Da_Li_Je_Clan_Uplatio = r.GetBoolean("Clan");
                        tik.Uplata = r.GetDouble("Uplata");
                        tik.Dobitak = r.GetDouble("Dobitak");
                        tik.ID_Tiketa = r.GetInt32("idtiketi");
                        tiketi.Add(tik);

                    }
                    r.Close();
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
                d = new MySqlCommand("DELETE FROM tiketi WHERE idtiketi = " + entity.ID_Tiketa, con);
                d.ExecuteNonQuery();
            }

            public Tiket getById(int id)
            {
                g = new MySqlCommand("SELECT * from tiketi WHERE idtiketi='" + id + "'", con);
                MySqlDataReader r = g.ExecuteReader();
                r.Read();
                Tiket tik = new Tiket(Convert.ToDateTime(r.GetString("Datum")));
                tik.Da_Li_Je_Clan_Uplatio = r.GetBoolean("Clan");
                tik.Uplata = r.GetDouble("Uplata");
                tik.Dobitak = r.GetDouble("Dobitak");
                tik.ID_Tiketa = r.GetInt32("idtiketi");
                r.Close();
                return tik;
            }

            public List<Tiket> getByExample(string name, string value)
            {
                List<Tiket> lista_tiketa = new List<Tiket>();
                g1 = new MySqlCommand("SELECT * from tiketi WHERE idtiketi LIKE'" + name + "%'", con);
                MySqlDataReader r = g1.ExecuteReader();
                while (r.Read())
                {
                    Tiket tik = new Tiket(Convert.ToDateTime(r.GetString("Datum")));
                    tik.Da_Li_Je_Clan_Uplatio = r.GetBoolean("Clan");
                    tik.Uplata = r.GetDouble("Uplata");
                    tik.Dobitak = r.GetDouble("Dobitak");
                    tik.ID_Tiketa = r.GetInt32("idtiketi");
                    lista_tiketa.Add(tik);

                }
                r.Close();
                return lista_tiketa;
            }
            public List<Dogadjaj> DajPovezaneDogadjaje(Tiket entity)
            {
                List<Dogadjaj> a = new List<Dogadjaj>();
                List<int> b = new List<int>();
                p = new MySqlCommand("SELECT IDDogadjaja FROM tikdog WHERE IDTiketa =" + entity.ID_Tiketa, con);
                MySqlDataReader r = p.ExecuteReader();
                while (r.Read())
                {
                    b.Add(r.GetInt32("IDDogadjaja"));
                }
                r.Close();
                foreach (int f in b)
                {
                    k = new MySqlCommand("SELECT * FROM Dogadjaji WHERE IDDogadjaja=" + f, con);
                    MySqlDataReader r1 = k.ExecuteReader();
                    r1.Read();
                    a.Add(new Dogadjaj(r1.GetString("ImePU"), r1.GetString("ImeDU"), r1.GetDouble("Kvota1"), r1.GetDouble("KvotaX"), r1.GetDouble("Kvota2"), r1.GetDouble("Kvota1X"), r1.GetDouble("KvotaX2"), r1.GetDouble("Kvota12"), r1.GetString("DatumOdrzavanja"), r1.GetInt32("SatnicaOdrzavanja")));
                    r1.Close();
                }
                return a;
            }
            #endregion
        }
    }
}


