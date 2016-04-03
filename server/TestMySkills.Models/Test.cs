namespace TestMySkills.Models
{
    public class Test : DeletableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string CreatedBy { get; set; }

        public string Date { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }
    }
}
