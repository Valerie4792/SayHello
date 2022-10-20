//Valerie Aguilar
//10/19/22

//-------------Mini Challenge # 1 - Say Hello------------//

// Directions: Create a brand new console project where you are asked your name.
// You will then print out the following "Hello <name entered>"
// name entered should be the variable that the user types in.

//Description: 
//identified data type, string, and assigned a variable without a value
//Output "What is your name?"
//assigned the variable name a value of User input
//Have the output display "Hello" with the variable name, which is now assigned a value of user input

String name;


string playAgain = "Y";

    while (playAgain == "Y")
    {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine($"Hello {name}! :)");
        Console.WriteLine("Would you like to play again? If so type Y, if not, type N");
        playAgain = Console.ReadLine().ToUpper();
    }

    Console.WriteLine("Thank you for playing.");

