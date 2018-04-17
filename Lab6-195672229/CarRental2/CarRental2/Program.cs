using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arriendo a = new Arriendo();
            List<Sucursal> succ = new List<Sucursal>
            {
                new Sucursal { nombre = "Sucursal Principal", direccion= "Avenida Principal 1205",tipos = new List<string> {"Auto","Retro","Motos","Acuaticos","Buses","Camionetas" }, nAuto=22, nRetro=3,nMotos=30,nAcuaticos=8,nBuses=6,nCamioneta=20},
                new Sucursal { nombre = "Sucursal Secundaria", direccion= "Avenida  No Principal 111",tipos = new List<string> {"Auto","Retro","Motos","Acuaticos","Buses","Camionetas" }, nAuto=12, nRetro=8,nMotos=150,nAcuaticos=18,nBuses=2,nCamioneta=20}
            };
            int duracion;
            string tipo,rut,opc1;
            bool exito;
            while (true)
            {
                opc1 = "";
                duracion = 0;
                rut = "";
                tipo = "";
                exito = false;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Bienvenido a Sucursal Principal");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1. Arrendar Vehiculo");
                Console.WriteLine("2. Devolver Vehiculo");
                Console.WriteLine("3. Salir \n ---->");
                opc1=(Console.ReadLine());
                Console.Beep();
                if (opc1 != "1" && opc1 != "2" && opc1 != "3")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Porfavor Ingrese una Opcion Valida \n");
                }
                if (opc1 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ingrese Tipo de Vehiculo a arrendar : Auto/Retro/Motos/Acuaticos/Buses/Camionetas");
                    tipo=Console.ReadLine();
                    Console.WriteLine("Ingrese Duracion del Arriendo");
                    duracion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese RUT del Arrendatario : ");
                    rut = Console.ReadLine();
                    a.arriendo(tipo, "Sucursal Principal", rut, succ);
                    Console.WriteLine("Arriendo Exitoso");
                    Console.WriteLine("Vehiculo " + tipo + "Arrendado");
                    Console.WriteLine("Monto  a Pagar = $" + duracion * 25000);
                }
                if (opc1 == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ingrese Tipo de Vehiculo a Devolver : Auto/Retro/Motos/Acuaticos/Buses/Camionetas");
                    tipo = Console.ReadLine();
                    Console.WriteLine("Ingrese RUT del Arrendatario : ");
                    rut = Console.ReadLine();
                    a.arriendo(tipo, "Sucursal Principal", rut, succ);
                }
                if (opc1 == "3")
                {
                    break;
                }
            }
        }
    }
}
