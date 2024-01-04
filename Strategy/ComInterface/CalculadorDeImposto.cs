using Strategy.Commom;
using Strategy.Interfaces;

namespace Strategy.ComInterface
{
    public class CalculadorDeImposto
    {
        public static void RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            double impostos = imposto.Calcula(orcamento);
            Console.WriteLine($"imposto a pagar: {impostos}R$");
        }
    }
}