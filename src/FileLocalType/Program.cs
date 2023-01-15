// See https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/file

using FileLocalType;

var address = new Address
{
    Latitude = 48.858093,
    Longitude = 2.294694,
    PostalCode = "75007",
    Streeet = "Champ de Mars, 5 Av. Anatole",
    Country = "France"
};

Console.WriteLine(address.GetLocation());

// Below will not compile
//var coordinate = new Coordinate { Latitude = 48.858093, Longitude = 2.294694 };
