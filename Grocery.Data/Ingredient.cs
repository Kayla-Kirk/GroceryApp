using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Data
{
      public class Ingredient
      {
            [Required]
            public int IngredientId { get; set; }

            [Required]
            public Guid OwnerId { get; set; }

            [Required]
            public string IngredientName { get; set; }


            [Required]
            public DateTimeOffset CreatedUtc { get; set; }


            [Required]
            public DateTimeOffset? ModifiedUtc { get; set; }

            // [ForeignKey(nameof(Category))]
            // public int CategoryId { get; set; }

            // public virtual Category Category { get; set; }
      }
}
