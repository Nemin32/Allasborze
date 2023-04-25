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
        public int Oraber { get; set; }

        [Required]
        public string Pozicio { get; set; }

        [Required]
        public string Leiras { get; set; }

        [NotMapped]
        public virtual List<AllasUser> Dolgozok { get; set; }
    }
}
