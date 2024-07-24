using Microsoft.AspNetCore.Mvc;
using SonarQubeAPIIntegration.Domain;

namespace SonarQubeAPIIntegration.Api.Controllers
{
    /// <summary>Controller used for the cats api</summary>
    /// <param name="catService"></param>
    [ApiController]
    public class CatController(ICatService catService) : ControllerBase
    {
        /// <summary>Service interface for use the cat methods</summary>
        public ICatService _catService = catService;

        /// <summary>Method that retrieves a list of cats</summary>
        /// <returns>The list of cats object</returns>
        [HttpGet("api/v1/cats", Name = "Get Cats")]
        public IEnumerable<Cat> GetCats()
        {
            return _catService.GetCats();
        }

        /// <summary>Method that can retrieve a cat by his name</summary>
        /// <param name="name">The cat's name</param>
        /// <returns>The cat information</returns>
        [HttpGet("api/v1/cats/{name}", Name = "Get Cat By Name")]
        public Cat? GetCatByName([FromRoute] string name)
        {
            return _catService.GetCatByName(name);
        }
    }
}