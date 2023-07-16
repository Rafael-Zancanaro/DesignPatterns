using Strategy.Domain.InputModels;

namespace Strategy.Domain.Interfaces
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}