// Author: Bree Latimer
// Date: 8/17/2023
// Description: This file contains the Student class for the MVC application.
//              The Student class represents a student in the class roster.
//              The Student class is a simple data class.

namespace MVC
{
    class Student
    {
        // The Student class has a name property
        public string Name { get; set; }

        // Constructor
        public Student(string name)
        {
            Name = name;
        }
    }
}