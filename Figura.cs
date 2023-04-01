using System;

namespace figuras
{
    internal class Figura
    {
        // atributos principales
        protected string color;
        public string nombre;
        protected Punto centro;

        // constructor por defecto
        public Figura()
        {
        }

        // constructor con atributos
        public Figura(string color, string nombre, double x, double y)
        {
            this.color = color;
            this.nombre = nombre;
            this.centro = new Punto(x, y);
            // Comprobar si centro es nulo antes de acceder a sus propiedades
            if (centro != null)
            {
                // Acceder a las propiedades X e Y de centro
                Console.WriteLine("Coordenadas del centro: (" + centro.X + "," + centro.Y + ")");
            }
        }

        // método para imprimir
      
        public virtual string Imprimir()
        {
            string centroStr = centro != null ? "(" + centro.X + "," + centro.Y + ")" : "null";
            return "Nombre: " + this.nombre + ", Color: " + this.color + ", Centro: " + centroStr;
        }


        // metodo para obtener color
        public string GetColor()
        {
            return this.color;
        }

        // metodo para cambiar color
        public void SetColor(string color)
        {
            this.color = color;
        }
        //cambiar posicion
        public void CambiarPosicion(double x, double y)
        {
            this.centro = new Punto(x, y);
        }


        // clase interna Punto
        internal class Punto
        {
            // atributos de la clase Punto
            private double x = 0;
            private double y = 0;

            // constructor por defecto
            public Punto()
            {
            }

            // constructor con parametros
            public Punto(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            // getters y setters para los atributos x e y
            public double X
            {
                get { return x; }
                set { x = value; }
            }

            public double Y
            {
                get { return y; }
                set { y = value; }
            }
        }

        // metodo abstracto para calcular el area de la figura
        public virtual double CalcularArea()
        {
            return 0;
        }
    }
}
