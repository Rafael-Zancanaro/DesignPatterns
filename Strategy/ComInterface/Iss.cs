using Strategy.Commom;
using Strategy.Interfaces;

namespace Strategy.ComInterface
{
    public class Iss : IImposto
    {
        public double Calcula(Orcamento orcamento)
            => orcamento.Valor * Constantes.SeisPorCento;
    }
}