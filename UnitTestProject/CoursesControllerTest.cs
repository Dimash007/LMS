using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Moq;
using Learning_Management_System.Models;
namespace UnitTestProject
{
    [TestClass]
    public class CoursesControllerTest
    {

        [TestMethod]
        [Fact]
        public void testCoursesConstructor()
        {
            IdentityUser user = new IdentityUser();
            Directions d = new Directions();
            List<Comment> c = new List<Comment>();
            Course course = new Course(1,"Hello","Cool",77.5,2,7, "asdasda", user, d,c);

           
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(course.Id, 1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(course.Title, "Hello");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(course.Description, "Cool");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(course.Price, 77.5);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(course.Month, 2);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(course.DirectionId, 7);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(course.Directions, d);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(course.UserId, "asdasda");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(course.User, user);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(course.Comments, c);
        }

    }
}
