namespace MuseumVault
{
    public interface IArtifact
    {
        string Name {get; }
        int EstimatedAgeYears {get; }
        string Describe()
    }
}