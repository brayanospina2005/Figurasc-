namespace figuras
{
    internal class Cuadrado : Rectangulo
    {

        public Cuadrado(double lado, string nombre, string color, double x, double y) : base(color, nombre, lado, lado, x, y)
        {
            this.centro = new Punto(x, y);
        }

        public override double CalcularArea()
        {
            return base.CalcularArea();
        }

        public override double CalcularPerimetro()
        {
            return base.CalcularPerimetro();
        }

        public override void CambiarTamaño(double factorEscala)
        {
            base.CambiarTamaño(factorEscala);
        }

        public override string Imprimir()
        {
            return base.Imprimir();
        }
    }
}
