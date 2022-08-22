/*
 * This program is thinked in order to make the reservation of a restaurant.
 * 
 * 1. Validate if the user exist, if not exits, the user must be register, and generate a login system for the users.
 * 2. The program must welcome to a register user
 * 3. The program must be repeated until 10 person is registered. 
 */

// An array to save the users registered
string[] userNames = new string[10];
// The current index of user array
int currentIndex = 0;
// validation variable of an existing user.
bool userType;

Console.WriteLine("Welcome to the best restaurant in Earth!!");
//The register cicle until ten users are registered.
while (currentIndex < 10)
{
    //ask if an user is registered
    Console.WriteLine("\nAre you a registered User? Write true, if you are registered, or false, in the case if not.");
    userType = Convert.ToBoolean(Console.ReadLine());

    if (userType == true)
    {
        //ask the name of the user registered
        Console.WriteLine("\nHello, you're a registered user, please enter your exact user name");
        string userToSearch = Console.ReadLine();

        //search by user registered
        Console.WriteLine("\nThe user you searched is {0}", userToSearch);
        int index = Array.IndexOf(userNames, userToSearch);
        //validate the user existence
        if (index == -1)
        {
            Console.WriteLine("\nUser not found, try again or register");
        }
        else
        {
            Console.WriteLine("\nWelcome {0}, it's a pleasure to give you food", userNames[index]);
        }
    }
    else if (userType == false)
    {
        //Register a new user
        Console.WriteLine("Please write and remember your User Name");
        userNames[currentIndex] = Console.ReadLine();
       
        Console.WriteLine("Your user has been saved successfully\n" + 
            "Your User Name is {0}", userNames[currentIndex]);
        currentIndex++;
    }
}
//Show all the users that are registered for the dinner.
Console.WriteLine("The restaurant is full, try again next week. \nThese are the guests to the dinner: ");
int auxIndex = 0;
foreach (string element in userNames)
{
    Console.WriteLine("User number: {0} and User name: {1}", auxIndex+1, userNames[auxIndex]);
    auxIndex++;
}
Environment.Exit(0);