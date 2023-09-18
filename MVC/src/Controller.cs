// Author: Bree Latimer
// Date: 8/17/2023
// Description: This file contains the Controller class for the MVC application.
//              The Controller class handles user input and updates the View and Model as needed.
//              The Controller class is the only class that interacts with both the View and the Model.
//
// This project is meant to demonstrate the MVC design pattern and prove that I understand how it works.
// The project is a simple class roster application that allows the user to add and remove students from a class roster.

namespace MVC
{
    /// <summary>
    /// Class <c>Controller</c> is the Controller class for the MVC application. Handles user input and updates the View and Model as needed.
    /// </summary>
    public class Controller
    {
        // The Controller class has a reference to both the View and the Model
        private View view;
        private Model model;

        /// <summary>
        /// Method <c>Controller</c> is the constructor for the Controller class.
        /// </summary>
        /// <param name="view">View object to be used to display/receive information to/from the user.</param>
        /// <param name="model">Model object to used to manipulate data.</param>
        public Controller(View view, Model model)
        {
            this.view = view;
            this.model = model;
        }

        /// <summary>
        /// Method <c>Start</c> is the entry point for the application. This method begins the main application loop.
        /// </summary>
        public void Start()
        {
            // Welcome the user
            view.DisplayGreeting();

            while (true)
            {
                // Display the main menu
                view.DisplayMenu();

                // Get the user's menu selection
                int selection = view.GetMenuSelection();

                // Handle the user's menu selection
                switch (selection)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewStudent();
                        break;
                    case 3:
                        RemoveStudent();
                        break;
                    case 4:
                        ViewRoster();
                        break;
                    case 5:
                        Exit();
                        break;
                }
            }
        }

        /// <summary>
        /// Method <c>AddStudent</c> is called when the user selects the "Add Student" option from the menu.
        /// </summary>
        public void AddStudent()
        {
            // Get the student's name from the user
            string name = view.GetStudentName();

            string gpa = view.GetStudentGPA();

            string major = view.GetStudentMajor();

            string extraCurricular = view.GetStudentEC();

            // Create a new student object
            Student student = new Student(name, gpa, major, extraCurricular);

            // Add the student to the model
            model.AddStudent(student);

            // Display the student roster
            view.DisplayRoster(model.GetRoster());
        }

        /// <summary>
        /// Method <c>ViewStudent</c> is called when the user selects the "View Student" option from the menu.
        /// </summary>
        public void ViewStudent()
        {
            if (model.IsRosterEmpty())
            {
                view.DisplayNoStudentsInRoster();
            } else
            {
                string studentName = view.GetStudentName();

                if (model.IsRosterEmpty())
                {
                    view.DisplayNoStudentsInRoster();
                    return;
                }

                Student? student = model.FindStudentInRoster(studentName);

                if (student != null)
                {
                    view.DisplayStudent(student);
                } else
                {
                    view.DisplayStudentNotFound();
                }
            }
        }

        /// <summary>
        /// Method <c>RemoveStudent</c> is called when the user selects the "Remove Student" option from the menu.
        /// </summary>
        public void RemoveStudent()
        {
            if(model.GetRoster().Count == 0)
            {
                view.DisplayNoStudentsInRoster();
                return;
            }

            // Get the student's name from the user
            string name = view.GetStudentName();

            // Remove the student from the model
            bool studentRemoved = model.RemoveStudent(name);

            if(!studentRemoved)
            {
                view.DisplayStudentNotFound();
                return;
            }

            // Display the student roster
            view.DisplayRoster(model.GetRoster());
        }

        /// <summary>
        /// Method <c>ViewRoster</c> is called when the user selects the "View Roster" option from the menu.
        /// </summary>
        public void ViewRoster()
        {
            if(model.IsRosterEmpty())
            {
                view.DisplayNoStudentsInRoster();
                return;
            } else
            {
                // Display the student roster
                view.DisplayRoster(model.GetRoster());
            }
        }

        /// <summary>
        /// Method <c>Exit</c> is called when the user selects the "Exit" option from the menu.
        /// </summary>
        public void Exit()
        {
            // Bid the user farewell
            view.DisplayGoodbye();

            // Exit the application
            Environment.Exit(0);
        }
    }
}   