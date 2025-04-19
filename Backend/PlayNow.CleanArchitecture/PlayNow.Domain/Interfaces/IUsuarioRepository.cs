using PlayNow.Domain.Entities;

namespace PlayNow.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        void Incluir(Usuario usuario);
        void Alterar(Usuario usuario);
        void Excluir(Usuario usuario);
        Task<Usuario> SelecionarPorId(int id);
        Task<IEnumerable<Usuario>> SelecionarTodos();
        Task<bool> Salvar();
    }
}
