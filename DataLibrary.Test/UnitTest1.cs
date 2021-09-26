using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static DataLibrary.BusinessLogic.PersonHobbyProcessor;

namespace DataLibrary.Test
{
    [TestClass]
    public class PersonHobbiesTest
    {
        [TestMethod]
        public void TestAddHobbyToPerson()
        {
            var returnVal = AddHobbyToPerson(1,1);
            Assert.AreEqual(returnVal, 1);
        }
        [TestMethod]
        public void TestRemoveHobbyFromPerson()
        {
            var returnVal = RemoveHobbyFromPerson(1,1);
            Assert.AreEqual(returnVal, 1);
        }

        [TestMethod]
        public void TestLoadHobbiesFromPerson()
        {
            var returnVal = LoadHobbiesFromPerson(1);

            Assert.AreNotEqual(returnVal.Count, 0);

        }
    }
}
