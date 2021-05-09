using Grocery.Data;
using Grocery.Models.Recipe_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Services
{
    public class RecipeService
    {
        private readonly Guid _userId;
        public  RecipeService(Guid userId)
        {
            _userId = userId;
        }

        public bool RecipeNameValidator(string recipeName)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Recipes.Where(e => e.RecipeName == recipeName && e.UserId == _userId);
                if (query.Any())
                {
                    return true;
                }
                return false;
            }
        }

        public bool CreateRecipe(RecipeCreate model)
        {
            var nameValidatorResult = RecipeNameValidator(model.RecipeName);
            if (nameValidatorResult)
            {
                return false;
            }
            else
            {
                var entity = new Recipe()
                {
                    UserId = _userId,
                    RecipeName = model.RecipeName,

                };
                using (var ctx = new ApplicationDbContext())
                {
                    ctx.Recipes.Add(entity);
                    return ctx.SaveChanges() == 1;
                }
            }
        }
    }
}
