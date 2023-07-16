using Strategy.Domain.InputModels;
using Strategy.Domain.Interfaces;
using Strategy.Services;

namespace Strategy
{
    public class Program
    {
        static void Main()
        {
            IImposto iss = new Iss();
            IImposto icms = new Icms();
            IImposto iccc = new Iccc();

            Orcamento orcamento = new(50);

            CalculadorDeImposto.RealizarCalculo(orcamento, iss);
            CalculadorDeImposto.RealizarCalculo(orcamento, icms);
            CalculadorDeImposto.RealizarCalculo(orcamento, iccc);

            Console.ReadLine();
        }
    }
}