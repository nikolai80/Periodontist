using Microsoft.AspNet.Identity.EntityFramework;

namespace periodontist.Models
{
    public class RolesViewModel : IdentityRole
    {
        public RolesViewModel() { }

        public string Description { get; set; }


    }
}