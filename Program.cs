// Jasmine Leek
// 20 oct 2022
// Mini-Challenge #9 "Restaurant Picker"
// This is a program that asks the user to pick a type of cuisine, then prints a restaurant suggestion

Console.Clear();

int cuisine = 0;
int num = 0;
string userChoice = "";
string userChose = "";
string loop = "";
bool option = false;
bool playAgain = true;
bool user = false;
Random rndmNum = new Random();
string[] seafoodBiz = {"Red Lobster", "Cocoro", "Ahipoki", "JJ's Fish & Chicken", "Ray's Chicken & Fish Mart", "Captain Crab", "Mikey's Tacos", "El Rancho", "Dynasty", "Long John Silver's" };
string[] pizzaBiz = {"Round Table", "Domino's", "Market Tavern", "Eric's Pizza", "David's Pizza", "Michael's Pizza", "Lovotti Pizza Pub", "Alfalfa's Pizza & Deli", "Little Caesars", "Mountain Mike's Pizza" };
string[] bakeryBiz = {"Trail Coffee", "Poppy Coffee", "M&W Dutch", "House of Shaw", "Magda's", "Panaderia Mejia", "Genova Bakery", "Toot Sweets", "La Boulangerie", "Boudin SF" };

while (playAgain == true)
{
    option = false;
    user = false;
    Console.WriteLine("Don't know what to eat? Let me help you decide!");

    while (user == false)
    {
        Console.WriteLine("First, select from these types of cuisine: 'seafood', 'pizza' or 'bakery'");
        userChoice = Console.ReadLine().ToLower();

        switch (userChoice)
        {
            case "seafood":
                user = true;
                cuisine = 1;
                break;

            case "pizza":
                user = true;
                cuisine = 2;
                break;

            case "bakery":
                user = true;
                cuisine = 3;
                break;
            default:
                Console.WriteLine("Whoops! Let's try this again.");
                break;
        }

    }

    num = rndmNum.Next(0, 9);
    
    switch (cuisine)
    {
        case 1:
            userChose = seafoodBiz[num];
            break;
        case 2:
            userChose = pizzaBiz[num];
            break;
        case 3:
            userChose = bakeryBiz[num];
            break;
        default:
            break;
    }

    Console.WriteLine($"You should go to: {userChose}");

    while (option == false)
    {
        Console.WriteLine("Play again? Type 'yes' to play again or 'no' to quit.");
        loop = Console.ReadLine().ToLower();
        switch (loop)
        {
            case "yes":
                option = true;
                break;
            case "no":
                option = true;
                playAgain = false;
                break;
            default:
                Console.WriteLine("Please type 'yes' or 'no' to continue.");
                break;
        }
    }
}