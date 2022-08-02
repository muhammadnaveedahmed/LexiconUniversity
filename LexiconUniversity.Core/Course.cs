namespace LexiconUniversity.Core
{
    public class Course
    {
        private Course()
        {
            Title = null!;
        }

        public Course(string title)
        {
            Title = title;
        }
        public int Id { get; set; }
        public string Title { get; set; }


        // Navigation properties
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
