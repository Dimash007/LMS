using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Learning_Management_System.Models
{
    public class Comment
    {

        
        public Comment()
        {

        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Not Title")]
        [StringLength(255, ErrorMessage = "The Title is the very short", MinimumLength = 5)]
        public string Content { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public string UserId { get; set; }
        public IdentityUser User { get; set; }


        public Comment(int Id, string Content, int CourseId, Course Course, string UserId,IdentityUser User)
        {
            this.Id = Id;
            this.Content = Content;
            this.CourseId = CourseId;
            this.Course = Course;
            this.UserId = UserId;
            this.User = User;
        }

    }
}
