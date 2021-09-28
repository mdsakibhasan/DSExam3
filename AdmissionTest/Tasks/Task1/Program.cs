using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name = GetName();
            Console.WriteLine(name);
        }

        public static object GetName()
        {
            return GetObject();
        }

        public static object GetObject()
        {
            return new { Name = "Camera"};
        }
    }
}
