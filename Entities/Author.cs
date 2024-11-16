using System.ComponentModel.DataAnnotations;

namespace librarymanagmentsystem.Entities
{
    public class Author
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}
