using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Interfejsi;
using DAL.Entiteti;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DAL
{
    partial class DAL
    {
        public class TakmicenjeDAO : IDaoCrud<Takmicenje>
        {
            #region IDaoCrud<Takmicenje> Members
            protected MySqlCommand c, u, d, g,k,p;

            public long create(Takmicenje entity)
            {
                return 1;
            }

            public List<Takmicenje> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from takmicenja", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Takmicenje> Takmicenja = new List<Takmicenje>();
                    while (r.Read())
                    {
                        Takmicenje f = new Takmicenje(r.GetString("Nazivtakmicenja"));
                        f.Id = r.GetInt32("IDTakmicenja");
                        Takmicenja.Add(f);
                    }
                    r.Close();
                    return Takmicenja;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Takmicenje read(Takmicenje entity)
            {
                throw new NotImplementedException();
            }

            public Takmicenje update(Takmicenje entity)
            {
                u = new MySqlCommand("UPDATE takmicenja SET NazivTakmicenja = '" + entity.Naziv + "' WHERE IDTakmicenja = " + entity.Id, con);
                u.ExecuteNonQuery();
                return entity;
            }

            public void delete(Takmicenje entity)
            {
                d = new MySqlCommand("DELETE FROM takmicenja WHERE IDTakmicenjea = " + entity.Id, con);
                d.ExecuteNonQuery();
            }

            public Takmicenje getById(int id)
            {
                c = new MySqlCommand("SELECT * from Takmicenja WHERE IdTakmicenjea='" + id + "'", con);
                MySqlDataReader r = c.ExecuteReader();
                r.Read();
                Takmicenje tak = new Takmicenje(r.GetString("NazivTakmicenja"));
                tak.Id = r.GetInt32("IDTakmicenja");
                r.Close();
                return tak;
            }

            public List<Takmicenje> getByExample(string name, string value)
            {
                List<Takmicenje> ld = new List<Takmicenje>();
                g = new MySqlCommand("SELECT * from takmicenja WHERE IdTakmicenja LIKE'" + name + "%'", con);
                MySqlDataReader r = g.ExecuteReader();
                while (r.Read())
                {
                    Takmicenje tak = new Takmicenje(r.GetString("NazivTakmicenja"));
                    tak.Id = r.GetInt32("IDTakmicenja");
                    ld.Add(tak);
                }
                r.Close();
                return ld;
            }
            public List<Ucesnik> DajPovezaneUcesnike(Takmicenje entity)
            {
                List<Ucesnik> a = new List<Ucesnik>();
                List<int> b = new List<int>();
                p = new MySqlCommand("SELECT IDUcesnika FROM takuc WHERE IDTakmicenja =" + entity.Id, con);
                MySqlDataReader r = p.ExecuteReader();
                while (r.Read())
                {
                    b.Add(r.GetInt32("IDUcesnika"));
                }
                r.Close();
                foreach (int f in b)
                {
                    k = new MySqlCommand("SELECT * FROM Ucesnik WHERE IDUcesnik=" + f, con);
                    MySqlDataReader r1 = k.ExecuteReader();
                    r1.Read();
                    a.Add(new Ucesnik(r1.GetString("ime"),r1.GetString("picpath")));
                    r1.Close();
                }
                return a;
            }
            #endregion
        }
    }
}
