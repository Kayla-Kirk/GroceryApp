using Grocery.Models.Recipe_Models;
using Grocery.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Grocery.API.Controllers
{
    [Authorize]
    public class RecipeController : ApiController
    {
        private RecipeService CreateRecipeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var recipeService = new RecipeService(userId);
            return recipeService;
        }

        //public IHttpActionResult Get()
       // {
        //    RecipeService recipeService = CreateRecipeService();
        //    var recipes = recipeService.GetRecipes();
        //    return Ok(recipes);
       // }

        public IHttpActionResult Post(RecipeCreate recipe)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateRecipeService();

            if (!service.CreateRecipe(recipe))
            return InternalServerError();

            return Ok();


        }
    }
}
