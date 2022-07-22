
// Declared 

StudentRota newUser = new StudentRota;

UserMenu.UserMenuSelection();















public static class UserMenu
{
    
   
    public static void UserMenuSelection()
    {
        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - Add new user to Roster");
            Console.WriteLine("2 - Roster preview");

            int userSelection = Convert.ToInt32(Console.ReadLine());

            // selection executes various methods to carry out what you need to do
            switch (userSelection)
            {
                case 1:
                    newUser.userEntry();
                    break;
                case 2:
                    Roster.PreviewRoster();
                    break;

            }

            break;
        }
    }


}


// **CLASSES** \\
public class StudentRota
{
    // properties (auto)
    private string _firstName { get; set; }
    private string _lastName { get; set; }
    private string _supervisor { get; set; }
    private string _emailAddress { get; set; }
    private UserClass _currentClass { get; set; }
    private UserStatus _currentStatus { get; set; }

    // constructors (parameterless)
    public StudentRota()
    {
        _firstName = "Unknown";
        _lastName = "Unknown";
        _supervisor = "Unknown";
        _emailAddress = "Unknown";
        _currentClass = UserClass.TBD;
        _currentStatus = UserStatus.Pending;
    }
    // constructors (parameters)
    public StudentRota(string firstName, string lastName, string supervisor, string emailAddress, UserClass currentClass, UserStatus currentStatus)
    {
        _firstName = firstName;
        _lastName = lastName;
        _supervisor = supervisor;
        _emailAddress = emailAddress;
        _currentClass = currentClass;
        _currentStatus = currentStatus;
    }

    // **METHODS** \\



    // method for initial entry of users before adding to database / rota 
    public void userEntry()
    {
        UserClass userClass;
        UserStatus userStatus;

        Console.WriteLine("Please enter the user's first name");
        string? userFirstName = Console.ReadLine();

        Console.WriteLine("Please enter the user's last name");
        string? userLastName = Console.ReadLine();

        Console.WriteLine("Please enter the user's supervisor");
        string? userSupervisor = Console.ReadLine();

        Console.WriteLine("Please enter the user's email");
        string? userEmail = Console.ReadLine();

        Console.WriteLine("Select the user's Class from the following list");
        Console.WriteLine("1 - PhD student");
        Console.WriteLine("2 - MSc student");
        Console.WriteLine("3 - Academic");
        Console.WriteLine("4 - Technical staff");
        Console.WriteLine("5 - Research staff");
        int userInputClass = Convert.ToInt32(Console.ReadLine());

        userClass = userInputClass switch
        {
            1 => UserClass.PhD,
            2 => UserClass.MSc,
            3 => UserClass.Academic,
            4 => UserClass.TechnicalStaff,
            5 => UserClass.ResearchStaff,
        };

        Console.WriteLine("Select the current status of this user from the following list");
        Console.WriteLine("1 - Active");
        Console.WriteLine("2 - Inactive");
        Console.WriteLine("3 - Pending");
        int userInputStatus = Convert.ToInt32(Console.ReadLine());

        userStatus = userInputStatus switch
        {
            1 => UserStatus.Active,
            2 => UserStatus.Inactive,
            3 => UserStatus.Pending,
        };

        Roster.RosterGeneration(userFirstName, userLastName, userSupervisor, userEmail, userClass, userStatus);
        UserMenu.UserMenuSelection();

    }
}


public static class Roster
{
    // properties (auto)
    public static int currentNo { get; set; } = 0;

    // declaring and creating the list
    public static List<StudentRota> mainRoster = new List<StudentRota>();
    

    // **Methods** \\

    public static void RosterGeneration(string firstName, string lastName, string pI,
        string email, UserClass userClass, UserStatus userStatus)
    {

        int currentUserNo = 0;

        StudentRota newUser = new StudentRota(firstName, lastName, pI,
           email, userClass, userStatus);

        Roster.mainRoster.Add(newUser);
    }

    public static void PreviewRoster()
    {

        for (int index = 0; index < Roster.mainRoster.Count; index++)
        {
           Console.WriteLine(mainRoster[index]);
        }

    }


}


public enum UserClass { PhD, MSc, Academic, TechnicalStaff, ResearchStaff, TBD }
public enum UserStatus { Active, Pending, Inactive }