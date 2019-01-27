namespace Linq
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LinqSportContext : DbContext
    {
        public LinqSportContext()
            : base("name=LinqSportContext")
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}