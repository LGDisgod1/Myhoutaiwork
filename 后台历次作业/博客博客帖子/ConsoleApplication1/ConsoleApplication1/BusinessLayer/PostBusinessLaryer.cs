using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApplication1.DataAccessLayer;
using ConsoleApplication1.Models;

namespace ConsoleApplication1.BusinessLayer
{
   public class PostBusinessLaryer
    {
        public void Add(Post post)
        {
            using (var db = new BloggingContext())
            {
                db.posts.Add(post);
                db.SaveChanges();
            }
        }
        public List<Post> Query()
        {
            using (var db = new BloggingContext())
            {
                return db.posts.ToList();
            }
        }
        public Post Query(int id)
        {
            using (var db = new BloggingContext())
            {
                return db.posts.Find(id);
            }
        }
        public void Update(Post post)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void Delete(Post post)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(post).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public List<Post>QueryForTitle(string title)
        {
            using (var db=new BloggingContext())
            {
                var query = from b in db.posts
                            where b.Title == title
                            select b;
                return query.ToList();
            }
        }
    }
}
