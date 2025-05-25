using System.ComponentModel.DataAnnotations;

namespace mvc1.Models
{
    public class Person
    {
        [Key]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
}