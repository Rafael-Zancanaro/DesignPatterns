using Strategy.Domain.Commom;
using Strategy.Domain.InputModels;
using Strategy.Domain.Interfaces;

namespace Strategy.Services
{
    public class Iss : IImposto
    {
        public double Calcula(Orcamento orcamento)
            => orcamento.Valor * Constantes.Iss;
    }
}