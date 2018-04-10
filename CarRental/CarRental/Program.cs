using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Program:Sucursal
    {
        static void Main(string[] args)
        {
            List<Sucursal> sucursal = new List<Sucursal>();
            int opc1, opc2=0, opc3;
            int countSucursal = 0;

            while (true)
            {
                Console.WriteLine("Bienvenido \n");
                Console.WriteLine("1. Nueva Sucursal");
                Console.WriteLine("2. Escoger Sucursal");
                opc1 = Convert.ToInt16(Console.ReadLine());
                if (opc1 == 1) //SE CREA SUCURSAL
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
                    opc2 = Convert.ToInt32(Console.ReadLine()); //SE TRABAJA SUCURSAL
                    opc1 = 3;
                }
                while (opc1==3)
                {
                    int conteoarriendo = 0;
                    Console.WriteLine("Bienvenido a Sucursal : " + sucursal[opc2 - 1].GetNombre());
                    Console.WriteLine("1. Realizar Arriendo");
                    Console.WriteLine("2. Historial Arriendos");
                    Console.WriteLine("3. Atras");
                    opc3 = Convert.ToInt16(Console.ReadLine());
                    if (opc3 == 1)
                    {
                        string tipoV;
                        Arriendo a = new Arriendo();
                        a.Arrendar();
                        sucursal[opc2 - 1].arriendo.Add(a);
                        
                        tipoV = a.GetVehiculo();
                        if (tipoV == "Auto")
                        {
                            sucursal[opc2 - 1].nAutos--;
                        }
                        if (tipoV == "Camionetas")
                        {
                            sucursal[opc2 - 1].nCamionetas--;
                        }
                        if (tipoV == "Acuatico")
                        {
                            sucursal[opc2 - 1].nAcuaticos--;
                        }
                        if (tipoV == "Bus")
                        {
                            sucursal[opc2 - 1].nBuses--;
                        }
                        if (tipoV == "Retro")
                        {
                            sucursal[opc2 - 1].nRetro--;
                        }
                        if (tipoV == "Moto")
                        {
                            sucursal[opc2 - 1].nMotos--;
                        }

                    }
                    else if (opc3 == 2)
                    {
                        for (int k = 0; k<conteoarriendo;k++)
                        {
                            Console.WriteLine("");
                            Console.Write(k + 1 + ".");
                            Console.Write(sucursal[opc2 - 1].arriendo[k]);
                        }
                    }
                    else if (opc3 == 3)
                    {
                        break;
                    }
                }
            }
            Console.ReadKey();
        }    
    }
}
