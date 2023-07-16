using Strategy.Domain.Commom;
using Strategy.Domain.InputModels;
using Strategy.Domain.Interfaces;

namespace Strategy.Services
{
    public class Icms : IImposto
    {
        public double Calcula(Orcamento orcamento)
            => orcamento.Valor * Constantes.Icms;
    }
}
