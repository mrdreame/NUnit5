using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class UserTest
    {
        private User uTest;

        [SetUp]
        public void Init()
        {
            uTest = new User();
        }

        [Test]
        public void TestUserValid()
        {
            Assert.AreEqual(true, uTest.IsValidUser("admin", "admin"));
        }
    }
}
