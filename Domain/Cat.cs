namespace SonarQubeAPIIntegration.Domain
{
    /// <summary>Contains informations about cats</summary>
    public class Cat
    {
        /// <summary>Gets or sets the name of the cat</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the age of the cat</summary>
        public int Age { get; set; }

        /// <summary>Gets or sets the color of the cat</summary>
        public CatColor Color { get; set; }
    }

    /// <summary>The list of cat colors</summary>
    public enum CatColor
    {
        Black,
        White,
        Brown,
        Gray,
        Orange
    }
}