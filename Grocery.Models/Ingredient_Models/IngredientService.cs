using Grocery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Models
{
      public class IngredientService
      {
            private readonly Guid _userId;

            public IngredientService(Guid userId)
            {
                  _userId = userId;
            }

            public bool CreateIngredient(IngredientCreate model)
            {
                  var entity =
                        new Ingredient()
                        {
                              OwnerId = _userId,                         
                              IngredientName = model.IngredientName,
                              CreatedUtc = DateTimeOffset.Now

                        };

                

                  using (var ctx = new ApplicationDbContext())
                  {
                        ctx.Ingredients.Add(entity);

                        return ctx.SaveChanges() == 1;
                  }
            }

            public IEnumerable<IngredientDetails> GetIngredient()
            {
                  using (var ctx = new ApplicationDbContext())
                  {
                        var query =
                              ctx
                              .Ingredients
                              .Select(e =>
                             new IngredientDetails
                             {
                                   IngredientId = e.IngredientID,
                                   IngredientName = e.IngredientName,
                                   CreatedUtc = e.CreatedUtc
                             });
                        return query.ToArray();
                  }
            }

            public IngredientListItem GetIngredientByName(string name)
            {
                  using (var ctx = new ApplicationDbContext())
                  {
                        var entity =
                              ctx
                              .Ingredients
                              .Single(e => e.IngredientName == name);
                        return
                              new IngredientListItem
                              {
                                    IngredientId = entity.IngredientID,
                                    IngredientName = entity.IngredientName,
                                    CreatedUtc = entity.CreatedUtc,
                                    ModifiedUtc = entity.ModifiedUtc
                              };


                  }

            }

            public bool UpdateIngredient(IngredientEdit model)
            {
                  using (var ctx = new ApplicationDbContext())
                  {
                        var entity =
                              ctx
                              .Ingredients
                              .Single(e => e.IngredientName == model.IngredientName);
                        entity.IngredientName = model.IngredientName;
                        entity.ModifiedUtc = DateTimeOffset.UtcNow;
                        return ctx.SaveChanges() == 1;
                  }
            }

            public bool DeleteIngredient(string ingredientname)
            {
                  using (var ctx = new ApplicationDbContext())
                  {
                        var entity =
                              ctx
                              .Ingredients
                              .Single(e => e.IngredientName == ingredientname);

                        ctx.Ingredients.Remove(entity);

                        return ctx.SaveChanges() == 1;
                  }

            }

      }
}
