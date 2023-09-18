namespace MVC.Tests
{
    public class ModelTests
    {
        private Model _model;
        private Student studentOne;
        private Student studentTwo;
        private Student studentThree;

        [SetUp]
        public void Setup()
        {
            // Instantiate the Model
            _model = new Model();

            // Create some students
            studentOne = new Student("John Doe", "3.5", "Computer Science", "Marching Band");
            studentTwo = new Student("Jane Doe", "3.8", "Applied Mathematics", "Chess Club");
            studentThree = new Student("Bob Smith", "3.2", "Biology", "Recycling Club");

        }

        [Test]
        public void EmptryRoster_StudentAdded_RosterContainsOneStudent()
        {
            // Arrange
            // Assert that model.GetRosterSize() returns 0
            Assert.That(_model.GetRoster().Count, Is.EqualTo(0));

            // Act
            // Add a student to the roster
            _model.AddStudent(studentOne);

            // Assert
            // Check that the roster contains one student
            Assert.That(_model.GetRoster().Count, Is.EqualTo(1));
        }

        [Test]
        public void RosterWithOneStudent_StudentAdded_RosterContainsTwoStudents()
        {
            // Arrange
            // Add a student to the roster
            _model.AddStudent(studentOne);

            // Assert that model.GetRosterSize() returns 1
            Assert.That(_model.GetRoster().Count, Is.EqualTo(1));

            // Act
            // Add a second student to the roster
            _model.AddStudent(studentTwo);

            // Assert
            // Check that the roster contains two students
            Assert.That(_model.GetRoster().Count, Is.EqualTo(2));
        }

        [Test]
        public void RosterWithNoStudents_RemoveStudent_ReturnsFalse()
        {
            // Arrange
            // Assert that model.GetRosterSize() returns 0
            Assert.That(_model.GetRoster().Count, Is.EqualTo(0));

            // Act
            // Remove a student from the roster
            bool result = _model.RemoveStudent(studentOne.Name);

            // Assert
            // Check that the roster returns false and still contains 0 students
            Assert.That(result, Is.False);
            Assert.That(_model.GetRoster().Count, Is.EqualTo(0));
        }

        [Test]
        public void RosterWithOneStudent_RemoveStudent_ReturnsTrue()
        {
            // Arrange
            // Add a student to the roster
            _model.AddStudent(studentOne);

            // Assert that model.GetRosterSize() returns 1
            Assert.That(_model.GetRoster().Count, Is.EqualTo(1));

            // Act
            // Remove a student from the roster
            bool result = _model.RemoveStudent(studentOne.Name);

            // Assert
            // Check that the roster returns true and contains 0 students
            Assert.That(result, Is.True);
            Assert.That(_model.GetRoster().Count, Is.EqualTo(0));
        }

        [Test]
        public void RosterWithTwoStudents_RemoveStudent_ReturnsTrue()
        {
            // Arrange
            // Add two students to the roster
            _model.AddStudent(studentOne);
            _model.AddStudent(studentTwo);

            // Assert that model.GetRosterSize() returns 2
            Assert.That(_model.GetRoster().Count, Is.EqualTo(2));

            // Act
            // Remove a student from the roster
            bool result = _model.RemoveStudent(studentOne.Name);

            // Assert
            // Check that the roster returns true and contains 1 student
            Assert.That(result, Is.True);
            Assert.That(_model.GetRoster().Count, Is.EqualTo(1));
        }

        public void RosterWithTwoStudents_RemoveStudent_OtherStudentRemains()
        {
            // Arrange
            // Add two students to the roster
            _model.AddStudent(studentOne);
            _model.AddStudent(studentTwo);

            // Assert that model.GetRosterSize() returns 2
            Assert.That(_model.GetRoster().Count, Is.EqualTo(2));

            // Act
            // Remove a student from the roster
            bool result = _model.RemoveStudent(studentOne.Name);

            // Assert
            // Check that the roster returns true and the remaining student is studentTwo
            Assert.That(result, Is.True);
            Assert.That(_model.GetRoster().Count, Is.EqualTo(1));
            Assert.That(_model.GetRoster()[0], Is.EqualTo(studentTwo));
        }

        [Test]
        public void EmptyRoster_GetRoster_ReturnsEmptyList()
        {
            // Arrange
            // Assert that model.GetRosterSize() returns 0
            Assert.That(_model.GetRoster().Count, Is.EqualTo(0));

            // Act
            // Get the roster
            List<Student> roster = _model.GetRoster();

            // Assert
            // Check that the roster is empty
            Assert.That(roster.Count, Is.EqualTo(0));
        }

        [Test]
        public void RosterWithOneStudent_GetRoster_ReturnsListWithOneStudent()
        {
            // Arrange
            // Add a student to the roster
            _model.AddStudent(studentOne);

            // Assert that model.GetRosterSize() returns 1
            Assert.That(_model.GetRoster().Count, Is.EqualTo(1));

            // Act
            // Get the roster
            List<Student> roster = _model.GetRoster();

            // Assert
            // Check that the roster contains one student
            Assert.That(roster.Count, Is.EqualTo(1));
        }

        [Test]
        public void EmptyRoster_FindStudentInRoster_ReturnsNull()
        {
            // Arrange
            // Assert that model.GetRosterSize() returns 0
            Assert.That(_model.GetRoster().Count, Is.EqualTo(0));

            // Act
            // Find a student in the roster
            Student? student = _model.FindStudentInRoster(studentOne.Name);

            // Assert
            // Check that the roster returns null
            Assert.That(student, Is.Null);
        }

        [Test]
        public void RosterWithOneStudent_FindStudentInRoster_ReturnsStudent()
        {
            // Arrange
            // Add a student to the roster
            _model.AddStudent(studentOne);

            // Assert that model.GetRosterSize() returns 1
            Assert.That(_model.GetRoster().Count, Is.EqualTo(1));

            // Act
            // Find a student in the roster
            Student? student = _model.FindStudentInRoster(studentOne.Name);

            // Assert
            // Check that the roster returns the student
            Assert.That(student, Is.EqualTo(studentOne));
        }

        [Test]
        public void RosterWithTwoStudents_FindStudentInRoster_ReturnsCorrectStudent()
        {
            // Arrange
            // Add two students to the roster
            _model.AddStudent(studentOne);
            _model.AddStudent(studentTwo);

            // Assert that model.GetRosterSize() returns 2
            Assert.That(_model.GetRoster().Count, Is.EqualTo(2));

            // Act
            // Find a student in the roster
            Student? student = _model.FindStudentInRoster(studentOne.Name);

            // Assert
            // Check that the roster returns the student
            Assert.That(student, Is.EqualTo(studentOne));
        }

        [Test]
        public void EmptyRoster_IsRosterEmpty_ReturnsTrue()
        {
            // Arrange
            // Assert that model.GetRosterSize() returns 0
            Assert.That(_model.GetRoster().Count, Is.EqualTo(0));

            // Act
            // Check if the roster is empty
            bool result = _model.IsRosterEmpty();

            // Assert
            // Check that the roster returns true
            Assert.That(result, Is.True);
        }

        [Test]
        public void RosterWithOneStudent_IsRosterEmpty_ReturnsFalse()
        {
            // Arrange
            // Add a student to the roster
            _model.AddStudent(studentOne);

            // Assert that model.GetRosterSize() returns 1
            Assert.That(_model.GetRoster().Count, Is.EqualTo(1));

            // Act
            // Check if the roster is empty
            bool result = _model.IsRosterEmpty();

            // Assert
            // Check that the roster returns false
            Assert.That(result, Is.False);
        }

        [Test]
        public void RosterWithTwoStudents_IsRosterEmpty_ReturnsFalse()
        {
            // Arrange
            // Add two students to the roster
            _model.AddStudent(studentOne);
            _model.AddStudent(studentTwo);

            // Assert that model.GetRosterSize() returns 2
            Assert.That(_model.GetRoster().Count, Is.EqualTo(2));

            // Act
            // Check if the roster is empty
            bool result = _model.IsRosterEmpty();

            // Assert
            // Check that the roster returns false
            Assert.That(result, Is.False);
        }
    }
}