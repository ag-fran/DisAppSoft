using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Fibonacci
    {
        public int calcular(int a)
        {
            int res;
            while (a < 2)
            {
                a = res;
                Console.WriteLine("Resultado", res);
                
            }
              while (a > 2)
            {
                res= (a-1)+(a-2);
                Console.WriteLine(res);
            }
              return  res;

        }
    }
    }