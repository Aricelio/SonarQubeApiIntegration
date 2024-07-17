using Microsoft.AspNetCore.Mvc;
using SonarQubeAPIIntegration.Domain;

namespace SonarQubeAPIIntegration.Controllers
{
    [ApiController]
    public class CatController : ControllerBase
    {
        [HttpGet("api/v1/cats", Name = "Get Cats")]
        public IEnumerable<Cat> GetCats()
        {
            return new List<Cat>
            {
                new Cat { Name = "Whiskers", Age = 3, Color = CatColor.Black },
                new Cat { Name = "Mittens", Age = 7, Color = CatColor.White },
                new Cat { Name = "Fluffy", Age = 2, Color = CatColor.Brown },
                new Cat { Name = "Socks", Age = 5, Color = CatColor.Gray },
                new Cat { Name = "Tiger", Age = 1, Color = CatColor.Orange }
            };
        }

        [HttpGet("api/v1/cats/{name}", Name = "Get Cat By Name")]
        public Cat GetCatByName([FromRoute] string name)
        {
            switch (name)
            {
                case "Whiskers":
                    return new Cat { Name = "Whiskers", Age = 3, Color = CatColor.Black };

                case "Mittens":
                    return new Cat { Name = "Mittens", Age = 7, Color = CatColor.White };

                case "Fluffy":
                    return new Cat { Name = "Fluffy", Age = 2, Color = CatColor.Brown };

                case "Socks":
                    return new Cat { Name = "Socks", Age = 5, Color = CatColor.Gray };

                case "Tiger":
                    return new Cat { Name = "Tiger", Age = 1, Color = CatColor.Orange };

                default:
                    return null;
            }
        }
    }
}