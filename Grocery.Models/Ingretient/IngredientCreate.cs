using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Models
{
      public class IngredientCreate
      {
            [Required]
            
            [Display(Name ="Ingredient ID")]
            public int IngredientID { get; set; }

            [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
            [MaxLength(100, ErrorMessage = "There are too many characters in this field")]
            [Display(Name ="Ingredient Name")]
            public string  IngredientName { get; set; }

            [Display(Name = "Created")]
            public DateTimeOffset CreatedUtc { get; set; }





      }
}
