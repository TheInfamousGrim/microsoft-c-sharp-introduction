// Random coin = new Random();
// int flip = coin.Next(0, 2);

// Console.WriteLine($"Coin flip: {(flip == 0 ? "heads" : "tails")}");

string permission = "Admin|Manager";
int level = 55;

Console.WriteLine(permission.Contains("Admin"));

if (permission.Contains("Admin")) {
    if (level > 55) {
        Console.WriteLine("Welcome, Super Admin user.");
    } else {
        Console.WriteLine("Welcome, Admin user.");
    }
} else if (permission.Contains("Manager")) {
    if (level > 20) {
        Console.WriteLine("Contact an Admin for access.");
    } else {
        Console.WriteLine("You do not have sufficient privileges");
    }
} else {
    Console.WriteLine("You do not have sufficient privileges");
}

// if (permission.Contains("Admin")) { 
//     level > 55 ? Console.WriteLine("Welcome, Super Admin user.") : Console.WriteLine("Welcome, Admin user.");
// } else if (permission.Contains("Manager")) {
//     level > 20 ? Console.WriteLine("Contact an Admin for access.") : Console.WriteLine("You do not have sufficient privileges");
// } else {
//     Console.WriteLine("You do not have sufficient privileges");
// }