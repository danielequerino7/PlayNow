using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlayNow.APIRest.DTOs;
using PlayNow.Domain.Entities;
using PlayNow.Domain.Interfaces;

namespace PlayNow.APIRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {

        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _usuarioMapper;

        public UsuarioController(IUsuarioRepository usuarioRepository, IMapper usuarioMapper)
        {
            _usuarioRepository = usuarioRepository;
            _usuarioMapper = usuarioMapper;
        }

        [HttpGet("selecionarTodosUsuarios")]
        public async Task<ActionResult<IEnumerable<Usuario>>> selecionarTodosOsUsuarios()
        {
            var usuarios = await _usuarioRepository.SelecionarTodos();
            var usuariosDTO = _usuarioMapper.Map<IEnumerable<UsuarioDTO>>(usuarios);

            return Ok(usuariosDTO);
        }

        [HttpGet("selecionarUsuario/{id}")]
        public async Task<ActionResult> selecionarUsuario(int id)
        {
            var usuario = await _usuarioRepository.SelecionarPorId(id);

            if (usuario == null)
            {
                return NotFound("Usuário não encontrado.");
            }

            var usuarioDTO = _usuarioMapper.Map<UsuarioDTO>(usuario);

            return Ok(usuarioDTO);
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarUsuario(UsuarioDTO usuarioDTO)
        {

            var usuario = _usuarioMapper.Map<Usuario>(usuarioDTO);
            _usuarioRepository.Incluir(usuario);

            if (await _usuarioRepository.Salvar())
            {
                return Ok("Usuário cadastrado com sucesso.");
            }

            return BadRequest("Ocorreu um erro ao salvar o usuário.");
        }

        [HttpPut]
        public async Task<ActionResult> AlterarUsuario(Usuario usuario)
        {
            _usuarioRepository.Alterar(usuario);

            if (await _usuarioRepository.Salvar())
            {
                return Ok("Usuário alterado com sucesso");
            }
            return BadRequest("Ocorreu um erro ao alterar usuário.");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> ExcluirUsuario(int id)
        {
            var usuario = await _usuarioRepository.SelecionarPorId(id);

            if (usuario == null)
            {
                return NotFound("Usuário não encontrado.");
            }

            _usuarioRepository.Excluir(usuario);

            if (await _usuarioRepository.Salvar())
            {
                return Ok("Usuário excluído com sucesso.");
            }

            return BadRequest("Ocorreu um erro ao excluir o usuário.");
        }
    }
}
