class Triangulo
{
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }

    public Triangulo (double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0)
        {
            throw new ArgumentException("Os lados do triângulo devem ser positivos.");
        }
        A = a;
        B = b;
        C = c;
    }

    public void TipoTriangulo()
    {
        if (A + B > C || A + C > B || B + C > A) {
            if (A == B && B == C)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else if (A != B && A != C && B != C)
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Os lados fornecidos não formam um triângulo.");
        }
    }
}