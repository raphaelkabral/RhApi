using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhApi.Domain
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Cellphone { get; set; }      
        public string Password { get; set; }       
        public string ConfirPassword { get; set; }
        [Required]
        public string Role { get; set; } // Perfil de acesso

        public ICollection<Company> Companies { get; set; }
    }
}
