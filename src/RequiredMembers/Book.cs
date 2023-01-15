namespace RequiredMembers;

public class Book
{
    public required string Title { get; set; }
    public required string Author { get; set; }
    public int? Pages { get; set; }
}
