using Strategy.Commom;
using Strategy.Interfaces;

namespace Strategy.ComInterface
{
    public class Icms : IImposto
    {
        public double Calcula(Orcamento orcamento)
            => orcamento.Valor * Constantes.Icms;
    }
}
