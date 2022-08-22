/*
 * This program is thinked in order to make the reservation of a restaurant.
 * 
 * 1. Validate if the user exist, if not exits, the user must be register, and generate a login system for the users.
 * 2. The program must welcome to a register user
 * 3. The program must be repeated until 10 person is registered. 
 */

// An array to save the users registered
string[] userNames = new string[10] { "Mike", "", "", "", "", "", "", "", "", "" };

bool userType;

Console.WriteLine("Welcome to the best restaurant in Earth!!");
//
while (true)
{
    Console.WriteLine("Are you a registered User? Write true, if you are registered, or false, in the case if not.");
    userType = Convert.ToBoolean(Console.ReadLine());

    if (userType == true)
    {
        Console.WriteLine("Hello, you're a registered user, please enter your exact user name");
        string userToSearch = Console.ReadLine();
        Console.WriteLine("The user you searched is {0}", userToSearch);
    }
}