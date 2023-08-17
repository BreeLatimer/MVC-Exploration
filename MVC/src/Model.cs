// Author: Bree Latimer
// Date: 8/17/2023
// Description: This file contains the Model class for the MVC application.
//              The Model class contains the data and business logic for the application.
//              The Model class is the only class that interacts with the data.

namespace MVC
{
    class Model
    {
        // The Model class has a reference to the View
        private View view;

        // The Model class contains the data for the application
        private List<Student> roster;

        // Constructor
        public Model(View view)
        {
            this.view = view;
            roster = new List<Student>();
        }

        // This method adds a student to the roster
        public void AddStudent(Student student)
        {
            roster.Add(student);
        }

        // This method removes a student from the roster
        public void RemoveStudent(string name)
        {
            // Find the student in the roster
            Student student = roster.Find(s => s.Name == name);

            if(student == null)
            {
                Console.WriteLine("Student not found\n");
                return;
            }

            // Remove the student from the roster
            _ = roster.Remove(student);
        }

        // This method returns the roster
        public List<Student> GetRoster()
        {
            return roster;
        }
    }
}