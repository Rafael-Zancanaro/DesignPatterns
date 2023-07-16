using Strategy.Domain.Commom;
using Strategy.Domain.InputModels;
using Strategy.Domain.Interfaces;

namespace Strategy.Services
{
    public class Iccc : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor switch
            {
                < Constantes.ValorMinimo => orcamento.Valor * Constantes.IcccJurusBaixo,
                > Constantes.ValorMaximo => orcamento.Valor * Constantes.IcccJurusAlto + Constantes.AcrescimoIccc,
                _ => orcamento.Valor * Constantes.IcccJurusMedio
            };
        }
    }
}