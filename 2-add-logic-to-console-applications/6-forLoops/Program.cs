// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// string[] names = { "Bob", "Conrad", "Grant", "Horace", "Irving", "John" };

// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }

// string[] names = { "Bob", "Conrad", "Grant", "Horace", "Irving", "John" };
// foreach (string name in names)
// {
    // Can't do this:
//     if (name == "David") name = "Sammy";
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == "David")
//     {
//         names[i] = "Sammy";
//         Console.WriteLine(names[i]);
//     } else
//     {
//         Console.WriteLine(names[i]);
//     }
// }

// foreach (var name in names) 
// {
// Console.WriteLine(name); 
// }

// Fizz buzz rules

// 1. Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
// 2. If the current value is divisible by 3, print the term "Fizz" alongside the number.
// 3. If the current value is divisible by 5, print the term "Buzz" alongside the number.
// 4. If the current value is divisible by both 3 and 5, print the term "FizzBuzz" alongside the number.

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    } else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    } else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    } else
    {
        Console.WriteLine(i);
    }
}