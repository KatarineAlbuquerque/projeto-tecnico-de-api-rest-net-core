namespace ProjetoAPI.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public Pessoa Vendedor { get; set; }
        public DateTime Data { get; set; }
        public List<Produto> Produtos { get; set; }
        public string Status { get; set; }

        public Pedido()
        {

        }

        public Pedido(int id)
        {
            Id = id;
        }

        public Pedido(int id, int idPedido, Pessoa vendedor, DateTime data, string status)
        {
            Id = id;
            IdPedido = idPedido;
            Vendedor = vendedor;
            Data = data;
            Status = status;
        }
    }
}
