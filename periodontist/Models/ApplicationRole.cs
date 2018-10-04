using Microsoft.AspNet.Identity.EntityFramework;

namespace periodontist.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() { }

        public string DescriptionRole { get; set; }
    }
}