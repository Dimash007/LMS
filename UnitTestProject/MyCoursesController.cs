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
    public class MyCoursesController
    {
        [TestMethod]
        [Fact]
        public void testMyCoursesConstructor()
        {
            IdentityUser user = new IdentityUser();
            Course c = new Course();
            MyCourses myCourses= new MyCourses(1, 8, c,  "aa-07-ddax", user);


            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(myCourses.Id, 1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(myCourses.CourseId, 8);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(myCourses.Course, c);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(myCourses.UserId, "aa-07-ddax");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(myCourses.User, user);
        }
    }
}

