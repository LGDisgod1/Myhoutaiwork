using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApplication2.Model;
using ConsoleApplication2.DataAccessLayers;

namespace ConsoleApplication2.BusinessLayers
{
   public class StudentBussinessLayers
    {
        //public void Add(Student Students)
        //{
        //    using (var db = new StudentContext())
        //    {
        //        db.Students.Add(Students);
        //        db.Entry(Students).State = EntityState.Added;
        //        db.SaveChanges();
        //    }
        //}
        public void Add(Classroom cls)
        {
            using (var db = new StudentContext())
            {
                db.Classrooms.Add(cls);
                
                db.SaveChanges();
            }
        }
    }
}
