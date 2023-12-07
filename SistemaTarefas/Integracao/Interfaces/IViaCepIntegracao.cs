using SistemaTarefas.Integracao.Response;

namespace SistemaTarefas.Integracao.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<ViaCepResponse> ObterDadosViaCep(string cep);
    }
}
