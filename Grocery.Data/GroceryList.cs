using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Data
{
    public class GroceryList
    {
        [Key]
        public int GroceryListID { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [ForeignKey(nameof(Ingredient))]
        public virtual List<Ingredient> ListOfIngredients { get; set; }
        
        [ForeignKey(nameof(Category))]
        public virtual IngredientCategory Category { get; set; }
    }
}
