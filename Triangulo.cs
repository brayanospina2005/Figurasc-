using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras
{
    internal class Triangulo : Figura
    {
        public Triangulo()
        {
            this.nombre = "Triangulo";
            this.color = "yellow";
            this.centro = new Punto(3, 7); // coordenadas x e y inicializadas en (0,0)
        }

        //constructor con los atributos del padre
        public Triangulo(string nombre, string color, double x, double y) : base(nombre, color, x, y)
        {
            this.nombre = nombre;
            this.color = color;

        }
    }
}
