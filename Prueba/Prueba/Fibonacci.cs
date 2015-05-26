using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Fibonacci
    {
        public int calcular(int x)
        {
            if (x <= 1)
                return 1;
            return calcular(x - 1) + calcular(x - 2);

        }
    }
    }