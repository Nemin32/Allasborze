using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Range(50, 10000)]
        public int Oraber { get; set; }

        [Required]
        [MaxLength(100)]
        public string Pozicio { get; set; }

        [Required]
        [MaxLength(500)]
        public string Leiras { get; set; }

        [NotMapped]
        public virtual List<AllasUser> Dolgozok { get; set; }
    }
}
