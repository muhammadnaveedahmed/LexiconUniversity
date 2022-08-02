namespace LexiconUniversity.Core
{
    public class Student
    {
        private Student()
        {
            FirstName = null!;
            LastName = null!;
            Email = null!;
            Avatar = null!;
        }

        public Student(string avatar, string firstName, string lastName, string email)
        {
            Avatar = avatar;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public int Id { get; set; }
        public string Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }


        // Navigation Properties
        public Address Address { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();


    }
}