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
        string TipoVehiculo;
        string opc;

        public void Arrendar()
        {
            Console.Write("Ingrese Tipo De Cliente : Persona/Empresa/Organizacion/Institucion ");
            Cliente = Console.ReadLine();
            Console.Write("El Cliente cuenta con la documentacion pertinente : Y/N");
            opc = Console.ReadLine();
            if (opc == "Y" )
            {
                Documento = true;
            }
            else
            {
                Documento = false;
            }
            Console.Write("Tipo de Vehiculo a Arrendar : Auto/Camioneta/Acuatico/Bus/Retro/Moto");
            TipoVehiculo = Console.ReadLine();
            Console.WriteLine("");
        }
    }   
}
