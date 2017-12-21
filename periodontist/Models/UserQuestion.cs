using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace periodontist.Models
{
  public class UserQuestion
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string QuestionText { get; set; }
  }
}