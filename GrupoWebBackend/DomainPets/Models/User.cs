namespace GrupoWebBackend.DomainPets.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string UserNick { get; set; }
        public string Pass { get; set; }
        public string Ruc { get; set; }
        public string Dni { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }
        
        public int PetId { get; set; }
        public Pet Pet { get; set; }
        
    }
}