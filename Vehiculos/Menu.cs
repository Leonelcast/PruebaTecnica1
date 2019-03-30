using System;
using System.Collections.Generic;
using LeonelCastaneda.Model;

using static System.Console;


namespace Menu
{
    public class MenuPrincipal
    {
        private List<Vehiculo> lista = new List<Vehiculo>();
        public void MostrarMenu()
        {
            int opcion = 5;
            do
            {
                WriteLine("1. Crear objeto avion ");
                WriteLine("2. Crear objeto submarino ");
                WriteLine("3. Mostrar informacion de los aviones ");
                WriteLine("4. Mostrar informacion de los submarinos ");
                WriteLine("5. Salir ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Vehiculo nuevo = new Avion();
                    WriteLine("Ingrese la marca");
                    nuevo.Marca = ReadLine();
                    WriteLine("Ingrese el modelo");
                    nuevo.Modelo = ReadLine();
                    WriteLine("Ingrese velociad Maxima");
                    nuevo.VelociadadMaxima = Convert.ToSingle(ReadLine());
                    WriteLine("Ingrese velocidad Minima");
                    nuevo.VelociadadMinima = float.Parse(ReadLine());
                    WriteLine("Ingrese la Altura maxima");
                    ((Avion)nuevo).AlturaMaxima = float.Parse(ReadLine());
                    lista.Add(nuevo);
                    WriteLine("Registro almacenado!!!");
                    ReadKey();
                }
                else if (opcion == 2)
                {
                    Vehiculo nuevo = new Submarino();
                    WriteLine("Ingrese la marca");
                    nuevo.Marca = ReadLine();
                    WriteLine("Ingrese el modelo");
                    nuevo.Modelo = ReadLine();
                    WriteLine("Ingrese velociad Maxima");
                    nuevo.VelociadadMaxima = Convert.ToSingle(ReadLine());
                    WriteLine("Ingrese velocidad Minima");
                    nuevo.VelociadadMinima = float.Parse(ReadLine());
                    lista.Add(nuevo);
                    WriteLine("Registro almacenado!!!");
                    ReadKey();
                }
                else if (opcion == 3)
                {
                    WriteLine("Mostrando información de aviones");
                    foreach (Vehiculo elemento in lista)
                    {
                        if (elemento.GetType() == typeof(Avion))
                        {
                            ((Avion)elemento).MostrarDetalle();
                        }
                    }
                }
                else if (opcion == 4)
                {
                    WriteLine("Mostrando información de submarinos");
                    foreach (Vehiculo elemento in lista)
                    {
                        if (elemento.GetType() == typeof(Submarino))
                        {
                            ((Submarino)elemento).MostrarDetalle();
                        }
                    }
                }
                else if (opcion == 5)
                {
                    WriteLine("Muchas gracias por utilizar el sistema, hasta la proxima!!!");
                }
            } while (opcion != 5);
        }
    }
}

