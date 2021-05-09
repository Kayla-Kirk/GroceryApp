using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Models.Recipe_Models
{
    public class RecipeCreate
    {
        [Required]
        public string RecipeName { get; set; }
        
    }
}
