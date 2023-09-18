// Author: Bree Latimer
// Date: 8/17/2023
// Description: This file contains the Student class for the MVC application.
//              The Student class represents a student in the class roster.
//              The Student class is a simple data class.

namespace MVC
{
    /// <summary>
    /// Class <c>Student</c> represents a student in the class roster.
    /// </summary>
    public class Student
    {
        // Student properties
        public string Name { get; set; }
        public string GPA { get; set; }
        public string Major { get; set; }
        public string ExtraCurricular { get; set; }

        /// <summary>
        /// Method <c>Student</c> is the constructor for the Student class.
        /// </summary>
        /// <param name="name">String representation of the name of the student.</param>
        /// <param name="gpa">String representation of the GPA of the student.</param>
        /// <param name="major">String representation of the student's major.</param>
        /// <param name="extraCurricular">String representation of the student's extra curricular activity.</param>
        public Student(string name, string gpa, string major, string extraCurricular)
        {
            Name = name;
            GPA = gpa;
            Major = major;
            ExtraCurricular = extraCurricular;
        }

        /// <summary>
        /// Method <c>ToString</c> returns a string representation of the Student object.
        /// </summary>
        /// <returns>String representation of the student object including all details of all properties of the Student.</returns>
        public override string ToString()
        {
            string studentInfo = "\nStudent Information";
            studentInfo += "\nName: " + Name;
            studentInfo += "\nGPA: " + GPA;
            studentInfo += "\nMajor: " + Major;
            studentInfo += "\nExtra Curricular Activity: " + ExtraCurricular;
            studentInfo += "\n";

            return studentInfo;
        }
    }
}