using ProjetoAPI.Entities;

namespace ProjetoAPI.Context
{
    public class VendaContext
    {
        private Pedido pedido;
        private List<Pedido> pedidos = new List<Pedido>();

        public Pedido AdicionarVenda()
        {
            Pessoa vendedor1 = new Pessoa(1, "011.022.000-02", "Paulo", "paulo@email.com", "111111");
            Produto produto1 = new Produto(1, "Caderno", 2, 8.50M);
            Produto produto2 = new Produto(2, "Livro", 2, 150.25M);

            StatusVenda valor = StatusVenda.Aguardando;
            Enum status = (StatusVenda)valor;
            string statusVenda = status.ToString();

            if (statusVenda.Equals("Aguardando"))
            {
                statusVenda = "Aguardando Pagamento";
            }

            pedido = new Pedido(1, 10501, vendedor1, DateTime.Now, statusVenda);
            pedido.Produtos = new List<Produto>();
            pedido.Produtos.Add(produto1);
            pedido.Produtos.Add(produto2);

            pedidos.Add(pedido);

            return pedido;
        }

        public Pedido BuscarVendaPorId(int id)
        {
            Pessoa vendedor1 = new Pessoa(1, "011.022.000-02", "Paulo", "paulo@email.com", "111111");
            Produto produto1 = new Produto(1, "Caderno", 2, 8.50M);
            Produto produto2 = new Produto(2, "Livro", 2, 150.25M);

            StatusVenda valor = StatusVenda.Aguardando;
            Enum status = (StatusVenda)valor;
            string statusVenda = status.ToString();

            if (statusVenda.Equals("Aguardando"))
            {
                statusVenda = "Aguardando Pagamento";
            }

            pedido = new Pedido(1, 10501, vendedor1, DateTime.Now, statusVenda);
            pedido.Produtos = new List<Produto>();
            pedido.Produtos.Add(produto1);
            pedido.Produtos.Add(produto2);

            pedidos.Add(pedido);

            return pedido;
        }

        public Pedido AtualizarVendaPorId(int id)
        {
            Pessoa vendedor1 = new Pessoa(1, "011.022.000-02", "Paulo", "paulo@email.com", "111111");
            Produto produto1 = new Produto(1, "Caderno", 2, 8.50M);
            Produto produto2 = new Produto(2, "Livro", 2, 150.25M);

            StatusVenda valor = StatusVenda.Aguardando;
            Enum status = (StatusVenda)valor;
            string statusVenda = status.ToString();

            if (statusVenda.Equals("Aguardando"))
            {
                statusVenda = "Pagamento Aprovado";
            }

            pedido = new Pedido(1, 10501, vendedor1, DateTime.Now, statusVenda);
            pedido.Produtos = new List<Produto>();
            pedido.Produtos.Add(produto1);
            pedido.Produtos.Add(produto2);

            pedidos.Add(pedido);

            return pedido;
        }
    }
}
