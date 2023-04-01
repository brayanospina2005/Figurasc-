using figuras;

internal class Rectangulo : Figura
{
    private double ladoMenor;
    private double ladoMayor;
    // Constructor por defecto
    public Rectangulo()
    {
        this.ladoMenor = 0;
        this.ladoMayor = 0;
        this.color = "white";
        this.nombre = "Rectangulo";
        this.centro = new Punto(); // coordenadas x e y inicializadas
    }

    // Constructor con parámetros
    public Rectangulo(string color, string nombre, double ladoMenor, double ladoMayor, double x, double y) : base(color, nombre, x, y)
    {
        this.ladoMenor = ladoMenor;
        this.ladoMayor = ladoMayor;
        this.centro = new Punto(x, y);
    }

    // Imprimir
    public override string Imprimir()
    {
        return base.Imprimir() + "\nLado menor: " + ladoMenor + "\nlado mayor: " + ladoMayor;
    }

    // Calcular área
    public override double CalcularArea()
    {
        return this.ladoMenor * this.ladoMayor;
    }

    // Calcular perímetro
    public virtual double CalcularPerimetro()
    {
        return 2 * this.ladoMenor + 2 * this.ladoMayor;
    }

    // Cambiar tamaño 
    public virtual void CambiarTamaño(double factorEscala)
    {
        this.ladoMenor *= factorEscala;
        this.ladoMayor *= factorEscala;
    }
}