namespace Classes_and_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an instance of the a class that contains a list that I want to use in my program
            UserList users = new UserList(); // simplified creation


            // checks list to see if it contains any elements, useful for rota generation
            bool isEmpty = !users.myList.Any();

            // main interface to operate the app and to return to once tasks are complete.
            while (true)
            {
                Console.WriteLine("---------- // MAIN MENU \\ ----------");
                Console.WriteLine("Please input a number to make a selection from the menu");
                Console.WriteLine("\n");
                Console.WriteLine("1: Add user to TC User list");
                Console.WriteLine("2: Edit user from TC User list");
                Console.WriteLine("3: View TC User list");
                Console.WriteLine("4: Generate rota list");
                Console.WriteLine("5: View generated Rota list");
                Console.WriteLine('\n');

                string userMenuInput = Console.ReadLine();
                Console.Clear();

                /*
                if (userMenuInput != "1" || 
                    userMenuInput != "2" || 
                    userMenuInput != "3" || 
                    userMenuInput != "4" || 
                    userMenuInput != "5")
                {
                    Console.WriteLine("Please enter a valid input between 1 and 5 \n");

                    continue;
                }
                */
                int choice = Convert.ToInt32(userMenuInput);

                switch (choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Adding User:");
                            users.AddUser();
                        }
                    break;
                    case 2:
                        {
                            users.EditUser();
                        }
                    break;
                    case 3:
                        {
                            Console.WriteLine("Viewing list...");
                            users.ViewUserList();
                        }
                    break;
                    case 4:
                        {
                            Console.WriteLine("Checking if a rota can be generated...");
                            users.GenerateRotaList();
                        }
                        break;
                    case 5:
                        {
                            users.ViewRotaList();
                        }
                        break;
                }
            }
        }
    }
}