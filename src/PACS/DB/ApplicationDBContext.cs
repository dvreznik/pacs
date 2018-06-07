using Microsoft.EntityFrameworkCore;
using PACS.Models;

namespace PACS.DB
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<GymCard> GymCards { get; set; }
        public DbSet<GymMember> GymMembers { get; set; }
    }
}
