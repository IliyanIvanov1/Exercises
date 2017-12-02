using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EulerFunc1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
   public class EulerFunctionCalculatorTest
    {
        [TestMethod]
        public void EulerFuncNumberOfReciprocalPrimes()
        {
            //Arrange
            EulerFunction eulerFunction = new EulerFunction();

            //Act
            var result= eulerFunction.EulerFunctionCalculator(9);

            //Assert
            Assert.AreEqual(result, 6,"Wrong result");
        }
        

    }
}
