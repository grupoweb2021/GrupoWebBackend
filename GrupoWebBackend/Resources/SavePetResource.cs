using System.ComponentModel.DataAnnotations;

namespace GrupoWebBackend.Resources
{
    public class SavePetResource
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Attention { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Race {get; set; }
        [Required]
        public bool IsAdopted {get; set; }
    }
}