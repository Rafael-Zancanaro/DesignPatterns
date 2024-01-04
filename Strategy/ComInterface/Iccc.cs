using Strategy.Commom;
using Strategy.Interfaces;

namespace Strategy.ComInterface
{
    public class Iccc : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor switch
            {
                < Constantes.ValorMinimo => orcamento.Valor * Constantes.Icms,
                > Constantes.ValorMaximo => orcamento.Valor * Constantes.IcccJurusAlto + Constantes.AcrescimoIccc,
                _ => orcamento.Valor * Constantes.IcccJurusMedio
            };
        }
    }
}