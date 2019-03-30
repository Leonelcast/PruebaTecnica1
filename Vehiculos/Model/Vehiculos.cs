using System;
namespace LeonelCastaneda.Model

{

    public abstract class Vehiculo
    {
        public Vehiculo() { }

        public Vehiculo(float velocidadMaxima, float velocidadMinima, string marca, string modelo)
        {
            VelociadadMaxima = velociadadMaxima;
            VelociadadMinima = velociadadMinima;
            Marca = marca;
            Modelo = modelo;

        }
        private float velociadadMaxima;
        private float velociadadMinima;
        private string marca;
        private string modelo;
        public float VelociadadMaxima
        {
            get { return velociadadMaxima; }
            set { velociadadMaxima = value; }
        }

        public float VelociadadMinima
        {
            get { return velociadadMinima; }
            set { velociadadMinima = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public abstract void Encender();

        public abstract void Apagar();
    }
}