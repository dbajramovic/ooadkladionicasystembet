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
        public class DogadjajDAO : IDaoCrud<Dogadjaj>
        {
            #region IDaoCrud<Dogadjaj> Members
            protected MySqlCommand c;

            public long create(Dogadjaj entity)
            {
                try
                {
                    c = new MySqlCommand("INSERT INTO dogadjaji (ImePU,ImeDU,Kvota1,KvotaX,Kvota2,Kvota1X,KvotaX2,Kvota12,DatumOdrzavanja,SatnicaOdrzavanja) VALUES ('" + entity.ImePrvogUcesnika + "','" + entity.ImeDrugogUcesnika + "','"+ entity.Kvota_1+"','"+entity.Kvota_X+ "','"+ entity.Kvota_2 + "','" + entity.Kvota_1X + "','" + entity.Kvota_X2 +"','"+ entity.Kvota_12 + "','" + Convert.ToString(entity.DatumOdrzavanja) + "','" + entity.SatnicaOdrzavanja +"')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Dogadjaj> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from dogadjaji", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Dogadjaj> dogadjaji = new List<Dogadjaj>();
                    while (r.Read())
                        dogadjaji.Add(new Dogadjaj(r.GetString("ImePU"), r.GetString("ImeDU"), r.GetDouble("Kvota1"), r.GetDouble("KvotaX"), r.GetDouble("Kvota2"), r.GetDouble("Kvota1X"), r.GetDouble("KvotaX2"), r.GetDouble("Kvota12"), r.GetDateTime("DatumOdrzavanja"), r.GetInt32("SatnicaOdrzavanja")));
                    r.Close();
                    return dogadjaji;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Dogadjaj read(Dogadjaj entity)
            {
                throw new NotImplementedException();
            }

            public Dogadjaj update(Dogadjaj entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Dogadjaj entity)
            {
                throw new NotImplementedException();
            }

            public Dogadjaj getById(int id)
            {
                c = new MySqlCommand("select '"+id+ "' from dogadjaji", con);
                MySqlDataReader r = c.ExecuteReader();
                Dogadjaj dog = new Dogadjaj(r.GetString("ImePU"), r.GetString("ImeDU"), r.GetDouble("Kvota1"), r.GetDouble("KvotaX"), r.GetDouble("Kvota2"), r.GetDouble("Kvota1X"), r.GetDouble("KvotaX2"), r.GetDouble("Kvota12"), r.GetDateTime("DatumOdrzavanja"), r.GetInt32("SatnicaOdrzavanja"));
                dog.Rezultat = r.GetInt32("Rezultat");
                r.Close();
                return dog;
            }

            public List<Dogadjaj> getByExample(string name, string value)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}
