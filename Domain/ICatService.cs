namespace SonarQubeAPIIntegration.Domain
{
    public interface ICatService
    {
        public IEnumerable<Cat> GetCats();

        public Cat? GetCatByName(string name);
    }
}