// Author: Bree Latimer
// Date: 8/17/2023
// Description: This file contains the Model class for the MVC application.
//              The Model class contains the data and business logic for the application.
//              The Model class is the only class that interacts with the data.

namespace MVC
{
    /// <summary>
    /// Class <c>Model</c> is the Model class for the MVC application. Handles the data and business logic for the application.
    /// </summary>
    class Model
    {
        // The Model class has a reference to the View
        private View view;

        // The Model class contains the data for the application
        private List<Student> roster;

        /// <summary>
        /// Method <c>Model</c> is the constructor for the Model class.
        /// </summary>
        /// <param name="view">View object to be used by the model.</param>
        public Model(View view)
        {
            this.view = view;
            roster = new List<Student>();
        }

        /// <summary>
        /// Method <c>AddStudent</c> adds a student to the roster.
        /// </summary>
        /// <param name="student">Student object to be added to the roster.</param>
        public void AddStudent(Student student)
        {
            roster.Add(student);
        }

        /// <summary>
        /// Method <c>RemoveStudent</c> removes a student from the roster.
        /// </summary>
        /// <param name="name">String representation of the name of the student to be removed from the roster.</param>
        public void RemoveStudent(string name)
        {
            Student? student = FindStudentInRoster(name);

            if (student != null)
            {
                roster.Remove(student);
            }
        }

        /// <summary>
        /// Method <c>GetRoster</c> returns the roster.
        /// </summary>
        /// <returns>A List of Student objects.</returns>
        public List<Student> GetRoster()
        {
            return roster;
        }

        /// <summary>
        /// Method <c>ViewStudent</c> displays a student's information.
        /// </summary>
        /// <param name="name">String representation of the name of the student whose information should be displayed.</param>
        public void ViewStudent(string name)
        {
            if (IsRosterEmpty())
            {
                view.DisplayNoStudentsInRoster();
                return;
            }

            // Look up the student in the roster
            Student? student = FindStudentInRoster(name);

            // If the student was found, display the student's information
            if (student != null)
            {
                view.DisplayStudent(student);
            }
        }

        /// <summary>
        /// Method <c>FindStudentInRoster</c> finds a student in the roster.
        /// </summary>
        /// <param name="name">String representation of the student's name to be found in the roster.</param>
        /// <returns>A Student object whose name property matches the given string.</returns>
        private Student? FindStudentInRoster(string name)
        {
            if (IsRosterEmpty())
            {
                view.DisplayNoStudentsInRoster();
                return null;
            }

            // Find the student in the roster
            Student student = roster.Find(s => s.Name == name)!;

            if (student == null)
            {
                view.DisplayStudentNotFound();
                return null;
            }

            return student;
        }

        /// <summary>
        /// Method <c>CheckRoster</c> checks if the roster is empty.
        /// </summary>
        public bool IsRosterEmpty()
        {
            if (roster.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}