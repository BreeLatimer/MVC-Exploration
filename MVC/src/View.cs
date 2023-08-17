// Author: Bree Latimer
// Date: 8/17/2023
// Description: This file contains the View class for the MVC application.
//              The View class handles all user interaction and displays information to the user.
//              The View class is the only class that interacts with the user.

namespace MVC
{
    class View
    {
        // The View class has a reference to the Controller
        private Controller controller;

        // Constructor
        public View(Controller controller)
        {
            this.controller = controller;
        }

        // This constructor is only used when creating the View object in the Driver class
        public View()
        {
        }

        // This method displays the main menu to the user
        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Class Roster Application!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Remove Student");
            Console.WriteLine("3. View Roster");
            Console.WriteLine("4. Exit\n");
        }

        // This method gets the user's menu selection
        public int GetMenuSelection()
        {
            // Get the user's input
            string input = Console.ReadLine();

            // Validate the input
            int selection;
            while (!int.TryParse(input, out selection) || selection < 1 || selection > 4)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.\n");
                input = Console.ReadLine();
            }

            // Return the user's selection
            return selection;
        }

        // This method gets the student's name from the user
        public string GetStudentName()
        {
            Console.WriteLine("Please enter the student's name:");
            return Console.ReadLine();
        }

        // This method displays the student roster to the user
        public void DisplayRoster(List<Student> roster)
        {
            Console.WriteLine("\nClass Roster:");
            foreach (Student student in roster)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();
        }

        // This method displays a goodbye message to the user
        public void DisplayGoodbye()
        {
            Console.WriteLine("Thank you for using the Class Roster Application!");
        }
    }
}