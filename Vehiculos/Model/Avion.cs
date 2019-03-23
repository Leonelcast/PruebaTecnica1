using System;
namespace Vehiculos.Model
{
    public abstract class Avion: Vehiculos
    {
        public Avion(){}
        public Avion(float veloccidadMaxima, float velocidadMinima, string marca, string modelo, float alturaMaxima, float alturaMinima): 
        base(veloccidadMaxima, velocidadMinima, marca, modelo) 
        {
            AlturaMaxima = alturaMaxima;
            AlturaMinima = alturaMinima;
        }
        private float alturaMaxima;
        private float alturaMinima;
        public float AlturaMaxima
        {
            get{return alturaMaxima;}
            set{alturaMaxima = value;}
        }
        
        public float AlturaMinima
        {
            get{return alturaMinima;}
            set{alturaMinima = value;}
        }
        public void Despegar()
        {

        }
        public void Aterrizar()
        {

        }
        public void DisminuirAltura(float pies)
        {
            
        }


    }

}