namespace AutoDefaultStructs;

public struct Coordinate
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public override string ToString()
    {
        return $"Longitude : {Longitude}, Latitude : {Latitude}";
    }
}
