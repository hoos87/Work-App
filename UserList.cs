using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_static
{
    public class UserList
    {
        // properties

        // list of overall TC users
        public List<UserList> myList = new List<UserList>();
        // list of Rota allocated TC users 
        public List<UserList> myRota = new List<UserList>();


        private string _name { get; set; }
        public string _lastName { get; set; }
        public string _email { get; set; }
        public string _supervisor { get; set; }
        private bool _beenOnRota { get; set; }

        // constructor (parameter) (used when creating a new user)
        public UserList(string name, string lastName, string emailAddress, string supervisor)
        {
            _name = name;
            _lastName = lastName;
            _email = emailAddress;
            _supervisor = supervisor;
            _beenOnRota = false;
        }
        // constructor (parameterless) (default state of a new user)
        public UserList()
        {
            _name = "unknown";
            _lastName = "unknown";
            _email = "unknown";
            _supervisor = "unknown";
            _beenOnRota = false;

        }

        // setters and getters
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string EmailAddress
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Supervisor
        {
            get { return _supervisor; }
            set { _supervisor = value; }
        }
        // a check used to determine rota eligibility 
        public bool BeenOnRota
        {
            get { return _beenOnRota; }
            set { _beenOnRota = value; }
        }



        // Methods

        // this method calls other methods to collect all the data to generate a new user profile
        public void AddUser()
        {

            string firstName = UserFirstName();
            string lastName = UserLastName();
            string emailAddress = UserEmailAddress();
            string supervisor = UserSupervisor();
            Console.WriteLine("User summary:");
            Console.WriteLine("-------------");
            Console.WriteLine($"First name: {firstName}.");
            Console.WriteLine($"Last name: {lastName}.");
            Console.WriteLine($"Email address: {emailAddress}");
            Console.WriteLine($"Supervisor: {supervisor}");
            Console.WriteLine('\n');
            while (true)
            {
                Console.WriteLine("Type 'ok' to return to the Main Menu");
                string continueCommand = Console.ReadLine();
                if (continueCommand == "ok" || continueCommand == "Ok" || continueCommand == "OK")
                {
                    UserList newProfile = new UserList(firstName, lastName, emailAddress, supervisor);
                    myList.Add(newProfile);
                    Console.Clear();
                    break;
                }
                else
                    Console.WriteLine("Please type 'OK' to continue");
            }
        }

        // Collects first name of user - works with AddUser method
        public string UserFirstName()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please enter the first name of the User");
                string? firstName = Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"You entered {firstName}, is this correct? Y/N?");
                string? firstConfirm = Console.ReadLine();
                Console.Clear();

                if (firstConfirm == "Y" || firstConfirm == "y")
                {
                    Console.WriteLine($"You have added {firstName} as the first name");
                    Console.Clear();
                    return firstName;
                }
                else if (firstConfirm == "N" || firstConfirm == "n")
                {
                    continue;
                }
                else
                    Console.WriteLine("Please enter the first name of the User");
            }
        }

        // Collects last name of user - works with AddUser method
        public string UserLastName()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please enter the last name of the User");
                string? lastName = Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"You entered {lastName}, is this correct? Y/N?");
                string? lastConfirm = Console.ReadLine();
                Console.Clear();
                if (lastConfirm == "Y" || lastConfirm == "y")
                {
                    Console.WriteLine($"you have added {lastName} as the last name");
                    Console.Clear();
                    return lastName;
                }
                else if (lastConfirm == "N" || lastConfirm == "n")
                {
                    continue;
                }
                else
                    Console.WriteLine("Please enter the last name of the User");
            }
        }

        // Collects email of user - works with AddUser method
        public string UserEmailAddress()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please enter the email address of the User (all in lowercase)");
                string? userEmailAddress = Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"You entered {userEmailAddress}, is this correct? Y/N?");
                string? emailConfirm = Console.ReadLine();
                Console.Clear();
                if (emailConfirm == "Y" || emailConfirm == "y")
                {
                    Console.WriteLine($"you have added {userEmailAddress} as the email address");
                    Console.Clear();
                    return userEmailAddress;
                }
                else if (emailConfirm == "N" || emailConfirm == "n")
                {
                    continue;
                }
                else
                    Console.WriteLine("Please enter the email address of the User");
            }
        }

        // Collects supervisor name of user - works with AddUser method
        public string UserSupervisor()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please enter the name of the user's supervisor");
                string? supervisorName = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"You entered {supervisorName}, is this correct? Y/N?");
                string? supervisorConfirm = Console.ReadLine();
                Console.Clear();
                if (supervisorConfirm == "Y" || supervisorConfirm == "y")
                {
                    Console.WriteLine($"You have added {supervisorName} as the supervisor");
                    Console.Clear();
                    return supervisorName;
                }
                else if (supervisorConfirm == "N" || supervisorConfirm == "n")
                {
                    continue;
                }
                else
                    Console.WriteLine("Please enter the name of the user's supervisor");
            }
        }

        // method for editing exisiting users in the TC List
        public void EditUser()
        {
            while (true)
            {
                // always displays list of users so you can
                // easily refer to it when making edits
                Console.WriteLine("Displaying current TC user list");
                for (int i = 0; i < myList.Count; i++)
                {
                    // +1 to account for 0 indexing and makes
                    // it easier for user to select an entry
                    Console.WriteLine($"{i + 1}: {myList[i].Name}");
                }

                // first we select the entry we want to edit
                Console.WriteLine("Please select the number of the entry you wish to edit");
                int userSelection = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You wish to alter entry {userSelection} Y/N?");
                string userConfirm = Console.ReadLine();
                // now we can choose what part of the user profile to edit
                if (userConfirm == "y" || userConfirm == "Y")
                {
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1: Edit first name");
                    Console.WriteLine("2: Edit last name");
                    Console.WriteLine("3: Edit email address");
                    Console.WriteLine("4: Edit supervisor");
                    Console.WriteLine("5: Edit if user has been on rota already");
                    Console.WriteLine("6: Delete entry");
                    int switchSelection = Convert.ToInt32(Console.ReadLine());

                    switch (switchSelection)
                    {
                        case 1:
                            {
                                Console.WriteLine("Please enter the first name you wish to replace the old one with");
                                string? newName = Console.ReadLine();
                                myList[userSelection - 1].Name = newName;
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Please enter the new last name you wish to replace the old one with");
                                string? newLastName = Console.ReadLine();
                                myList[userSelection - 1].LastName = newLastName;
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Please enter the new email you wish to replace the old one with");
                                string? newEmail = Console.ReadLine();
                                myList[userSelection - 1].EmailAddress = newEmail;
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Please enter the new supervisor's name you wish to replace the old one with");
                                string? newSupervisor = Console.ReadLine();
                                myList[userSelection - 1].Supervisor = newSupervisor;
                            }
                            break;
                        case 5:
                            {
                                RotaChecker(userSelection);
                                
                                while(true)
                                {
                                    Console.WriteLine("Do you want to alter the user's Rota status? Y/N?");
                                    string? userAnswer = Console.ReadLine();
                                    if (userAnswer == "Y" || userAnswer == "y")
                                    {
                                        Console.WriteLine("1: remove rota status on user");
                                        Console.WriteLine("2: add rota status to user");
                                        int selection = Convert.ToInt32(Console.ReadLine());
                                        switch (selection)
                                        {
                                            case 1:
                                                {
                                                    myList[userSelection - 1].BeenOnRota = false;
                                                }
                                                break;
                                            case 2:
                                                {
                                                    myList[userSelection - 1].BeenOnRota = true;
                                                }
                                                break;
                                        }
                                        break;


                                    }
                                    if (userAnswer == "N" || userAnswer == "n")
                                    {
                                        break;
                                    }
                                    else
                                        Console.WriteLine("Please input Y or N to answer the question");
                                }
                            }
                            break;
                        case 6:
                            {
                                Console.WriteLine($"Delete the following user: {myList[userSelection - 1].Name} Y/N?");
                                string? deleteAnswer = Console.ReadLine();
                                if (deleteAnswer == "y" || deleteAnswer == "Y")
                                {
                                    myList.RemoveAt(userSelection - 1);
                                    myList.Sort();
                                }
                                if (deleteAnswer == "N" || deleteAnswer == "N")
                                {
                                    continue;
                                }
                            }
                            break;
                    }

                }
                if (userConfirm == "N" || userConfirm == "n")
                {
                    continue;
                }
                else
                    Console.WriteLine("Please type Y or N for your answer");
            }
        }

        public void RotaChecker(int userSelection)
        {
            Console.WriteLine("Has this user been on Rota last week?");
            if (myList[userSelection - 1].BeenOnRota == true)
                Console.WriteLine("Yes");
            if (myList[userSelection - 1].BeenOnRota == false)
                Console.WriteLine("No");
        }

        // shows a list of users first names that are in the USERLIST (Not on the current rota)
        public void ViewUserList()
        {
            Console.WriteLine("Displaying users in the TC user list:");
            for (int i = 0; i < myList.Count; i++)
            {
                // would like to include both first and last name incase users share same first name
                Console.WriteLine($"{myList[i].Name} {myList[i].LastName}");
            }
        }

        // list contents checker method, if list is empty it will notify operator
        public void GenerateRotaList()
        {
            bool isEmpty = !myList.Any();
            if (isEmpty)
            {
                Console.WriteLine("A rota list cannot be generated..");
                Console.WriteLine("Please make sure you have added " +
                "users to the userlist before generating a rota list!");
            }
            else
            {
                myRota.Clear();
                Console.WriteLine("Generating rota list...");
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i].BeenOnRota == false)
                    {
                        myRota.Add(myList[i]);
                        myList[i].BeenOnRota = true;
                    }
                }
            }
        }

        public void ViewRotaList()
        {
            for (int i = 0; i < myRota.Count; i++)
            {
                Console.WriteLine($"{myRota[i].Name} {myRota[i].LastName}");
            }
        }

        
    }
}
