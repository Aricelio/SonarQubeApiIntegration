using Microsoft.AspNetCore.Mvc;
using SonarQubeAPIIntegration.Domain;

namespace SonarQubeAPIIntegration.Controllers
{
    [ApiController]
    public class CatController(ICatService catService) : ControllerBase
    {
        public ICatService _catService = catService;

        [HttpGet("api/v1/cats", Name = "Get Cats")]
        public IEnumerable<Cat> GetCats()
        {
            return _catService.GetCats();
        }

        [HttpGet("api/v1/cats/{name}", Name = "Get Cat By Name")]
        public Cat? GetCatByName([FromRoute] string name)
        {
            return _catService.GetCatByName(name);
        }
    }
}