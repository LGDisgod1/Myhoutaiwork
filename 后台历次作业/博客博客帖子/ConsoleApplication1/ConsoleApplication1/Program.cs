using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models;
using ConsoleApplication1.BusinessLayer;
using ConsoleApplication1.DataAccessLayer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //createBlog();
            //QueryAllBlog();
            //Delete();
            //Update();
            //AddPost();
            //gong();
            //Console.WriteLine("按任意键退出");
            //Console.ReadKey();
            QueryForPost();
            Console.ReadKey();
            while (true)
            {
                Console.Clear();
                Boke();

            }
            //增加----交互
        }
        static void Boke()
        {

            QueryAllBlog();

            Console.WriteLine("1--新增博客  2--删除博客   3--更新博客  4--查找博客帖子");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    createBlog();
                    Console.Clear();

                    break;
                case 2:
                    Delete();
                    Console.Clear();

                    break;
                case 3:
                    Update();
                    Console.Clear();

                    break;
                case 4:



                    Huite();

                    break;


            }
        }


        static void Huite()
        {

            int blogid = getBlogid();
            while (true)
            {
                Console.Clear();
                DisplayPosts(blogid);
                Console.WriteLine("n--新增博客   d--删除博客   u--更新博客   r--查询博客帖子");
                int num2 = int.Parse(Console.ReadLine());
                switch (num2)
                {
                    case 1:

                        Post post = new Post();
                        //填写帖子属性
                        Console.WriteLine("请输入帖子标题");
                        post.Title = Console.ReadLine();
                        Console.WriteLine("请输入帖子内容");
                        post.Content = Console.ReadLine();
                        post.BlogId = blogid;
                        //帖子通过数据上下文新增
                        using (var db = new BloggingContext())
                        {
                            db.posts.Add(post);
                            db.SaveChanges();
                        }
                        //显示指定博客的帖子列表
                        DisplayPosts(blogid);
                        break;
                    case 2:

                        break;
                    case 3:

                        postDelete();
                        DisplayPosts(blogid);

                        break;
                    case 4:
                        Console.Clear();
                        Boke();
                        break;
                }
            }

        }
        static void AddPost()
        {

            //用户选择某个博客（id）
            int blogid = getBlogid();
            //显示指定博客的帖子列表
            DisplayPosts(blogid);
            //根据指定到博客信息创建新帖子
            //新建帖子
            Post post = new Post();
            //填写帖子属性
            Console.WriteLine("请输入帖子标题");
            post.Title = Console.ReadLine();
            Console.WriteLine("请输入帖子内容");
            post.Content = Console.ReadLine();
            post.BlogId = blogid;
            //帖子通过数据上下文新增
            using (var db = new BloggingContext())
            {
                db.posts.Add(post);
                db.SaveChanges();
            }
            //显示指定博客的帖子列表
            DisplayPosts(blogid);
        }


        static int getBlogid()
        {

            Console.WriteLine("请输入博客id");
            int id = int.Parse(Console.ReadLine());
            return id;

        }

        static void DisplayPosts(int blogid)
        {


            List<Post> list = null;
            //根据博客id获取博客
            using (var db = new BloggingContext())
            {
                Blog blog = db.Blogs.Find(blogid);
                list = blog.Posts;
            }
            //Console.WriteLine(blogs.Name);

            //显示帖子列表
            foreach (var item in list)
            {
                Console.WriteLine(item.PostId + "--" + item.Title + "--" + item.Content);
            }

        }
        static void PostByID(int blogID)
        {
            Console.WriteLine("请输入一个帖子的名称");

        }

        static void createBlog()
        {
            Console.WriteLine("请输入一个博客名称");
            string name = Console.ReadLine();
            Blog blog = new Blog();
            blog.Name = name;
            BlogBussinessLayer bbl = new BlogBussinessLayer();
            bbl.Add(blog);
        }

        //显示全部的博客
        static void QueryAllBlog()
        {
            BlogBussinessLayer bbl = new BlogBussinessLayer();
            var blogs = bbl.Query();
            foreach (var item in blogs)
            {

                Console.WriteLine(item.BlogId + " " + item.Name);
            }
        }

        static void Update()
        {
            Console.WriteLine("请输入id");
            int id = int.Parse(Console.ReadLine());
            BlogBussinessLayer bbl = new BlogBussinessLayer();
            Blog blog = bbl.Query(id);
            Console.WriteLine("请输入新名字");
            string name = Console.ReadLine();
            blog.Name = name;
            bbl.Update(blog);
        }
        static void Delete()
        {
            BlogBussinessLayer bbl = new BlogBussinessLayer();
            Console.WriteLine("请输入id");
            int id = int.Parse(Console.ReadLine());
            Blog blog = bbl.Query(id);
            bbl.Delete(blog);
        }
        static void postDelete()
        {
            PostBusinessLaryer bbl = new PostBusinessLaryer();
            Console.WriteLine("请输入id");
            int id = int.Parse(Console.ReadLine());
            Post plog = bbl.Query(id);
            bbl.Delete(plog);
        }
        static void postcreateBlog()
        {
            Console.WriteLine("请输入一个帖子名称");
            string name = Console.ReadLine();
            Post plog = new Post();
            plog.Title = name;
            PostBusinessLaryer bbl = new PostBusinessLaryer();
            bbl.Add(plog);
        }
static void QueryForPost()
    {
        Console.WriteLine("输入当前需要查询的博客名称");
        string name = Console.ReadLine();
        PostBusinessLaryer pbl = new BusinessLayer.PostBusinessLaryer();
        var query = pbl.QueryForTitle(name);
        foreach(var item in query)
        {
            Console.WriteLine(item.Title + " " + item.Content);
        }
    }
   }
}