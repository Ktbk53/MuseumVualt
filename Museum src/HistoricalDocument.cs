namespace MuseumVault;

public class HistoricalDocument : IArtifact
{
    public string Name { get; set; }
    public int EstimatedAgeYears { get; set; }
    public string Language { get; set; }

    public HistoricalDocument(string name, int age, string language)
    {
        Name = name;
        EstimatedAgeYears = age;
        Language = language;
    }

    public string Describe()
    {
        return $"{Name} is a historical document written in {Language}.";
    }
}
