using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Wangkanai.Interview.Portal.Identity;

namespace Wangkanai.Interview.Portal;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
   : IdentityDbContext<ApplicationUser>(options)
{
   protected override void OnModelCreating(ModelBuilder builder)
   {
      base.OnModelCreating(builder);

      builder.ApplyConfigurationsFromAssembly(typeof(PortalConstants).Assembly);
   }
}
