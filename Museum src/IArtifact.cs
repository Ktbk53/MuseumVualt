namespace MuseumVault
{
    public interface IArtifact
    {
        string Name {get; }
        int EstimatedAgeYear {get; }
        string Describe()
    }
}