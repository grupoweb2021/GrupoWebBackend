using System.ComponentModel.DataAnnotations;

namespace GrupoWebBackend.Security.Domain.Services.Communication
{
    public class RegisterRequest
    {

        [Required]
        public string Pass { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserNick { get; set; }
        [Required]
        public string Ruc { get; set; }
        [Required]
        public string Dni { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int DistrictId { get; set; }
    }
}