namespace WebApplicationPessoa.Models
{
    public class PessoaModel
    {
        public int Id { get; set; }
        public string ?Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone {  get; set; }
        public PessoaModel(int id, string nome, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
