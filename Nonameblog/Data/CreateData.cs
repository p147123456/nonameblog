using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Nonameblog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nonameblog.Data
{
    public static class CreateData
    {
        public static void MemberInit(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                            serviceProvider.GetRequiredService<
                                DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }

                context.SaveChanges();
            }
        }
        public static void NonameblogInit(IServiceProvider serviceProvider)
        {
            using (var context = new NonameblogContext(
                            serviceProvider.GetRequiredService<
                                DbContextOptions<NonameblogContext>>()))
            {
                // Look for any movies.
                if (context.Artcile.Any())
                {
                    return;   // DB has been seeded
                }

                context.SaveChanges();
            }
        }
    }
}
