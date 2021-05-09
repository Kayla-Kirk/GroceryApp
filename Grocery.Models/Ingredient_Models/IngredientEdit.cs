using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Models
{
      public class IngredientEdit
      {
            [Display(Name = "Ingredient Name")]
            public string IngredientName { get; set; }

            [Display(Name = "Created")]
            public DateTimeOffset CreatedUtc { get; set; }

            [Display(Name = "Modified")]
            public DateTimeOffset ModifiedUtc { get; set; }
      }
}
