using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Learning_Management_System.Models
{
    public class MyCourses
    {
       
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        public MyCourses()
        {

        }
        public MyCourses(int Id, int CourseId, Course Course, string UserId, IdentityUser User)
        {
            this.Id = Id;
            this.CourseId = CourseId;
            this.Course = Course;
            this.UserId = UserId;
            this.User = User;
        }
    }
}
