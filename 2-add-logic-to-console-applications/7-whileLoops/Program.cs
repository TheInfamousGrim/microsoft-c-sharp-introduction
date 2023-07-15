// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// do 
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

/* -------------------------------------------------------------------------- */
/*                     Role playing game battle challenge                     */
/* -------------------------------------------------------------------------- */

// 1. You must use either do-while statement or the while statement.
// 2. The hero and the monster will start with 10 health points.
// 3. All attacks will be a value between 1 and 10.
// 4. The hero will attack first.
// 5. Print the amount of health the monster lost and their remaining health.
// 6. If the monster's health is greater than 0, it can attack the hero.
// 7. Print the amount of health the hero lost and their remaining health.
// 8. Continue this until either the monster's health or the hero's health is zero or less.
// 9. Print the winner.

// int heroHealth = 10;
// int monsterHealth = 10;
// Random damage = new Random();
// Console.WriteLine("Welcome to the battle! The hero and the monster will start with 10 health points.");
// Console.WriteLine("");

// while (heroHealth > 0 || monsterHealth > 0)
// {
//     int heroAttack = damage.Next(1, 11);
//     int monsterAttack = damage.Next(1, 11);

//     Console.WriteLine($"The hero attacks the monster for {heroAttack} damage.");
//     monsterHealth -= heroAttack;
//     Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth}");
//     Console.WriteLine("");

//     if (monsterHealth <= 0)
//     {
//         Console.WriteLine("The monster has been defeated! The hero wins!");
//         break;
//     }

//     Console.WriteLine($"The monster attacks the hero for {monsterAttack} damage.");
//     heroHealth -= monsterAttack;
//     Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth}");
//     Console.WriteLine("");

//     if (heroHealth <= 0)
//     {
//         Console.WriteLine("The hero has been defeated! The monster wins!");
//         break;
//     }
// }

/* -------------------------------------------------------------------------- */
/*                   Write Code That Validates Integer Input                  */
/* -------------------------------------------------------------------------- */

// 1. Your solution must include either a do-while statement or a while statement.
// 2. Before the iteration block: your solution must use Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
// 3. Inside the iteration block:
    // a. Your solution must use the Console.ReadLine() method to read the user's input.
    // b. Your solution must ensure that the input is a valid representation of an integer value.
    // c. If the integer value is not between 5 and 10, your solution must use the Console.WriteLine() method to prompt the user for an integer value between 5 and 10.
    // d. Your solution must ensure that the integer value is between 5 and 10 before the iteration block ends.
// 4. After the iteration block: your solution must use the Console.WriteLine() method to display the integer value.

// int userInput;

// do
// {
//     Console.WriteLine("Please enter an integer value between 5 and 10");
//     userInput = Convert.ToInt32(Console.ReadLine());
// } while (userInput < 5 || userInput > 10);

/* -------------------------------------------------------------------------- */
/*                   Write Code That Validates String Input                   */
/* -------------------------------------------------------------------------- */

// 1. Your solution must include either a do-while statement or a while statement.
// 2. Before the iteration block: your solution must use Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.
// 3. Inside the iteration block:
    // a. Your solution must use the Console.ReadLine() method to read the user's input.
    // b. Your solution must ensure that the value entered matches one of the three role options.
    // c. Your solution should use the Trim() method on the input value to ignore leading and trailing white space.
    // d. Your solution should use the ToLower() method on the input value to ignore case.
    // e. If the value entered is not a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid input.

string userInput;

do
{
    Console.WriteLine("Please enter one of the following roles: Administrator, Manager, or User");
    userInput = Console.ReadLine().Trim().ToLower();
} while (userInput != "administrator" && userInput != "manager" && userInput != "user");

Console.WriteLine($"Your input value {userInput} has been accepted");