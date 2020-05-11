using FootballManager.Entities;
using Microsoft.EntityFrameworkCore;
using Models;

namespace FootballManager.DAL.Impl
{
    public class FootballManagerContext : DbContext
    {
         public FootballManagerContext(DbContextOptions<FootballManagerContext> options) : base(options)
         {
         }

        public DbSet<Championship> Championships { get; set; }
        public DbSet<ChampionshipCommand> ChampionshipCommands { get; set; }
        public DbSet<Command> Commands { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<PlayerDTO> PlayerDtos { get; set; }


    }
}
