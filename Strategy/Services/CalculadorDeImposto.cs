using Strategy.Domain.InputModels;
using Strategy.Domain.Interfaces;

namespace Strategy.Services
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