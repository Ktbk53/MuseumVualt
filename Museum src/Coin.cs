namespace MuseumVault;

public class Coin : IArtifact
{
    public string Name { get; set; }
    public int EstimatedAgeYears { get; set; }
    public string CountryOfOrigin { get; set; }

    public Coin(string name, int age, string country)
    {
        Name = name;
        EstimatedAgeYears = age;
        CountryOfOrigin = country;
    }

    public string Describe()
    {
        return $"{Name} is a coin originating from {CountryOfOrigin}.";
    }
}
