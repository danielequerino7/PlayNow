using AutoMapper;
using PlayNow.APIRest.DTOs;
using PlayNow.Domain.Entities;

namespace EmprestimoLivro.API.Mappings
{
    public class EntitiesToDTOMappingProfile : Profile
    {
        public EntitiesToDTOMappingProfile()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap(); // converte de Usuario para UsuarioDTO e converte de UsuarioDTO para Usuarios
        }        
    }
}
