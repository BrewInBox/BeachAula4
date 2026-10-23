using BeachAula4.Entidades;

namespace BeachAula4.Interfaces
{
    public interface IQuadraRepository
    {
        Task<List<Quadra>> ListarAsync();
        Task<Quadra?> BuscarPorIdAsync(int id);
        Task AdicionarAsync(Quadra quadra);
        Task<bool> AtualizarAsync(Quadra quadra);
        Task<bool> ExcluirAsync(int id);
    }
}
