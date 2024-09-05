namespace CalcularBaskara
{
    public class CalcularBaskaraClasse
    {
        //INICIO - CONTA BASKARA
        public static double[] Baskara(double a, double b, double c)
        {
            double delta = (b * b) + (-4 * a * c);

            double raiz1 = a <= 0 ? 0 : (-b + Math.Sqrt(delta)) / (2 * a);
            double raiz2 = a <= 0 ? 0 : (-b - Math.Sqrt(delta)) / (2 * a);

            return new double[] { raiz1, raiz2 };
        }
        //FIM - CONTA BASKARA
    }
}
