using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IVehiculo
    {
        string Conducir();
    }

    public class Coche : IVehiculo
    {
        public string Conducir()
        {
            return "Piloto conduciendo un BMW";
        }
    }

    public class Moto : IVehiculo
    {
        public string Conducir()
        {
            return "Piloto conduciendo una Ducati";
        }
    }
}