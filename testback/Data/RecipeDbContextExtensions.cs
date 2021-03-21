using F20ITONK.ASPNETCore.MicroService.ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Data
{
    public static class RecipeDbContextExtensions
    {
        public static void EnsureDatabaseSeeded(this RecipeContext context)
        {
            context.Database.EnsureCreated();

            var rp1 = new Recipe()
            {
                RecipeId = 1,
                Name = "Pasta",
                Description = "Pasta med kødsovs",
                Ingrediens = "Pasta",
            };

            var rp2 = new Recipe()
            {
                RecipeId = 1,
                Name = "test",
                Description = "test med kødsovs",
                Ingrediens = "test",
            };

            var rp3 = new Recipe()
            {
                RecipeId = 1,
                Name = "test2",
                Description = "test2 med kødsovs",
                Ingrediens = "test",
            };

            context.Add(rp1);
            context.Add(rp2);
            context.Add(rp3);
            context.SaveChanges();
        }
    }
}
