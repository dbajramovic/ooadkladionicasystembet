using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Entiteti;


namespace TestnaAplikacija
{
    class Program
    {
        static void Main(string[] args)
        {
            try
           {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "kladionica", "root", "");

             /*  DAL.DAL.StudentDAO sd = d.getDAO.getStudentDAO();
                Student novi = new Student("a", "b");
                novi.Id = sd.create(novi);*/

                DAL.DAL.DogadjajDAO dd = d.getDAO.getDogadjajDAO();
                Dogadjaj novi1 = new Dogadjaj("a", "b",1.23,2.12,7.45,1.09,2.29,5.89);
            //   novi1.ID_Dogadjaja = dd.create(novi1);

                List<Dogadjaj> dogadjaji = dd.getAll();
                foreach (Dogadjaj s in dogadjaji)
                    Console.WriteLine(s.ImePrvogUcesnika);

          /*      List<Student> studenti = sd.getAll();
                foreach (Student s in studenti)
                    Console.WriteLine(s.Ime);*/

                d.terminirajKonekciju();
           }
           catch (Exception e)
           {
              Console.WriteLine(e.Message);
              Console.ReadKey();
          }
        }
    }
}
