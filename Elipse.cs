using System;

namespace figuras
{
    internal class Elipse : Figura
    {
        private double radioMayor;
        private double radioMenor;
       
        public Elipse()
        {
        }

        // Constructor con los atributos del padre y las coordenadas del centro
        public Elipse(string nombre, string color, double radioMayor, double radioMenor, double x, double y) : base(color, nombre, x, y)
        {
            this.radioMayor = radioMayor;
            this.radioMenor = radioMenor;
            this.centro = new Punto(x, y);
        }


        // Método para calcular el área
        public override double CalcularArea()
        {
            return Math.PI * radioMayor * radioMenor;
        }

        // Método para calcular el perímetro
        public virtual double CalcularPerimetro()
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(radioMayor, 2) + Math.Pow(radioMenor, 2)) / 2);
        }

        // Método para imprimir los datos
        public override string Imprimir()
        {
            return base.Imprimir() + "\nradio menor: " + radioMenor + "\nradio mayor: " + radioMayor + "\nCentro: (" + centro.X + ", " + centro.Y + ")";
        }




        public Punto ObtenerCentro()
        {
            return centro;
        }
    }
}   