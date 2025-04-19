using System.ComponentModel.DataAnnotations;

namespace PlayNow.APIRest.DTOs
{
    public class UsuarioDTO
    {

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Senha { get; set; }

        [Required]
        [StringLength(14)]
        public string Telefone { get; set; }

        [Required]
        public bool IsAdmin { get; set; } = false;

        public bool Deletado { get; set; } = false;
    }
}

