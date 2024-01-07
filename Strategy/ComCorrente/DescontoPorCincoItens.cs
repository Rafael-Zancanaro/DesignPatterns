using Strategy.Commom;
using Strategy.Interfaces;

namespace Strategy.ComCorrente
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double CalcularDesconto(Orcamento orcamento)
            => orcamento.Itens.Count > 5
                ? orcamento.Valor * Constantes.UmPorCento
                : Proximo.CalcularDesconto(orcamento);
    }
}