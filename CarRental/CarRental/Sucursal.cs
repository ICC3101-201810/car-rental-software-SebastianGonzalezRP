using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Sucursal
    {
        public string NombreS;
        public string Direccion;
        public int nAutos, nCamionetas, nAcuaticos, nBuses, nRetro, nMotos;
        public List<Arriendo> arriendo = new List<Arriendo>();

        public void CrearSucursal()
        {
            Console.Write("Ingrese Nombre De la Sucursal : ");
            NombreS = Console.ReadLine();
            Console.Write("Ingrese Direccion Sucursal " + NombreS + " :");
            Direccion = Console.ReadLine();
            Console.Write("Ingrese Cantidad de Autos de la Sucursal : ");
            nAutos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Cantidad de Camionetas de la Sucursal : ");
            nCamionetas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Cantidad de Vehiculos Acuaticos de la Sucursal : ");
            nAcuaticos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Cantidad de Buses de la Sucursal : ");
            nBuses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Cantidad de Retro-Excavadoras de la Sucursal : ");
            nRetro = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Cantidad de Motos de la Sucursal : ");
            nMotos = Convert.ToInt32(Console.ReadLine());
            List<Arriendo> arriendo = new List<Arriendo>();
        }

        public string GetNombre()
        {
            return NombreS;
        }

        public void Nombre()
        {
            Console.WriteLine(NombreS);
        }

    }
}
