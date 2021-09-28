using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lines = GetLines();
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static string[] GetLines()
        {
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Task3/"+"DemoText.txt");
            string[] files = File.ReadAllLines(startupPath);
            return files;
        }
    }
}
