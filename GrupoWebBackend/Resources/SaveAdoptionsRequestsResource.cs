using System.ComponentModel.DataAnnotations;

namespace GrupoWebBackend.Resources
{
    public class SaveAdoptionsRequestsResource
    {
        [Required]
        public string Message { get; set; }
        
        [Required]
        public string Status { get; set; }
    }
}