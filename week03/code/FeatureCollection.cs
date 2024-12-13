public class FeatureCollection
{
    public string type { get; set; }
    public Feature[] features { get; set; }
}

public class Feature
{
    public string type { get; set; }
    public Properties properties { get; set; }
    public string id { get; set; }
}

public class Properties
{
    public double mag { get; set; }
    public string place { get; set; }
}