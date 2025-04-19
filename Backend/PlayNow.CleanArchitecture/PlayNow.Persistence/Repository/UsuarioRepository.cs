using Microsoft.EntityFrameworkCore;
using PlayNow.Domain.Entities;
using PlayNow.Domain.Interfaces;
using PlayNow.Persistence.Context;

namespace PlayNow.Persistence.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly PlayNowDbContext _context;

        public UsuarioRepository(PlayNowDbContext context)
        {
            _context = context;
        }

        public void Alterar(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
        }

        public void Excluir(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
        }

        public void Incluir(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
        }

        public async Task<bool> Salvar()
        {
            return await _context.SaveChangesAsync() > 0; // se a condição for verdadeira significa que salvou com êxito, caso contrário retorna false com algum erro (erro de bd)
        }

        public async Task<IEnumerable<Usuario>> SelecionarTodos()
        {
            var usuarios = await _context.Usuarios.ToListAsync();
            return usuarios;
        }

        public async Task<Usuario> SelecionarPorId(int id)
        {
            var usuario = await _context.Usuarios.Where(x => x.IdUsuario == id).FirstOrDefaultAsync(); // recuperando o primeiro resultado
            return usuario;
        }
    }
}
