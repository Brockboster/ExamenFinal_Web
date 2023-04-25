using ExamenFinal.Models;

namespace ExamenFinal.ModelsDTOs
{
    public class UserDTO
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = null!;
        
        public string Apellido { get; set; } = null!;
        public string? NumeroTelefono { get; set; }
        public string Contrasennia { get; set; } = null!;
     
        public string? DescripcionTrabajo { get; set; }
        public int StatusUsuarioId { get; set; }
        public int IdPais { get; set; }
        public int RoleId { get; set; }

  
        public virtual UserRole UserRole { get; set; } = null!;
        public virtual UserStatus UserStatus { get; set; } = null!;




    }
}
