using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using F20ITONK.ASPNETCore.MicroService.ClassLib.Models;

public class RecipeContext : DbContext
{
    public RecipeContext(DbContextOptions<RecipeContext> options)
        : base(options)
    {
    }

    public DbSet<F20ITONK.ASPNETCore.MicroService.ClassLib.Models.Recipe> Recipe { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Recipe>().HasKey(s => s.RecipeId);
    }

}
