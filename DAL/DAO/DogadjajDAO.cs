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
            protected MySqlCommand c,u,d;

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
                    {
                         Dogadjaj f = new Dogadjaj(r.GetString("ImePU"), r.GetString("ImeDU"), r.GetDouble("Kvota1"), r.GetDouble("KvotaX"), r.GetDouble("Kvota2"), r.GetDouble("Kvota1X"), r.GetDouble("KvotaX2"), r.GetDouble("Kvota12"), r.GetString("DatumOdrzavanja"), r.GetInt32("SatnicaOdrzavanja"));
                         f.Id = r.GetInt32("IDDogadjaja");
                        dogadjaji.Add(f);
                    }
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
                u = new MySqlCommand("UPDATE dogadjaji SET ImePU = '"+entity.ImePrvogUcesnika+"',ImeDU='"+entity.ImeDrugogUcesnika+"',Kvota1="+entity.Kvota_1+",KvotaX="+entity.Kvota_X+",Kvota2="+entity.Kvota_2+",Kvota1X="+entity.Kvota_1X+",KvotaX2="+entity.Kvota_2+",Kvota12="+entity.Kvota_12+",DatumOdrzavanja='"+entity.DatumOdrzavanja+"',SatnicaOdrzavanja="+entity.SatnicaOdrzavanja+",Rezultat="+entity.Rezultat+" WHERE IDDogadjaja = "+entity.Id,con);
                u.ExecuteNonQuery();
                return entity;
            }

            public void delete(Dogadjaj entity)
            {
                d = new MySqlCommand("DELETE FROM dogadjaji WHERE IDDogadjaja = " + entity.Id, con);
                d.ExecuteNonQuery();
            }

            public Dogadjaj getById(int id)
            {
                c = new MySqlCommand("SELECT * from dogadjaji WHERE IdDogadjaja='"+id+"'", con);
                MySqlDataReader r = c.ExecuteReader();
                r.Read();
                Dogadjaj dog = new Dogadjaj(r.GetString("ImePU"), r.GetString("ImeDU"), r.GetDouble("Kvota1"), r.GetDouble("KvotaX"), r.GetDouble("Kvota2"), r.GetDouble("Kvota1X"), r.GetDouble("KvotaX2"), r.GetDouble("Kvota12"), r.GetString("DatumOdrzavanja"), r.GetInt32("SatnicaOdrzavanja"));
                dog.Rezultat = r.GetInt32("Rezultat");
                dog.Id = r.GetInt32("IDDogadjaja");
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
