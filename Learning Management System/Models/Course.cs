using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Learning_Management_System.Models
{
    public class Course
    {

         public Course(int Id, string Title, string Description, double Price, int Month, int DirectionId, string UserId, IdentityUser User, Directions Directions, List<Comment> Comments)
            {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Price = Price;
            this.Month = Month;
            this.DirectionId = DirectionId;
            this.UserId = UserId;
            this.User = User;
            this.Directions = Directions;
            this.Comments = Comments;
        }


        public Course() { 
        
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Not Title")]
        [StringLength(255, ErrorMessage = "The Title is the very short", MinimumLength = 5)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Not Description")]
        [StringLength(1000, ErrorMessage = "The Description is the very short", MinimumLength = 20)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is the empty")]
        [Range(1, 10000, ErrorMessage = "Price greater than 0")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Month is the empty")]
        [Range(1, 48, ErrorMessage = "Month greater than 0")]
        public int Month { get; set; }
        public int DirectionId { get; set; }
        public  Directions Directions{ get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
