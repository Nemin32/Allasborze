using System.ComponentModel.DataAnnotations;

namespace Allasborze.Models
{
    public class AllasModel
    {
        [Key]
        public string Guid { get; set; }

        [Required]
        public int Oraber { get; set; }

        [Required]
        public string Pozicio { get; set; }

        [Required]
        public string Leiras { get; set; }
    }
}
