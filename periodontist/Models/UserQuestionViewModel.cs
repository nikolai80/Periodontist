using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace periodontist.Models
{
    public class UserQuestionViewModel
    {
        public class AddQuestionViewModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Адрес электронной почты")]
            public string Email { get; set; }

            public string UserName { get; set; }

            public string Question { get; set; }
        }

    }
}