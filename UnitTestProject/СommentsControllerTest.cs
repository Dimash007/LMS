using Learning_Management_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTestProject
{
    [TestClass]
    public class СommentsControllerTest
    {
        [TestMethod]
        [Fact]
        public void testCommentsConstructor()
        {
            IdentityUser user = new IdentityUser();
            Course c = new Course();
            Comment comment = new Comment(1, "conntent", 11,c,"aa-07-ddax", user);


            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(comment.Id, 1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(comment.Content, "conntent");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(comment.CourseId, 11);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(comment.Course, c);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(comment.UserId, "aa-07-ddax");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(comment.User, user);
        }
    }
}
