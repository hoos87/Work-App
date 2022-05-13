
//placeholder for onRota array to later be repalced.
(string FirstName, string SecondName, StudentStatus) placeHolder = ("n/a", "n/a", StudentStatus.PreviouslyAssigned);

int incrementForRotaMethod = 0;



// Store these in another file that I can access (needs to be public right?)
(string FirstName, string SecondName, StudentStatus) user1 = ("Hussein", "Al-Obaidi", StudentStatus.Available);
(string FirstName, string SecondName, StudentStatus) user2 = ("Bob", "Jones", StudentStatus.Available);
(string FirstName, string SecondName, StudentStatus) user3 = ("Mary", "Frank", StudentStatus.Available);
(string FirstName, string SecondName, StudentStatus) user4 = ("Sonic", "Hedgehog", StudentStatus.Available);
(string FirstName, string SecondName, StudentStatus) user5 = ("Rachel", "Earl", StudentStatus.Available);
(string FirstName, string SecondName, StudentStatus) user6 = ("Maj", "Kenny", StudentStatus.Available);
(string FirstName, string SecondName, StudentStatus) user7 = ("Crax", "Crix", StudentStatus.Available);
(string FirstName, string SecondName, StudentStatus) user8 = ("Joe", "Imperial", StudentStatus.Available);
(string FirstName, string SecondName, StudentStatus) user9 = ("Kez", "Ingtton", StudentStatus.Available);
(string FirstName, string SecondName, StudentStatus) user10 = ("Kazuya", "Mishima", StudentStatus.Available);


// Would need to create a method here to alter the user1 information to be ready to be changed in the array

// This is how to access the studentstatus type in user1
// user1.Item3 = StudentStatus.PreviouslyAssigned;
// user1.Item3 = StudentStatus.Available;

// *IDEA* == Why not check through each user for correct parameters,
// the ones whose criteria match what we are looking for gets placed in to an array?

// onRota will be a list of users selected to be on this month's rota
Object[] onRota = new object[10];
onRota[0] = placeHolder;
onRota[1] = placeHolder;
onRota[2] = placeHolder;
onRota[3] = placeHolder;
onRota[4] = placeHolder;


// testing that the value for onRota can be overwritten later on
/*

Console.WriteLine(onRota[0]);
Console.WriteLine("\n");

onRota[0] = user1;

Console.WriteLine(onRota[0]);
Console.WriteLine("\n");

*/





// List of users that are currently using the cell culture facility
Object[] users = new object[11];
users[0] = user1;
users[1] = user2;
users[2] = user3;
users[3] = user4;
users[4] = user5;
users[5] = user6;
users[6] = user7;
users[7] = user8;
users[8] = user9;
users[9] = user10;


while (true)
{
    Console.WriteLine("Hello, what would you like to do?");
    Console.WriteLine("1: Generate a new monthly rota");
    Console.WriteLine("2: Display complete list of Cell Culture users");
    Console.WriteLine("3: Display list of current users on rota");
    int choice = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (choice)
    {

        case 1:
            Console.WriteLine("Generating a new monthly rota........");
            Console.WriteLine("\n");
            AllocateRota();
            break;
        case 2:
            
            Console.WriteLine("Here is a complete list of users for the Cell Culture Lab");
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------------------");
            DisplayCompleteUsers();
            Console.WriteLine("----------------------------------------------------");
            break;
        case 3:
            Console.WriteLine("Here is a list of the current rota and its users");
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------------------");
            DisplayCurrentRota();
            Console.WriteLine("----------------------------------------------------");
            break;
        default:
            Console.WriteLine("Please input your choice again");
            break;
           

    }
    
}

// Problem with this method. Need to address
void AllocateRota()
{
    while (true)
    {
        if (user1.Item3 == StudentStatus.Available && incrementForRotaMethod < 6)
        {
            onRota[incrementForRotaMethod++] = user1;
            user1.Item3 = StudentStatus.PreviouslyAssigned;
        }
        if (user2.Item3 == StudentStatus.Available && incrementForRotaMethod < 6)
        {
            onRota[incrementForRotaMethod++] = user2;
            user2.Item3 = StudentStatus.PreviouslyAssigned;
        }
        if (user3.Item3 == StudentStatus.Available && incrementForRotaMethod < 5)
        {
            onRota[incrementForRotaMethod++] = user3;
            user3.Item3 = StudentStatus.PreviouslyAssigned;
        }
        if (user4.Item3 == StudentStatus.Available && incrementForRotaMethod < 5)
        {
            onRota[incrementForRotaMethod++] = user4;
            user4.Item3 = StudentStatus.PreviouslyAssigned;
        }
        if (user5.Item3 == StudentStatus.Available && incrementForRotaMethod < 5)
        {
            onRota[incrementForRotaMethod++] = user5;
            user5.Item3 = StudentStatus.PreviouslyAssigned;
        }
        if (user6.Item3 == StudentStatus.Available && incrementForRotaMethod < 5)
        {
            onRota[incrementForRotaMethod++] = user6;
            user6.Item3 = StudentStatus.PreviouslyAssigned;
        }
        if (user7.Item3 == StudentStatus.Available && incrementForRotaMethod < 5)
        {
            onRota[incrementForRotaMethod++] = user7;
            user7.Item3 = StudentStatus.PreviouslyAssigned;
        }
        if (user8.Item3 == StudentStatus.Available && incrementForRotaMethod < 5)
        {
            onRota[incrementForRotaMethod++] = user8;
            user8.Item3 = StudentStatus.PreviouslyAssigned;
        }
        if (user9.Item3 == StudentStatus.Available && incrementForRotaMethod < 5)
        {
            onRota[incrementForRotaMethod++] = user9;
            user9.Item3 = StudentStatus.PreviouslyAssigned;
        }
        if (user10.Item3 == StudentStatus.Available && incrementForRotaMethod < 5)
        {
            onRota[incrementForRotaMethod++] = user10;
            user10.Item3 = StudentStatus.PreviouslyAssigned;
        }

        // important so that when the loop starts over it it set back to 0 and can correctly allocate
        incrementForRotaMethod = 0;
       
        // temporary break, need to find a way to loop
        break;
    }

}

// Switch for showing complete list of user
void DisplayCompleteUsers()
{
    for (int user = 0; user < users.Length; user++)
    {
        Console.WriteLine(users[user]);
    }
}

// Switch for showing complete list of user currently assigned to the this month's rota
void DisplayCurrentRota()
{
    for (int user = 0; user < onRota.Length; user++)
    {
        Console.WriteLine(onRota[user]);
    }
}


// Created an enum for the status of students, this will help determine who gets assigned each Month
enum StudentStatus { Available, PreviouslyAssigned }
