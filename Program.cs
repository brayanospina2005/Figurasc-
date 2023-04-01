using figuras;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        Figura figura = new Figura();
        figura.Imprimir();
        //Circulo
        Circulo circulo = new Circulo();
        Console.WriteLine(circulo.Imprimir());
        Console.WriteLine("El area de ciruculo es" + circulo.CalcularArea());
        Console.WriteLine("El area de ciruculo es" + circulo.CalcularPerimetro());
        Console.WriteLine("*****************");

        //Triangulo
        Triangulo triangulo = new Triangulo();
        Console.WriteLine(triangulo.Imprimir());
        Console.WriteLine("Color original: " + circulo.GetColor());  // imprime el color original "Red"
        circulo.SetColor("blue");  // cambia el valor del atributo "color" a "blue"
        Console.WriteLine("Nuevo color: " + circulo.GetColor());  // imprime el nuevo valor de color "blue"
        Console.WriteLine("*****************");

        //rectangulo
        Rectangulo rectangulo = new Rectangulo("gold", "Rectángulo", 2, 4, 6, 2);
        Console.WriteLine(rectangulo.Imprimir());
        Console.WriteLine("Área: " + rectangulo.CalcularArea());
        Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());
        rectangulo.CambiarTamaño(2);
        rectangulo.Imprimir();
        Console.WriteLine("Área después de cambiar el tamaño: " + rectangulo.CalcularArea());
        Console.WriteLine("Perímetro después de cambiar el tamaño: " + rectangulo.CalcularPerimetro());
        Console.WriteLine("*****************");

        //elipse

        Elipse miElipse = new Elipse("Elipse", "Grey", 5, 3, 6, 5);
        Console.WriteLine(miElipse.Imprimir());
        double area = miElipse.CalcularArea();
        double perimetro = miElipse.CalcularPerimetro();
        Console.WriteLine("Área: " + area);
        Console.WriteLine("Perímetro: " + perimetro);
        Console.WriteLine("*****************");

        // cuadrado
        Cuadrado MiCuadrad = new Cuadrado(4, "Cuadrado", "Orange", 8, 1);
        Console.WriteLine(MiCuadrad.Imprimir());
        Console.WriteLine("Área: " + MiCuadrad.CalcularArea());
        Console.WriteLine("Perímetro: " + MiCuadrad.CalcularPerimetro());
        MiCuadrad.CambiarTamaño(2);
        MiCuadrad.Imprimir();
        Console.WriteLine("Área después de cambiar el tamaño: " + MiCuadrad.CalcularArea());
        Console.WriteLine("Perímetro después de cambiar el tamaño: " + MiCuadrad.CalcularPerimetro());
        Console.WriteLine("*****************");
        //array de objectos para cambiarlo 
        Figura[] figuras = new Figura[4];
        figuras[0] = new Circulo();
        figuras[1] = new Rectangulo("gold", "Rectángulo", 2, 4, 6, 2);
        figuras[2] = new Elipse("Elipse", "Grey", 5, 3, 6, 5);
        figuras[3] = new Cuadrado(4, "Cuadrado", "Orange", 8, 1);
        

        for (int i = 0; i < figuras.Length; i++)
        {
            figuras[i].SetColor("blue"); // Cambia el color a "blue"
            figuras[i].CambiarPosicion(10, 10); // Cambia la posición a (10, 10)
            Console.WriteLine(figuras[i].Imprimir());
            Console.WriteLine("el area de la "+ figuras[i].nombre+  " " + figuras[i].CalcularArea());
            Console.WriteLine("*********");
        }

        //area maxima
        // Inicializar variables
        double max_area = 0;
        Figura forma_max = null;

        // Iterar a través de cada forma en el conjunto de formas
        foreach (Figura forma in figuras)
        {
            // Calcular el área de la forma actual
            double area_actual = forma.CalcularArea();

            // Comprobar si el área de la forma actual es mayor que el área máxima
            if (area_actual > max_area)
            {
                // Si es así, actualizar max_area y forma_max con la información de la forma actual
                max_area = area_actual;
                forma_max = forma;
            }
        }

        // Imprimir la información de la forma con el área máxima
        if (forma_max != null)
        {
            Console.WriteLine("La forma con el área máxima es:");
            Console.WriteLine(forma_max.Imprimir());
            Console.WriteLine("Área: " + max_area);
        }
        else
        {
            Console.WriteLine("No se encontró ninguna forma en el conjunto dado.");
        }


        //¿Cómo haría para obligar que todas las clases futuras derivadas tengan al menos los
        //métodos “área” y “perímetro”? ¿Tiene sentido incluir definir dichos métodos en la clase
        //“forma”?

        //Respuesta: por lo visto en java, existen interfaces la cual consiste en que varias clases
        // comparten un metodo, por ejemplo si tenemos clases llamadas perro, gato un metodo que comparten
        //puede ser comer, ya si hay metodos unicos se deberian hacer en su respectiva clase
        // y si, si es muy util








    }
}