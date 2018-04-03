using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sucursal> sucursal = new List<Sucursal>();
            int opc1, opc2, opc3;
            int countSucursal = 0;

            while (true)
            {
                Console.WriteLine("Bienvenido \n");
                Console.WriteLine("1. Nueva Sucursal");
                Console.WriteLine("2. Escoger Sucursal");
                opc1 = Convert.ToInt16(Console.ReadLine());
                if (opc1 == 1)
                {
                    Sucursal a = new Sucursal();
                    a.CrearSucursal();
                    sucursal.Add(a);
                    countSucursal++;

                }
                else if (opc1 == 2)
                {
                    for (int i = 0; i < countSucursal; i++)
                    {
                        Console.WriteLine("");
                        Console.Write(i + 1 + ".");
                        sucursal[i].Nombre();
                    }
                    opc2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bienvenido a Sucursal : " + sucursal[opc2-1].GetNombre());
                    Console.WriteLine("1. Realizar Arriendo");
                    Console.WriteLine("2. Historial Arriendos");
                    opc3 = Convert.ToInt16(Console.ReadLine());
                    if (opc3 == 1)
                    {
                        Arriendo a = new Arriendo();
                        a.Arrendar();
                        sucursal[opc2 - 1].Arrendar();
                    }
                    else if (opc3 == 2)
                    {
                        foreach (Sucursal in Sucursal ())
                        {
                            Console.WriteLine(sucursal[opc2 - 1].arriendos());
                        }
                    }
                }

            }
            Console.ReadKey();
        }    
    }
}
