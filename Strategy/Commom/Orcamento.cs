namespace Strategy.Commom
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public List<Item> Itens{ get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
        }

        public Orcamento(double valor, List<Item> itens)
        {
            Valor = valor;
            Itens = itens;
        }
    }

    public class Item
    {
        public string Nome { get; set; }

        public Item(string nome)
        {
           Nome = nome;
        }
    }
}