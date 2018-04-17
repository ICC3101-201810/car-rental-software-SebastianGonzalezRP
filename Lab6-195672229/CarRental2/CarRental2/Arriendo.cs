using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental2
{
    class Arriendo
    {
        public void devolucion(string tipo, string nombreSucursal, string rutc, List<Sucursal> sucursales)
        {
            for (int i = 0; i < 1; i++)
            {
                if (sucursales[i].nombre == "Sucursal Principal")
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (tipo == sucursales[i].tipos[j])
                        {
                            if (j == 0)
                            {
                                sucursales[i].nAuto += 1;
                            }
                            if (j == 1)
                            {
                                sucursales[i].nRetro += 1;
                            }
                            if (j == 2)
                            {
                                sucursales[i].nMotos += 1;
                            }
                            if (j == 3)
                            {
                                sucursales[i].nAcuaticos += 1;
                            }
                            if (j == 4)
                            {
                                sucursales[i].nBuses += 1;
                            }
                            if (j == 5)
                            {
                                sucursales[i].nCamioneta += 1;
                            }
                        }
                    }
                }
            }
        }
        public void arriendo(string tipo, string nombreSucursal, string rutc, List<Sucursal> sucursales)
        {
            for (int i = 0; i < 1; i++)
            {
                if (sucursales[i].nombre == "Sucursal Principal")
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (tipo == sucursales[i].tipos[j])
                        {
                            if (j == 0)
                            {
                                if (sucursales[i].nAuto > 0)
                                {
                                    sucursales[i].nAuto -= 1;
                                }
                            }
                            if (j == 1)
                            {
                                if (sucursales[i].nRetro > 0)
                                {
                                    sucursales[i].nRetro -= 1;
                                }
                            }
                            if (j == 2)
                            {
                                if (sucursales[i].nMotos > 0)
                                {
                                    sucursales[i].nMotos -= 1;
                                }
                            }
                            if (j == 3)
                            {
                                if(sucursales[i].nAcuaticos > 0)
                                {
                                    sucursales[i].nAcuaticos -= 1;
                                }
                            }
                            if (j == 4)
                            {
                                if (sucursales[i].nBuses > 0)
                                {
                                    sucursales[i].nBuses -= 1;
                                }
                            }
                            if (j == 5)
                            {
                                if (sucursales[i].nCamioneta > 0)
                                {
                                    sucursales[i].nCamioneta -= 1;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
