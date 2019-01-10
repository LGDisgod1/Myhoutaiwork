using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.BusinessLayers;
using ConsoleApplication2.Model;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            createSchool();
            Console.WriteLine("随意退出");
            Console.ReadKey();
        }
        //    static void createBlog()
        //{
        //        Console.WriteLine("输入当前的一个学生用户");
        //        string name = Console.ReadLine();
        //        Student Students = new Student();
        //        Students.Name = name;
        //        StudentBussinessLayers log = new StudentBussinessLayers();
        //        log.Add(Students);
        //    }
        //}
        static void createSchool()
        {
            Console.WriteLine("输入一个班级名称");
            string name = Console.ReadLine();
            Classroom cla = new Classroom();
            cla.className = name;
            StudentBussinessLayers bbl = new StudentBussinessLayers();
            bbl.Add(cla);

        }
    }
}
