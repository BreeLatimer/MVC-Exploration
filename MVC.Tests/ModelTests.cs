namespace MVC.Tests
{
    public class ModelTests
    {
        private View _view;
        private StudentModel _model;
        private Student studentOne;
        private Student studentTwo;
        private Student studentThree;

        [SetUp]
        public void Setup()
        {
            // Instantiate the View and Model
            _view = new View();
            _model = new StudentModel(_view);

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
    }
}