namespace Strategy.Domain.InputModels
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
        }
    }
}