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
        public class DogadjajDAO : IDaoCrud<Dogadjaj>
        {
            #region IDaoCrud<Dogadjaj> Members
            protected MySqlCommand c;

            public long create(Dogadjaj entity)
            {
                try
                {
                    c = new MySqlCommand("insert into dogadjaji values ('" + entity.ImeDrugogUcesnika + "','" + entity.ImeDrugogUcesnika + "','"+ entity.Kvota_1+"','"+entity.Kvota_X+ "','"+ entity.Kvota_2 + "','" + entity.Kvota_1X + "','" + entity.Kvota_X2 +"','"+ entity.Kvota_12 + "')", con);
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
                        dogadjaji.Add(new Dogadjaj(r.GetString("ime_prvog_ucesnika"), r.GetString("ime_drugog_ucesnika"), r.GetDouble("kvota_1"), r.GetDouble("kvota_x"), r.GetDouble("kvota_2"), r.GetDouble("kvota_1x"), r.GetDouble("kvota_x2"), r.GetDouble("kvota_12")));
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
                throw new NotImplementedException();
            }

            public List<Dogadjaj> getByExample(string name, string value)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}
