using System.ComponentModel.DataAnnotations;

namespace GrupoWebBackend.Resources
{
    public class SavePublicationResource
    {
        [Required]
        public string comment { get; set; }
        [Required]
        public string dateTime {get; set; }
        [Required]
        public int Id {get; set; }
    }
}