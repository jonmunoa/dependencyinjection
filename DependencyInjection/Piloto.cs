using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Piloto
    {
        protected IVehiculo vehiculo;

        public Piloto(IVehiculo _IVehiculo)
        {
            vehiculo = _IVehiculo;
        }

        public string Conducir()
        {
            return vehiculo.Conducir();
        }
    }
}