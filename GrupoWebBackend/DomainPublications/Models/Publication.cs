using GrupoWebBackend.DomainPets.Models;

namespace GrupoWebBackend.DomainPublications.Models
{
    public class Publication
    {
        public int Id { get; set; }
        public int petId { get; set; }
        public Pet pet { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public string dateTime { get; set; }
        public string comment { get; set; }
    }
}