using System;

namespace figuras
{
    internal class Circulo : Elipse
    {
        // Atributos del circulo
        private double radio;
        // Constructor por defecto
        public Circulo()
        {
            this.nombre = "Circulo";
            this.color = "Red";
            this.radio = 1.0;
            this.centro = new Punto(5, 8);
        }

        // Constructor con atributos
        public Circulo(string nombre, string color, double x, double y, double radio) : base(nombre, color, radio, radio, x, y)
        {
            this.radio = radio;
        }

        // Sobrescribir el método CalcularArea
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // Sobrescribir el método CalcularPerimetro
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }

        // Método para imprimir los datos
        public override string Imprimir()
        {
            return base.Imprimir() + ", Radio: " + this.radio;
        }
    }
}