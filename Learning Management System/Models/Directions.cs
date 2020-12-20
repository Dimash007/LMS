using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Learning_Management_System.Models
{
    public class Directions
    {

        public Directions(int Id, string Title, string Description) {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
        }

        public Directions() { 
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Not Title")]
        [StringLength(255, ErrorMessage = "The Title is the very short", MinimumLength = 1)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Not Description")]
        [StringLength(1000, ErrorMessage = "The Description is the very short", MinimumLength = 20)]
        public string Description { get; set; }

        public List<Course> Courses { get; set; }
    }
}
