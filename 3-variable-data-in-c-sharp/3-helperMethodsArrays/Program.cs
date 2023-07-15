/* -------------------------------------------------------------------------- */
/*                 Create an array of pallets, then sort them                 */
/* -------------------------------------------------------------------------- */

// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/* -------------------------------------------------------------------------- */
/*                      Reverse the order of the pallets                      */
/* -------------------------------------------------------------------------- */

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/* -------------------------------------------------------------------------- */
/*               Use array methods to clear and resize an array               */
/* -------------------------------------------------------------------------- */

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... Count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/* ------------------ Resize the array to add more elements ----------------- */

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... Count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/* ------------------- Resize the array to remove elements ------------------ */

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... Count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

/* -------------------------------------------------------------------------- */
/*                     Discover Split() and Join() methods                    */
/* -------------------------------------------------------------------------- */

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string result = new string(valueArray);
// Console.WriteLine(result);

// Combine all of the chars into a new comma-separated-value string using Join()

// string result = string.Join(",", valueArray);
// Console.WriteLine(result);

/* ---- Split() the comma-separated-value string into an array of strings --- */

// string[] values = result.Split(',');
// foreach (var item in values)
// {
//     Console.WriteLine(item);
// }

/* -------------------------------------------------------------------------- */
/*                              Code Challenge 1                              */
/* -------------------------------------------------------------------------- */

// string pangram = "The quick brown fox jumps over the lazy dog";

// 1. write the code necessary to reverse the letters of each word in place and display the result.

// string[] words = pangram.Split(' ');
// string[] reversedWordsArray = new string[words.Length];

// foreach (var word in words)
// {
//     char[] letters = word.ToCharArray();
//     Array.Reverse(letters);
//     reversedWordsArray[Array.IndexOf(words, word)] = new string(letters);
// }

// string reversedPangram = string.Join(" ", reversedWordsArray);
// Console.WriteLine(reversedPangram);

/* -------------------------------------------------------------------------- */
/*                              Code Challenge 2                              */
/* -------------------------------------------------------------------------- */

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// 1. Add code below the previous code to parse the "Order IDs" from the string of incoming orders and store the "Order IDs" in an array.
// 2. Add code to output each "Order ID" in sorted order and tag orders that are not exactly four characters in length as "- Error".

string[] orders = orderStream.Split(',');
Array.Sort(orders);

foreach (var order in orders)
{
    if (order.Length != 4)
    {
        Console.WriteLine($"{order} - Error");
    }
    else
    {
        Console.WriteLine(order);
    }
}
