using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saldo
    {
    class Program
        {
        static void Main(string[] args)
            {

            int saldo = 500;
            int valor = 30;

            Console.WriteLine($"Saldo Atual: {--saldo}");
            Console.WriteLine(String.Format("Saldo Atual {0}", --saldo));

            DateTime dt1, dt2;

            dt1 = new DateTime();
            dt2 = new DateTime();

            DateTime.Compare(dt1, dt2);

            }
        }
    }

