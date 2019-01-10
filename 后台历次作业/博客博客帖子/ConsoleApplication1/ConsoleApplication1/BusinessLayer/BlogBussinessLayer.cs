using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.DataAccessLayer;
using ConsoleApplication1.Models;
using System.Data.Entity;

namespace ConsoleApplication1.BusinessLayer
{
   public class BlogBussinessLayer
    {
        public void Add(Blog Blog)
        {
            using (var db = new BloggingContext())
            {
                db.Blogs.Add(Blog);
                db.SaveChanges();
            }
        }
        public List<Blog> Query()
        {
            using(var db =new BloggingContext())
            {
                return db.Blogs.ToList();
            }
        }
        public Blog Query(int id)
        {
            using (var db = new BloggingContext())
            {
                return db.Blogs.Find(id);
            }
        }


        public void Update(Blog blog)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(blog).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void Delete(Blog blog)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(blog).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
}
}
