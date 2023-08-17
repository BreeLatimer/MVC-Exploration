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
    class Controller
    {
        // The Controller class has a reference to both the View and the Model
        private View view;
        private Model model;

        // Constructor
        public Controller(View view, Model model)
        {
            this.view = view;
            this.model = model;
        }

        // This method is called when the user selects the "Add Student" option from the menu
        public void AddStudent()
        {
            // Get the student's name from the user
            string name = view.GetStudentName();

            // Create a new student object
            Student student = new Student(name);

            // Add the student to the model
            model.AddStudent(student);

            // Display the student roster
            view.DisplayRoster(model.GetRoster());
        }

        // This method is called when the user selects the "Remove Student" option from the menu
        public void RemoveStudent()
        {
            if(model.GetRoster().Count == 0)
            {
                Console.WriteLine("There are no students to remove.\n");
                return;
            }

            // Get the student's name from the user
            string name = view.GetStudentName();

            // Remove the student from the model
            model.RemoveStudent(name);

            // Display the student roster
            view.DisplayRoster(model.GetRoster());
        }

        public void Start()
        {
            while(true) {
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
                        RemoveStudent();
                        break;
                    case 3:
                        DisplayStudens();
                        break;
                    case 4:
                        Exit();
                        break;
                }
            } 
        }

        // This method is called when the user selects the "Display Students" option from the menu
        public void DisplayStudens()
        {
            // Display the student roster
            view.DisplayRoster(model.GetRoster());
        }

        // This method is called when the user selects the "Exit" option from the menu
        public void Exit()
        {
            // Exit the application
            Environment.Exit(0);
        }
    }
}   