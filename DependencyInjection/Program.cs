using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var piloto = new Piloto(new Coche());
            Console.WriteLine(piloto.Conducir());

            piloto = new Piloto(new Moto());
            Console.WriteLine(piloto.Conducir());

            Console.Read();
        }
    }
}