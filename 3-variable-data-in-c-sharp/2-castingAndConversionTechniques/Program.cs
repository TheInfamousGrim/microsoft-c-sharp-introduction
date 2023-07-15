// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

/* --------------------------------- divider -------------------------------- */
// Question: Is it possible that attempting to change the value's data type would result in a loss of information?
/* --------------------------------- divider -------------------------------- */

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

/* ----------------------------- Perform a Cast ----------------------------- */

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

/* --------------------------------- divider -------------------------------- */
// Determine if your conversion is a "widening conversion" or a "narrowing conversion"
/* --------------------------------- divider -------------------------------- */

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"decimal: {myDecimal}");
// Console.WriteLine($"float: {myFloat}");

/* -------------------------------------------------------------------------- */
/*                         Performing Data Conversions                        */
/* -------------------------------------------------------------------------- */

/* ---------- Use ToString() to convert a numeric value to a string --------- */

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

/* -------------------------------------------------------------------------- */
/*         Convert a string to an int using the Parse() helper method         */
/* -------------------------------------------------------------------------- */

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

/* -------------------------------------------------------------------------- */
/*              Convert a string to a int using the Convert class             */
/* -------------------------------------------------------------------------- */

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// So, when should you use the Convert class? The Convert class is best for converting fractional numbers into whole numbers (int) because it rounds up the way you would expect.

/* -------------------------------------------------------------------------- */
/*            Compare casting and converting a decimal into an int            */
/* -------------------------------------------------------------------------- */

// casting truncates
// int value = (int)1.5m; 
// Console.WriteLine(value);

// converting rounds up
// int value2 = Convert.ToInt32(1.5m); 
// Console.WriteLine(value2);

/* -------------------------------------------------------------------------- */
/*                               Use TryParse()                               */
/* -------------------------------------------------------------------------- */

// string name = "Bob";
// throws an exception
// Console.WriteLint(int.Parse(name)); 

/* --------------------- TryParse() a string into an int -------------------- */

// string value = "bad";
// int result = 0;

// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// if (result > 0)
// {
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");
// }

/* -------------------------------------------------------------------------- */
/*                              Code Challenge 1                              */
/* -------------------------------------------------------------------------- */

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// 1. Create a looping structure that can be used to iterate through each string value in the array values.

// 2. Complete the required code, placing it within the array looping structure code block. It's necessary to implement the following business rules in your code logic:

    // - Rule 1: If the value is alphanumeric, concatenate it to form a message.

    // - Rule 2: If the value is numeric, add it to the total.

    // - Rule 3: The result should match the following output:

// decimal total = 0m;
// string message = string.Empty;

// foreach (string value in values)
// {
//     if (decimal.TryParse(value, out decimal number))
//     {
//         total += number;
//     }
//     else
//     {
//         message += value;
//     }

// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

/* -------------------------------------------------------------------------- */
/*                              Code Challenge 2                              */
/* -------------------------------------------------------------------------- */

// 1. Replace the code comments in the starter code with your own code to solve the challenge.
    // - Solve for result1: Divide value1 by value2, display the result as an int.
    // - Solve for result2: Divide value2 by value3, display the result as a decimal.
    // - Solve for result3: Divide value3 by value1, display the result as a float.

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");