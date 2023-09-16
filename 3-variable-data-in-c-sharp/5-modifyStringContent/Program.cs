// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition + 1, length - 1));

// string message2 = "What is the value <span>between the tags</span>";

// static string GetBetween(string strSource, string strStart, string strEnd)
// {
//     if (strSource.Contains(strStart) && strSource.Contains(strEnd))
//     {
//         int Start, End;
//         Start = strSource.IndexOf(strStart, 0) + strStart.Length;
//         End = strSource.IndexOf(strEnd, Start);
//         return strSource.Substring(Start, End - Start);
//     }

//     return "";
// }

// string subString = GetBetween(message2, "<span>", "</span>");

// Console.WriteLine(subString);

/* --------------- Retrieve the Last Occurrence of a Sub String -------------- */

// string message3 = "(What if) I am (only interested) in the last (set of parentheses)";

// int openingParen = message3.LastIndexOf("(");
// int closingParen = message3.LastIndexOf(")");

// int length3 = closingParen - openingParen;

// Console.WriteLine(message3.Substring(openingParen + 1, length3 - 1));


/* --------- Retrieve all instances of substrings inside parentheses -------- */

// string message4 = "(What if) there are (more than) one (set of parentheses)";

// while (true)
// {
//     if (message4.Length == 0) break;
//     int openingParentheses = message4.IndexOf("(");

//     int closingParentheses = message4.IndexOf(")");
//     int length4 = closingParentheses - openingParentheses;

//     Console.WriteLine(message4.Substring(openingParentheses + 1, length4 - 1));

//     // Mutate the message4
//     message4 = message4.Substring(closingParentheses + 1);
// }

/* ---------------- Work with different types of symbol sets ---------------- */

// string message = "Help (find) the {opening symbols}";

// Console.WriteLine($"Searching THIS Message: {message}");

// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 6;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPostion: {message.Substring(openingPosition)}");

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// char[] openSymbols = { '[', '{', '(' };

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     int length = closingPosition - openingPosition;

//     Console.WriteLine(message.Substring(openingPosition + 1, length - 1));
// }


/* -------------------------------------------------------------------------- */
/*                   Use the Remove() and Replace() methods                   */
/* -------------------------------------------------------------------------- */

