// See https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#raw-string-literals
// See https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
// See https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated

/*
Raw string literals are a new format for string literals. 
Raw string literals can contain arbitrary text, including whitespace, new lines, embedded quotes, 
and other special characters without requiring escape sequences. 
A raw string literal starts with at least three double-quote (""") characters. 
It ends with the same number of double-quote characters. 
Typically, a raw string literal uses three double quotes on a single line to start the string, 
and three double quotes on a separate line to end the string. 
The newlines following the opening quote and preceding the closing quote aren't included in the final content:
*/

string longMessage = """
    This is a long message.
    It has several lines.
        Some are indented
                more than others.
    Some should start at the first column.
    Some have "quoted text" in them.
    """;

Console.WriteLine(longMessage);

//////////////////////////////////////////////////////////////////////////////////

string singleLine = """Friends say "hello" as they pass by.""";
Console.WriteLine(singleLine);

//////////////////////////////////////////////////////////////////////////////////

string multiLine = """
    "Hello World!" is typically the first program someone writes.
    """;
Console.WriteLine(multiLine);

//////////////////////////////////////////////////////////////////////////////////
// The line "<element attr = "content">" starts in the first column.
// All whitespace left of that column is removed from the string.

string embeddedXML = """
       <element attr = "content">
           <body style="normal">
               Here is the main text
           </body>
           <footer>
               Excerpts from "An amazing story"
           </footer>
       </element >
       """;
Console.WriteLine(embeddedXML);

//////////////////////////////////////////////////////////////////////////////////

string rawStringLiteralDelimiter = """"
    Raw string literals are delimited 
    by a string of at least three double quotes,
    like this: """
    """";
Console.WriteLine(rawStringLiteralDelimiter);

//////////////////////////////////////////////////////////////////////////////////

string jsonString = """
{
  "Date": "2019-08-01T00:00:00-07:00",
  "TemperatureCelsius": 25,
  "Summary": "Hot",
  "DatesAvailable": [
    "2019-08-01T00:00:00-07:00",
    "2019-08-02T00:00:00-07:00"
  ],
  "TemperatureRanges": {
    "Cold": {
      "High": 20,
      "Low": -10
    },
    "Hot": {
      "High": 60,
      "Low": 20
    }
            },
  "SummaryWords": [
    "Cool",
    "Windy",
    "Humid"
  ]
}
""";
Console.WriteLine(jsonString);

//////////////////////////////////////////////////////////////////////////////////


/*
The following examples demonstrate the compiler errors reported based on these rules:
// CS8997: Unterminated raw string literal.
var multiLineStart = """This
    is the beginning of a string 
    """;

// CS9000: Raw string literal delimiter must be on its own line.
var multiLineEnd = """
    This is the beginning of a string """;

// CS8999: Line does not start with the same whitespace as the closing line
// of the raw string literal
var noOutdenting = """
    A line of text.
Trying to outdent the second line.
    """;
*/

//////////////////////////////////////////////////////////////////////////////////


var Latitude = 48.858093;
var Longitude = 2.294694;

/*
 You can use multiple $ characters in an interpolated raw string literal to embed { and } characters in the output string without escaping them:
*/
var location = $$"""
   You are at {{{Longitude}}, {{Latitude}}}
   """;

Console.WriteLine(location);
