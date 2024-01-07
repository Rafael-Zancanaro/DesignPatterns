using Strategy.Commom;
using Strategy.Interfaces;

namespace Strategy.ComCorrente
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double CalcularDesconto(Orcamento orcamento)
        {
            var aconteceuVendaCasada = Existe(Constantes.Lapis, orcamento) && Existe(Constantes.Caneta, orcamento);
            return aconteceuVendaCasada
                ? orcamento.Valor * Constantes.CincoPorCento
                : Proximo.CalcularDesconto(orcamento);
        }

        private static bool Existe(string nomeItem, Orcamento orcamento)
            => orcamento.Itens.Any(x => x.Nome.Equals(nomeItem, StringComparison.InvariantCultureIgnoreCase));
    }
}