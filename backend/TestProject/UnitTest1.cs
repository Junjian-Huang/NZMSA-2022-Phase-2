using NUnit.Framework;
using backend.Controllers;

namespace TestProject
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void Test1()
        {
            int input1 = 500;

            //arrange
            TestingCaseController t = new TestingCaseController();


            // act
            string result = t.TestingStatus(input1).ToString();

            // assert
            Assert.AreEqual("Microsoft.AspNetCore.Mvc.OkObjectResult", result);
        }

        [Test]
        public void Test2()
        {
            int input2 = -1;

            //arrange
            TestingCaseController t = new TestingCaseController();

            // act
            string result2 = t.TestingStatus(input2).ToString();

            // assert  
            Assert.AreEqual("Microsoft.AspNetCore.Mvc.BadRequestObjectResult", result2);
        }
    }
}