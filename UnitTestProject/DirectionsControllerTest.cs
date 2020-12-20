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
    public class DirectionsControllerTest
    {


        [TestMethod]
        [Fact]
        public void testDirectionsConstructor()
        {
            IdentityUser user = new IdentityUser();
            Course course = new Course();

            Directions directions = new Directions(1,"Hi","Bye");

            
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(directions.Id, 1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(directions.Title, "Hi");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(directions.Description, "Bye");
        }

    }
}
