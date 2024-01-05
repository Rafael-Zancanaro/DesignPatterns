using Strategy.ComInterface;
using Strategy.Commom;
using Strategy.Interfaces;
using static Strategy.ComCorrente.BaseDesconto;

namespace Strategy
{
    public class Program
    {
        static void Main()
        {
            #region Com interfaces

            IImposto iss = new Iss();
            IImposto icms = new Icms();
            IImposto iccc = new Iccc();

            Orcamento orcamento = new(50);

            CalculadorDeImposto.RealizarCalculo(orcamento, iss);
            CalculadorDeImposto.RealizarCalculo(orcamento, icms);
            CalculadorDeImposto.RealizarCalculo(orcamento, iccc);

            #endregion

            #region Com corrente

            var lista = new List<Item>() 
            { 
                new("Lápis"), 
                new("Caneta"), 
                new("Borracha") 
            };

            Orcamento orcamento1 = new(500.0, lista);

            var baseDesconto = MontarCorrente();
            double desconto = baseDesconto.Desconta(orcamento1);

            Console.WriteLine("Seu desconto pela compra foi de: " + desconto + " R$");

            #endregion

            Console.ReadLine();
        }
    }
}