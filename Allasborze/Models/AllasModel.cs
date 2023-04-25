using System.ComponentModel.DataAnnotations;

namespace Allasborze.Models
{
    public class AllasModel
    {
        public AllasModel()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public int Oraber { get; set; }

        [Required]
        public string Pozicio { get; set; }

        [Required]
        public string Leiras { get; set; }
    }
}
