using ConvergenceCorpBlazor.Components;
using Microsoft.EntityFrameworkCore;

public class CVRGContext : DbContext
{
    public DbSet<Group> Groups { get; set; }
    //public DbSet<GroupRun> Runs { get; set; }

    public CVRGContext(DbContextOptions<CVRGContext> options)
        : base(options)
    {
        Console.WriteLine("CVRGContext Constructor");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Console.WriteLine("OnConfiguring");
        optionsBuilder.UseSqlServer("Server=tcp:cvrg.database.windows.net,1433;Initial Catalog=CVRGFREEDB;Encrypt=True;TrustServerCertificate=False;Connection Timeout=60;Authentication=\"Active Directory Default\";");
        Console.WriteLine("EndConfigure");
    }
}