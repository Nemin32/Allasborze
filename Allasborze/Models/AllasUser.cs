using Microsoft.AspNetCore.Identity;

namespace Allasborze.Models
{
    public class AllasUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Oraber { get; set; }

    }
}
