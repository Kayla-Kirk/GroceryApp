using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Data
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }
        [Required]
        public string RecipeName { get; set; }
        [ForeignKey(nameof(Ingredient))]
        public virtual List<Ingredient> ListOfIngredients { get; set; }
        public string Content { get; set; }
    }
}
