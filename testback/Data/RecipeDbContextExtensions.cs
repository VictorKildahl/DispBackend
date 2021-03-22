using F20ITONK.ASPNETCore.MicroService.ClassLib.Models;
using Microsoft.EntityFrameworkCore;
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
            context.Database.Migrate();

            var rp1 = new Recipe()
            {
                RecipeId = 1,
                Name = "Pasta",
                Description = "Pasta med kødsovs",
                Ingrediens = "Pasta",
            };

            var rp2 = new Recipe()
            {
                RecipeId = 2,
                Name = "Pizza",
                Description = "Pizza med skinke og ost",
                Ingrediens = "Dej, ost, skinke",
            };

            var rp3 = new Recipe()
            {
                RecipeId = 3,
                Name = "Rugbrød",
                Description = "Rugbrød med hamburgeryg",
                Ingrediens = "Rugbrød, smør, hamburgeryg",
            };

            context.Add(rp1);
            context.Add(rp2);
            context.Add(rp3);
            context.SaveChanges();
        }
    }
}
