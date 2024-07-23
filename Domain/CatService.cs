namespace SonarQubeAPIIntegration.Domain
{
    public class CatService : ICatService
    {
        public Cat? GetCatByName(string name)
        {
            return name switch
            {
                "Whiskers" => new Cat { Name = "Whiskers", Age = 3, Color = CatColor.Black },
                "Mittens" => new Cat { Name = "Mittens", Age = 7, Color = CatColor.White },
                "Fluffy" => new Cat { Name = "Fluffy", Age = 2, Color = CatColor.Brown },
                "Socks" => new Cat { Name = "Socks", Age = 5, Color = CatColor.Gray },
                "Tiger" => new Cat { Name = "Tiger", Age = 1, Color = CatColor.Orange },
                _ => null,
            };
        }

        public IEnumerable<Cat> GetCats()
        {
            return new List<Cat>
            {
                new() { Name = "Whiskers", Age = 3, Color = CatColor.Black },
                new() { Name = "Mittens", Age = 7, Color = CatColor.White },
                new() { Name = "Fluffy", Age = 2, Color = CatColor.Brown },
                new() { Name = "Socks", Age = 5, Color = CatColor.Gray },
                new() { Name = "Tiger", Age = 1, Color = CatColor.Orange }
            };
        }
    }
}