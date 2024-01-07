using Strategy.Commom;

namespace Strategy.Interfaces
{
    public interface IDesconto
    {
        double CalcularDesconto(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}