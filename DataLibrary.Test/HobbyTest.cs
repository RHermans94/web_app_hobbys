using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static DataLibrary.BusinessLogic.HobbyProcessor;

namespace DataLibrary.Test
{
    [TestClass]
    public class HobbyTest
    {
        [TestMethod]
        public void TestCreateHobby()
        {

            var returnVal = CreateHobby("Fietsen");


            var hobbies = LoadHobby();

            foreach (var item in hobbies)
            {
                if (item.Name == "Fietsen")
                {

                    Assert.IsTrue(true);
                    return;
                }
            }

            Assert.Fail("Hobbies does not contian Fietsen");

        }

        [TestMethod]
        public void TestLoadHobby()
        {

            CreateHobby("Fietsen");
            var returnVal = LoadHobby();
            Assert.AreNotEqual(returnVal.Count, 0);

        }        
        
        [TestMethod]
        public void TestDeleteHobby()
        {
            CreateHobby("Fietsen");
            var hobbyList = LoadHobby();
            var returnVal = DeleteHobby(hobbyList[0].Id);
            Assert.AreEqual(returnVal, 1);
        
        }
    }
}
