public class Fossil
{
    public string Name { get; set; }
    public int EstimatedAgeYears { get; set; }
    public string Species { get; set; }

    public Fossil(string name, int age, string species)
    {
        Name = name;
        EstimatedAgeYears = age;
        Species = species;
    }

    public string Describe()
    {
        return $"{Name} is a fossil from the species {Species}.";
    }
}
