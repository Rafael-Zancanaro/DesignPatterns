namespace Strategy.Commom
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public int Itens { get; set; }

        public Orcamento(double valor, int itens)
        {
            Itens = itens;
        }
    }
}