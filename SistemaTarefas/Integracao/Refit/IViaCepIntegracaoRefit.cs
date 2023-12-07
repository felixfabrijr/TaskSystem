using Refit;
using SistemaTarefas.Integracao.Response;

namespace SistemaTarefas.Integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);

    }
}
