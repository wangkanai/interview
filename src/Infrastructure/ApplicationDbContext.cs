using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Wangkanai.Interview.Identity;

namespace Wangkanai.Interview;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
   : IdentityDbContext<ApplicationUser>(options)
{
   protected override void OnModelCreating(ModelBuilder builder)
   {
      base.OnModelCreating(builder);

      builder.ApplyConfigurationsFromAssembly(typeof(PortalConstants).Assembly);
   }
}
