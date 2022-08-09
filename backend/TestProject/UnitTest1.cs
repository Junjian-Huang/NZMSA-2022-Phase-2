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
            int input2 = 300;
            

            //arrange
            TestingCaseController t = new TestingCaseController();

            // act
            var result = t.GetSum(input1, input2);

            // assert
            
            //Assert.AreEqual(t.Response.StatusCode.ToString(),200);
            Assert.AreEqual(result.GetType(), result);
        }
    }
}