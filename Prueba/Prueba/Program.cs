using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Changes");
            Console.ReadKey();
            Fibonacci obj = new Fibonacci();
            Console.WriteLine(obj.calcular(5));
        }
    }
}
