using WebApplicationPessoa.Models;

namespace WebApplicationPessoa.Repository
{
    public interface IListaRepository
    {
        List<PessoaModel> GetListaPessoaModel(int? id);
        string AdicionarPessoa(int? id, string? nome, string? email, string? telefone);
        string AlterarPessoa(int id, string? nome, string? email, string? telefone);
        string DeletarPessoa(int id);
    }
}
