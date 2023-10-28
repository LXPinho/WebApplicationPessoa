namespace WebApplicationPessoa.Models
{
    public interface IPessoaModel
    {
        int Id { get; set; }
        string? Nome { get; set; }
        string? Email { get; set; }
        string? Telefone { get; set; }
    }
}
