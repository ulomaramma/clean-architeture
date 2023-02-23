﻿using Microsoft.AspNetCore.Mvc;
using WebApi.Requests;
using WebApi.Services;
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : Controller
    {
        private readonly RecipeService _recipeService;

        public RecipeController(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
     
        [HttpPost]
        public IActionResult PostRecipe([FromBody] RecipeRequest request)
        {
            if (request == null)
            {
                return BadRequest("Recipe request is null.");
            }

            var recipe = _recipeService.AddRecipe(request);

            return CreatedAtAction(nameof(GetRecipe), new { id = recipe.Id }, recipe);
        }

       
      /// <summary>
      /// 
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetRecipe(int id)
        {
            var recipe = _recipeService.GetRecipeById(id);
            if (recipe == null)
            {
                return NotFound();
            }
            return Ok(recipe);
        }

    }
}
