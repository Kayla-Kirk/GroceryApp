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
        [Key]
        public int IngredientID { get; set; }
        [Required]
        public string IngredientName { get; set; }

    }
}
