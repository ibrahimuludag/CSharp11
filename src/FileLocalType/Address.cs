namespace FileLocalType;

public class Address
{
    public string Streeet { get; set; } = default!;
    public string Country { get; set; } = default!;
    public string PostalCode { get; set; } = default!;
    public double Longitude { get; set; }
    public double Latitude { get; set; }

    public string GetLocation() {
        return new Coordinate { Latitude = Longitude, Longitude = Longitude }.GetLocation();
    }
}

file class Coordinate
{
    public required double Longitude { get; set; }
    public required double Latitude { get; set; }

    public string GetLocation()
    {
        return "Your location is Eiffel Tower, Paris, France";
    }
}

