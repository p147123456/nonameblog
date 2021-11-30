using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nonameblog.Models;

namespace Nonameblog.Models
{
    public class NonameblogContext : DbContext
    {
        public NonameblogContext (DbContextOptions<NonameblogContext> options)
            : base(options)
        {
        }

        public DbSet<Nonameblog.Models.Artcile> Artcile { get; set; }
        internal Task<IList<Artcile>> FindAsync(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
        public DbSet<Nonameblog.Models.Comment> Comment { get; set; }
    }
}
