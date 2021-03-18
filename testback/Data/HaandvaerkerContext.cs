using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using F20ITONK.ASPNETCore.MicroService.ClassLib.Models;

public class HaandvaerkerContext : DbContext
{
    public HaandvaerkerContext(DbContextOptions<HaandvaerkerContext> options)
        : base(options)
    {
    }

    public DbSet<F20ITONK.ASPNETCore.MicroService.ClassLib.Models.Haandvaerker> Haandvaerker { get; set; }

    public DbSet<F20ITONK.ASPNETCore.MicroService.ClassLib.Models.Vaerktoej> Vaerktoej { get; set; }

    public DbSet<F20ITONK.ASPNETCore.MicroService.ClassLib.Models.Vaerktoejskasse> Vaerktoejskasse { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Haandvaerker
        modelBuilder.Entity<Haandvaerker>().HasKey(s => s.HaandvaerkerId);

        //Vaerktoejskasse
        modelBuilder.Entity<Vaerktoejskasse>().HasKey(p => p.VTKId);

        modelBuilder.Entity<Haandvaerker>()
            .HasMany<Vaerktoejskasse>(s => s.Vaerktoejskasse)
            .WithOne(vt => vt.EjesAfNavigation)
            .HasForeignKey(s => s.VTKEjesAf);

        modelBuilder.Entity<Vaerktoejskasse>()
            .HasMany<Vaerktoej>(s => s.Vaerktoej)
            .WithOne(s => s.LiggerIvtkNavigation)
            .HasForeignKey(s => s.LiggerIvtk);

    }

}
