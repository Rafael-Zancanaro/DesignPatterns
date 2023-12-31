﻿using Strategy.Interfaces;

namespace Strategy.ComCorrente
{
    public class CalculadorDeDescontos
    {
        public static IDesconto MontarCadeiaDesconto()
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1;
        }
    }
}