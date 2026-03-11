using Microsoft.EntityFrameworkCore;
using PersonalInfoManageSystem.Models;

namespace PersonalInfoManageSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PersonalInfo> PersonalInfos { get; set; }
    }
}
