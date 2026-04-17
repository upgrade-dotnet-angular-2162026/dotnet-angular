using NUnit;
using MathLibrary;
namespace TestMathLibrary
{
    [TestFixture]
    public class CalculateTest
    {
        private Calculate ?calculate=null;
        [SetUp] //exexute before every test method execution
        public void SetUp()
        {
            //Arrange
             calculate = new Calculate();
        }
        [TearDown] //execute after every test method execution
        public void TearDown()
        {
            calculate = null;
        }

        //write test cases here
        [Test]
        public void Test_Add()
        {
            //Arrange
            Calculate obj=new Calculate();
            int expected = 5;
            //Act
            int actual = obj.Add(2, 3);
            //Assert
           Assert.That(expected,Is.EqualTo(actual));
        }
        [Test]
        public void Test_IsEven_Fail()
        {
            //Arrange
           // Calculate calculate=new Calculate();
          
            //Act
            bool actual = calculate.IsEven(3);
            //Assert
            Assert.That(actual, Is.False);
        }
        [Test]
        public void Test_IsEven_Pass()
        {
            //Arrange
            Calculate calculate = new Calculate();

            //Act
            bool actual = calculate.IsEven(4);
            //Assert
            Assert.That(actual, Is.True);
        }

    }
}
