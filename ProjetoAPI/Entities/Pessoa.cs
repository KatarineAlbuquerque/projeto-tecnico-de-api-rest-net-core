namespace ProjetoAPI.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int id, string cpf, string nome, string email, string telefone)
        {
            Id = id;
            Cpf = cpf;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
