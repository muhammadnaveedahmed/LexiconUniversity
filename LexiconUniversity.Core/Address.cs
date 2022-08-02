namespace LexiconUniversity.Core
{
#nullable disable
    public class Address
    {

        public int Id { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }


        // Foreign Key
        public int StudentId { get; set; }

        // Nav prop
        public Student Student { get; set; }


    }
}