namespace TestarFormulaBaskara
{
    public class xUnitText
    {
        [Fact]
        public void Baskara()
        {
            // 2 raizes REAIS
            Assert.Equal([2, -7], CalcularBaskara.CalcularBaskaraClasse.Baskara(1, 5, -14));

            // Raiz não REAL
            Assert.Equal([0, 0], CalcularBaskara.CalcularBaskaraClasse.Baskara(0, -1, 1));
        }
    }
}