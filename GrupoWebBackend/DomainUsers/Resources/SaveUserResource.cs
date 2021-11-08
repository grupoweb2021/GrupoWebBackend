using System.ComponentModel.DataAnnotations;

namespace GrupoWebBackend.DomainUsers.Resources
{
    public class SaveUserResource
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        public string UserNick { get; set; }
        public string Pass { get; set; }
        public string Ruc { get; set; }
        [Required]
        public string Dni { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int LocationId { get; set; }
        [Required]
        public int PetId { get; set; }
    }
}