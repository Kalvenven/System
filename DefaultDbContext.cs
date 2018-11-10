using CalvinJerilNicdao.System.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace GoshenJimenez.MercadiaII.Web.Infrastructure.Data.Helpers
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
    : base(options)
        {

        }

        #region Models

        public DbSet <Users> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}