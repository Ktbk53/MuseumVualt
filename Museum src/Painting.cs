public class Painting
{
    public string Name { get; set; }
    public int EstimatedAgeYears { get; set; }
    public string Artist { get; set; }

    public Painting(string name, int age, string artist)
    {
        Name = name;
        EstimatedAgeYears = age;
        Artist = artist;
    }

    public string Describe()
    {
        return $"{Name} is a painting created by {Artist}.";
    }
}

