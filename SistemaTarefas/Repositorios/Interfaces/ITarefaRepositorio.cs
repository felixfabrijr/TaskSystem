using SistemaTarefas.Models;

namespace SistemaTarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefaModel>> BuscarTodasTarefas();
        Task<TarefaModel> BuscarPorId(int id);
        Task<TarefaModel> Adicionar(TarefaModel tarefas);
        Task<TarefaModel> Atualizar(TarefaModel tarefas, int id);
        Task<bool> Apagar(int id);
    }
}
