using Grocery.Models;
using Grocery.Data;
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
      public class IngredientController : ApiController
      {
            private IngredientService CreateIngredientService()
            {
                  var userId = Guid.Parse(User.Identity.GetUserId());

                  var ingredientService = new IngredientService(userId);

                  return ingredientService;
            }

            public IHttpActionResult Post(IngredientCreate ingredient)
            {
                  if (!ModelState.IsValid)
                        return BadRequest(ModelState);

                  var Service = CreateIngredientService();

                  if (!Service.CreateIngredient(ingredient))
                  {
                        return InternalServerError();
                  }

                  return Ok();
            }

            public IHttpActionResult Get()
            {
                  IngredientService Iservice = CreateIngredientService();

                  var content = Iservice.GetIngredient();
                  return Ok(content);
            }

            public IHttpActionResult Put(IngredientEdit ingredient)
            {
                  if (!ModelState.IsValid)
                        return BadRequest(ModelState);

                  var service = CreateIngredientService();

                  if (!service.UpdateIngredient(ingredient))
                  {
                        return InternalServerError();
                  }

                  return Ok();
            }

            public IHttpActionResult Delete(string ingredientName)
            {
                  var service = CreateIngredientService();

                  if (!service.DeleteIngredient(ingredientName))
                        return InternalServerError();

                  return Ok();



            }

      }
}

