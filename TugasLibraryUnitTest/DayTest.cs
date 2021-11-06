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
    public class DayTest
    {
        private Day dTest;
        [SetUp]
        public void Init()
        {
            dTest = new Day();
        }

        [Test]
        public void NameOfDayTest()
        {
            Assert.AreEqual("Jum'at", dTest.NameOfDay(5));
        }
    }
}
