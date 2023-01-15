// See https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/required

using RequiredMembers;

// This will compile
var solito = new Book { Author = "Javier Zamora", Title = "Solito: A Memoir", Pages = 386 };

// This will not compile
//var solitoError = new Book { Author = "Javier Zamora" };