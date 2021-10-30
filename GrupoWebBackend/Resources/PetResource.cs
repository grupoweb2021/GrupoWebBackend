namespace GrupoWebBackend.Resources
{
    public class PetResource
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Attention { get; set; }
        public string Age { get; set; }
        public string Race { get; set; }
        public bool IsAdopted { get; set; }
    }
}