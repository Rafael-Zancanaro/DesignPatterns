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
                < Constantes.ValorUmMil => orcamento.Valor * Constantes.CincoPorCento,
                > Constantes.ValorTresMil => orcamento.Valor * Constantes.OitoPorCento + Constantes.AcrescimoIccc,
                _ => orcamento.Valor * Constantes.SetePorCento
            };
        }
    }
}