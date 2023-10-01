using cajero_transaccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Program
    {
        static void Main(string[] args, Console console)
        {
            cajero caj1 = new cajero();
            caj1.carga(Console);
            Console.ReadKey();
        }
    }
}

