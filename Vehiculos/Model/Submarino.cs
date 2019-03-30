using System;
using LeonelCastaneda.Interfaz;
namespace LeonelCastaneda.Model
{
    public  class Submarino : Vehiculo, IBitacora
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

        public override void Encender(){

        }
        public override void Apagar(){

        }
        public void MostrarDetalle()
        {

        }
        public override string ToString()
        {
            return $" {{ marca : {this.Marca}, modelo : {this.Modelo}, velocidadMaxima: {this.VelociadadMaxima}, velocidadMinima : {this.VelociadadMinima}, profundidadMaxima: {this.ProfundidadMaxima}}}";
        }
    }

}