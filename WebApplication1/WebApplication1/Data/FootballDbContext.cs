using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class FootballDbContext: DbContext
    {
        public FootballDbContext(DbContextOptions<FootballDbContext> options) : base(options) { 


        }
        #region
        public DbSet<PlayerFootball> Footballs { get; set;}
        public DbSet<Position> Positions { get; set;}
        public DbSet<InforPlayer> InforPlayers { get; set;}
        public DbSet<Club> Clubs { get; set;}
        #endregion
    }
}
