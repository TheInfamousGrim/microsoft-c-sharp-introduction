// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

/* --------------------------- Formatting currency -------------------------- */

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

/* --------------------------- Formatting Numbers --------------------------- */

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");

/* ------------------------- Formatting percentages ------------------------- */

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

/* --------------------- Combining formatting approaches -------------------- */

// decimal price2 = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = $"You saved {price2 - salePrice:C} off the regular {price2:C} price. A discount of {((price2 - salePrice) / price2):P2}!";
// Console.WriteLine(yourDiscount);

/* -------------------------------------------------------------------------- */
/*                        Explore String Interpolation                        */
/* -------------------------------------------------------------------------- */

/* ---------- Display the invoice number using string interpolation --------- */

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");

// Display the product shares with one thousandth of a share (0.001) precision

// Console.WriteLine($"Shares: {productShares:N3} Product");
// Display the subtotal that you charge the customer formatted as currency

// Console.WriteLine($"Subtotal: {subtotal:C}");

// Display the tax charged on the sale formatted as a percentage

// Console.WriteLine($"Tax: {taxPercentage:P2}");

// Finalize the receipt with the total amount due formatted as currency

// Console.WriteLine($"Total: {total:C}");

/* -------------------------------------------------------------------------- */
/*                  Exercise - Discover padding and alignment                 */
/* -------------------------------------------------------------------------- */

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12).Length);
// Console.WriteLine(input.PadLeft(input.Length + 4).Length);

// Console.WriteLine(input.PadLeft(input.Length + 4, '-'));
// Console.WriteLine(input.PadRight(input.Length + 4, '-'));

/* ----------------------- Working with padded strings ---------------------- */

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string payeeAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(paymentId.Length + 3);
// formattedLine += payeeName.PadRight(payeeName.Length + 3);
// formattedLine += payeeAmount.PadLeft(payeeAmount.Length + 3);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);
// Console.WriteLine("Learning C#".Length);

/* -------------------------------------------------------------------------- */
/*                              Code Challenge 1                              */
/* -------------------------------------------------------------------------- */

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");

Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");

Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");

Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}. Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
// First Line
comparisonMessage += $"{currentProduct.PadRight(currentProduct.Length + 7)}";
comparisonMessage += $"{currentReturn:P}".PadRight($"{currentReturn:P}".Length + 3);
comparisonMessage += $"{currentProfit:C}\n";

// Second Line
comparisonMessage += $"{newProduct.PadRight(newProduct.Length + 3)}";
comparisonMessage += $"{newReturn:P}".PadRight($"{newReturn:P}".Length + 3);
comparisonMessage += $"{newProfit:C}\n";

Console.WriteLine(comparisonMessage);