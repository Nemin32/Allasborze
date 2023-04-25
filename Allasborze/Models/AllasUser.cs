using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Allasborze.Models
{
    public class AllasUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Oraber { get; set; }

        [NotMapped]
        public virtual List<AllasModel> Allasok { get; set; }

    }
}
