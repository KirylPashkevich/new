using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyApp.Tests
{
    
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            // Arrange
            Calculator calculator = new Calculator();
            int a = 5;
            int b = 10;
            int expected = 15;

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            
            Assert.AreEqual(expected, actual);
        }
    }
}