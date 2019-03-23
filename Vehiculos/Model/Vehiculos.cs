using System;
namespace Vehiculos.Model

{

    public abstract class Vehiculos
    {
        public Vehiculos() { }

        public Vehiculos(float velocidadMaxima, float velocidadMinima, string marca, string modelo)
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

        public void Encender() { }

        public void Apagar() { }
    }
}