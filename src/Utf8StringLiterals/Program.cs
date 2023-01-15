// See https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/utf8-string-literals?source=recommendations

//string s1 = "hello"u8;             // Error
var s2 = "hello"u8;                // Okay and type is ReadOnlySpan<byte>
ReadOnlySpan<byte> s3 = "hello"u8; // Okay.
//byte[] s4 = "hello"u8;             // Error - Cannot implicitly convert type 'System.ReadOnlySpan<byte>' to 'byte[]'.
byte[] s5 = "hello"u8.ToArray();   // Okay.
//Span<byte> s6 = "hello"u8;         // Error - Cannot implicitly convert type 'System.ReadOnlySpan<byte>' to 'System.Span<byte>'.