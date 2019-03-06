using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            Utile util = new Utile();
            Console.WriteLine(util.Add(x, y).ToString());
            Console.ReadLine();
        }
    }
}
