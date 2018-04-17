using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental2
{
    class Vehiculo
    {
        public string tipo, marca;
        public int precio;

        public void vehiculo(string tipo, string marca, int precio)
        {
            this.tipo = tipo;
            this.marca = marca;
            this.precio = precio;
        }
    }
}
