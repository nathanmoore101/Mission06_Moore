using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Moore.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieId {  get; set; }
        public int? CategoryId { get; set; }
        public Category? CategoryName { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        [Range(1888,2050, ErrorMessage = "Please enter a valid year after 1888")]
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool Edited { get; set; } 
        public string? LentTo {get; set; }
        public string CopiedToPlex { get; set; }
        public string? Notes { get; set; }


    }
}
