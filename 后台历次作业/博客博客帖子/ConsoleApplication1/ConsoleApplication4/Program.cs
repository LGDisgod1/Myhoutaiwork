using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numList = {77,78,79,80,87,88,89,90};
            //var query = from x in numList
            //where (x % 2 == 0) && (x > 20) select x;
            string[] names = { "qaz", "qwead", "weqzxc" };

            //string str1 = "asdkwnlnadksa";
            //string str2 = "ok";
            //char[] s = { 'o', 'k' };
            //String s1 = new String(s);
            //静态成员调用 类名。方法名
            var query = names.Where(s => s.Contains("a"));
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
