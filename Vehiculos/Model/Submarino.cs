using System;
namespace Vehiculos.Model
{
    public abstract class Submarino : Vehiculos
    {
        public Submarino() { }
        public Submarino(float velocidadMaxima, float velocidadMinima, string marca, string modelo, float profundidadMaxima, float profundidadMinima) :
         base(velocidadMaxima, velocidadMinima, marca, modelo)
        {
            ProfundidadMaxima = profundidadMaxima;
            ProfundidadMinima = profundidadMinima;

        }
        private float profundidadMaxima;
        public float ProfundidadMaxima
        {
            get { return profundidadMaxima; }
            set { profundidadMaxima = value; }
        }
        private float profundidadMinima;
        public float ProfundidadMinima
        {
            get { return profundidadMinima; }
            set { profundidadMinima = value; }
        }
        public void Sumergir(float metros)
        {
            
        }

    }

}