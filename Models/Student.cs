using System.ComponentModel.DataAnnotations;
namespace WebApp1BySijan.Models
{
    public class Student
    {
        [Required]
        [Range(0,299, ErrorMessage = "Student ID must be between 0 and 299")]
        public int StdID {  get; set; }

        [Required]
        [StringLength(20,ErrorMessage ="Name length cannot be more than 10 ")]
        public String Name {  get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Address length cannot be more than 20 ")]
        public String Address {  get; set; }

        [Required(ErrorMessage ="Faculty is required")]
        public String Faculty {  get; set; }
    }
}
