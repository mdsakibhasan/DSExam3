using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductOne item1 = new ProductOne();
            Console.WriteLine(item1.Name);

            ProductTwo item2 = new ProductTwo();
            Console.WriteLine(item2.Name);
        }
    }
}
