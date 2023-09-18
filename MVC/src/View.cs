// Author: Bree Latimer
// Date: 8/17/2023
// Description: This file contains the View class for the MVC application.
//              The View class handles all user interaction and displays information to the user.
//              The View class is the only class that interacts with the user.

namespace MVC
{
    /// <summary>
    /// Class <c>View</c> handles all user interaction and displays information to the user.
    /// </summary>
    public class View
    {
        // The View class has a reference to the Controller
        private Controller? controller;

        // Constructor
        public View(Controller controller)
        {
            this.controller = controller;
        }

        // This constructor is only used when creating the View object in the Driver class
        public View()
        {
        }

        /// <summary>
        /// Method <c>DisplayGreeting</c> displays a greeting to the user.
        /// </summary>
        public void DisplayGreeting()
        {
            Console.WriteLine("Welcome to the Class Roster Application!\n");
        }

        /// <summary>
        /// Method <c>DisplayMenu</c> displays the menu to the user.
        /// </summary>
        public void DisplayMenu()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Student");
            Console.WriteLine("3. Remove Student");
            Console.WriteLine("4. View Roster");
            Console.WriteLine("5. Exit\n");
        }

        /// <summary>
        /// Method <c>GetMenuSelection</c> gets the user's menu selection.
        /// </summary>
        /// <returns>value of selected menu item</returns>
        public int GetMenuSelection()
        {
            // Get the user's input
            string input = Console.ReadLine()!;

            // Validate the input
            int selection;
            while (!int.TryParse(input, out selection) || selection < 1 || selection > 5)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.\n");
                input = Console.ReadLine()!;
            }

            // Return the user's selection
            return selection;
        }

        public string GetStudentName()
        {
            Console.WriteLine("Please enter the student's name:");
            return Console.ReadLine()!;
        }

        /// <summary>
        /// Method <c>GetStudentName</c> gets the student's name from the user.
        /// </summary>
        /// <returns>String representation of the name of the student as given by the user.</returns>
        public int GetStudentId()
        {
            Console.WriteLine("Please enter the student's name:");
            string stringId = Console.ReadLine()!;

            // parse int from stringId
            int id;
            while (!int.TryParse(stringId, out id))
            {
                Console.WriteLine("Invalid input. Please enter a number.\n");
                stringId = Console.ReadLine()!;
            }

            return id!;
        }

        /// <summary>
        /// Method <c>GetStudentGPA</c> gets the student's GPA from the user.
        /// </summary>
        /// <returns>String representation of the GPA of the student as given by the user.</returns>
        public string GetStudentGPA()
        {
            Console.WriteLine("Please enter the student's GPA:");
            return Console.ReadLine()!;
        }

        /// <summary>
        /// Method <c>GetStudentMajor</c> gets the student's major from the user.
        /// </summary>
        /// <returns>String representation of the student's major as given by the user.</returns>
        public string GetStudentMajor()
        {
            Console.WriteLine("Please enter the student's major:");
            return Console.ReadLine()!;
        }

        /// <summary>
        /// Method <c>GetStudentEC</c> gets the student's extra curricular activity from the user.
        /// </summary>
        /// <returns>String representation of the students extra curricular activity as given by the user.</returns>
        public string GetStudentEC()
        {
            Console.WriteLine("Please enter the student's extra curricular activity:");
            return Console.ReadLine()!;
        }

        /// <summary>
        /// Method <c>DisplayStudent</c>Displays the student's information to the user.
        /// </summary>
        /// <param name="student">Student object to be displayed.</param>
        public void DisplayStudent(Student student)
        {
            // Simply call the student's ToString() method
            Console.WriteLine(student.ToString());
        }

        /// <summary>
        /// Method <c>DisplayStudentAdded</c> displays the roster of students.
        /// </summary>
        /// <param name="roster">List of students to be displayed.</param>
        public void DisplayRoster(IEnumerable<Student> roster)
        {
            Console.WriteLine("\nClass Roster:");
            foreach (Student student in roster)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method <c>DisplayStudentAdded</c> displays a message to the user when a student could not be found in the roster.
        /// </summary>
        public void DisplayStudentNotFound()
        {
            Console.WriteLine("Student not found.\n");
        }

        /// <summary>
        /// Method <c>DisplayStudentAdded</c> displays a message to the user when the roster is empty.
        /// </summary>
        public void DisplayNoStudentsInRoster()
        {
            Console.WriteLine("There are no students in the roster.\n");
        }

        /// <summary>
        /// Method <c>DisplayStudentAdded</c> displays a goodbye message to the user.
        /// </summary>
        public void DisplayGoodbye()
        {
            Console.WriteLine("Thank you for using the Class Roster Application!");
        }
    }
}