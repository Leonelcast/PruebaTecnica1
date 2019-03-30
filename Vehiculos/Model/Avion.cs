using System;
using LeonelCastaneda.Interfaz;
namespace LeonelCastaneda.Model
{
    public class Avion: Vehiculo, IBitacora 
    {
        public Avion():base(){}
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
        public override void Encender(){

        }

        public override void Apagar()
        {

        }

        public override string ToString()
        {
            return $" {{ marca : {this.Marca}, modelo : {this.Modelo}, velocidadMaxima: {this.VelociadadMaxima}, velocidadMinima : {this.VelociadadMinima}, alturaMaxima: {this.AlturaMaxima}, alturaMinima : {this.AlturaMinima} }}";
        }
        public  void MostrarDetalle(){
           Console.WriteLine(this.ToString());
        }
    }

}