using System;
using Vehiculos.Model;

using static System.Console;


namespace Menu
{
    public class MenuPrincipal
    {
        private const float alturaMaxima = 10.5f;
        private const float alturaMinima = 5.8f;
        private const float profundidadMaxima = 1.8f;

        public void MostrarMenu()

        {


            WriteLine("1. Crear objeto avion ");
            WriteLine("2. Crear objeto submarino ");
            WriteLine("3. Mostrar informacion de los aviones ");
            WriteLine("4. Mostrar informacion de los submarinos ");
            WriteLine("5. Salir ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                
            }
            else if (opcion == 2)
            {

            }
            else if (opcion == 3)
            {

            }
            else if (opcion == 4)
            {

            }
            else if (opcion != 5)
            {

            }
        }
        public void MostrarDetalles()
        {
            
            string marca = "";
            float alturaMaxima = 0f;
            float alturaMinima = 0f;
            WriteLine("Ingrse el modelo del avion: ");
            int modelo = int.Parse(ReadLine());
            WriteLine("Ingrese la marca del avion: ");

            

        }

    }
}

