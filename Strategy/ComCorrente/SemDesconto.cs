﻿using Strategy.Commom;
using Strategy.Interfaces;

namespace Strategy.ComCorrente
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double CalcularDesconto(Orcamento orcamento)
            => Constantes.ZeroPorCento;
    }
}