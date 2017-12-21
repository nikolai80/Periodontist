using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace periodontist.Models
{
  public class PeriodontistContext : DbContext
  {
    public PeriodontistContext():base("PeriodontistConnection")
    {
    }

    public DbSet<UserQuestion> UserQuestions { get; set; }

  }
}