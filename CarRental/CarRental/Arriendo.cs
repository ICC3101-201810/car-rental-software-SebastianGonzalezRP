using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Arriendo
    {
        string Cliente;
        bool Documento;
        public string TipoVehiculo;
        string opc;

        public void Arrendar()
        {
            Console.WriteLine("Ingrese Tipo De Cliente : Persona/Empresa/Organizacion/Institucion ");
            Cliente = Console.ReadLine();
            Console.WriteLine("El Cliente cuenta con la documentacion pertinente : Y/N");
            opc = Console.ReadLine();
            if (opc == "Y" )
            {
                Documento = true;
            }
            else
            {
                Documento = false;
            }
            if (Documento == true)
            {
                Console.WriteLine("Tipo de Vehiculo a Arrendar : Auto/Camioneta/Acuatico/Bus/Retro/Moto :");
                TipoVehiculo = Console.ReadLine();

                Console.WriteLine("");
            }
        }
        public string GetVehiculo()
        {
            return TipoVehiculo;
        }
    }   
}
