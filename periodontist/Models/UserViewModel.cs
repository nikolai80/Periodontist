using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace periodontist.Models
{
    public class UserViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public IdentityUserRole Role { get; set; }

    }
}