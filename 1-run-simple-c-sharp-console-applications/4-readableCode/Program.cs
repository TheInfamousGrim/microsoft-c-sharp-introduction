// string firstName = "Bob";
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++) {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 10000).ToString("0000");
//     orderIDs[i] = prefix + suffix;
// }

// foreach (string orderID in orderIDs) {
//     Console.WriteLine(orderID);
// }

// Example 1:
// Console
// .
// WriteLine
// (
// "Hello Example 1!"
// )
// ;

// Example 2:
// string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
//     if ((roll1 == roll2) && (roll2 == roll3)) {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     } else {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;

foreach (char i in charMessage) { 
    if (i == 'o') {
        x++; 
    } 
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");