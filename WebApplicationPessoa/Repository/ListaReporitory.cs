using WebApplicationPessoa.Models;

namespace WebApplicationPessoa.Repository
{
    public class ListaReporitory
    {
        static private List<PessoaModel>? listaPessoaModel { get; set; }
        public ListaReporitory()
        {
            if(listaPessoaModel == null)
            {
                listaPessoaModel =
                    new List<PessoaModel>()
                    {
                    new PessoaModel(1,"exemplo1","exemplo1.gmail.com", "+55 11 98888 7654"),
                    new PessoaModel(2,"exemplo2","exemplo2.gmail.com", "+55 11 98877 1234")
                    };
            }
        }
        public List<PessoaModel> GetListaPessoaModel (int? id)
        {
            return (listaPessoaModel ?? new List<PessoaModel>()).Where(l => l.Id == (id ?? l.Id)).ToList();
        }
        public string AdicionarPessoa(int? id, string? nome, string? email, string? telefone)
        {
            bool result = false;
            if (listaPessoaModel != null)
            {
                PessoaModel? pessoaModel = listaPessoaModel.Find(l => l.Id == id);
                if (pessoaModel == null)
                {
                    int count = listaPessoaModel.Count + 1;
                    listaPessoaModel.Add(new PessoaModel(
                        id ?? count,
                        nome ?? string.Format("Pessoa{0}", count),
                        email ?? string.Format("Pessoa{0}@gmail.com", count),
                        telefone ?? ""));
                    result = true;
                }
            }
            return result ? "Sucesso" : "Falha";
        }
        public string AlterarPessoa(int id, string? nome, string? email, string ?telefone)
        {
            bool result = false;
            if (listaPessoaModel != null)
            {
                PessoaModel? pessoaModel = listaPessoaModel.Find(l => l.Id == id);
                if (pessoaModel != null)
                {
                    pessoaModel.Nome = nome ?? pessoaModel.Nome; 
                    pessoaModel.Email = email ?? pessoaModel.Email;
                    pessoaModel.Telefone = telefone ?? pessoaModel.Telefone;
                    result = true;
                }
            }
            return result ? "Sucesso" : "Falha";
        }
        public string DeletarPessoa(int id)
        {
            bool result = false;
            if (listaPessoaModel != null)
            {
                PessoaModel? pessoaModel = listaPessoaModel.Find(l => l.Id == id);
                if (pessoaModel != null)
                {
                    listaPessoaModel.Remove(pessoaModel);
                    result = true;
                }
            }
            return result ? "Sucesso" : "Falha";

        }
    }
}
