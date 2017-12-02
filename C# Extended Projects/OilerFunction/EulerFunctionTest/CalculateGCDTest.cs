

namespace EulerFunc1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class CalculateGCDTest
    {
        [TestMethod]
        public void EulerFuncAreNumbersReciprocalPrimes()
        {
            //Arrange
            var calculate = new EulerFunction();

            //Act
            var result = calculate.Coprime(6, 35);

            //Assert
            Assert.AreEqual(result, true, "Numbers are not reciprocal primes");
        }
    }
}
