using Strategy.Commom;

namespace Strategy.Interfaces
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}