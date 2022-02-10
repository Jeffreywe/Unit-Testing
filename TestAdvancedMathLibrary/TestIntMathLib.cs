
using Xunit;
using AdvancedMathLibraryUnitTesting;

namespace TestAdvancedMathLibrary {
    /// <summary>
    /// this is xunit testing project for Advanced math Library,
    /// TDD test driven development, write a test case for what you do,
    /// run a test to see it should fail, then make changes, then run another test and it should pass,
    /// then move to next issue
    /// </summary>
    public class TestIntMathLib {
        /// <summary>
        /// fact is an attribute that modifies test1 that xunit will test
        /// </summary>
        /*[Fact]
        ///body of method gets tested, returns no parameters in parans and is always void
        ///passes if expected and actual value are the same
        ///tests expected value, 3, with the actual value that was returned
        public void TestAbsoluteValue() {
            int answer = Math.AbsoluteValue(-3);
            Assert.Equal(3, answer);
            // testing with 3
            Assert.Equal(3, Math.AbsoluteValue(3));
            Assert.Equal(0, Math.AbsoluteValue(0));
        }
        [Fact]
        public void TestZeroConstant() {
            Assert.Equal(0, Math.Zero);
        }*/

        // theory tests the same as fact but less lines of code, inline data selects what values to test
        //-3 is input, 3 is expected, Assert expression tests that the input and expected syncs
        [Theory]
        [InlineData(-3, 3)]
        [InlineData(3, 3)]
        [InlineData(0, 0)]
        public void TestAbsoluteValue(int input, int expected) {
            Assert.Equal(expected, Math.AbsoluteValue(input));
        }
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 5, -5)]
        [InlineData(-10, 15, -25)]
        public void TestAdd(int expected, int a, int b) {
            Assert.Equal(expected, Math.Add(a, b));
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, -10, -10)]
        [InlineData(10, -25, -35)]
        public void TestSub(int expected, int a, int b) {
            Assert.Equal(expected, Math.Sub(a, b));
        }    

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(45, 5, 9)]
        [InlineData(81, 9, 9)]
        [InlineData(0, 45, 0)]
        [InlineData(-45, -5, 9)]
        public void TestMult(int answer, int firstNumber, int secondNumber) {
            Assert.Equal(answer, Math.Mult(firstNumber, secondNumber));
        }

        // defining way to call a method, passes a variable to another function
        // defines ZeroDenominator to name the function Math.Div, when the first line of code executes, the second line tests if the program throws exception that was defined
        [Fact]
        public void TestDiviveByZero() {
            System.Action ZeroDenominator = () => Math.Div(1, 0);
            Assert.Throws<System.DivideByZeroException>(ZeroDenominator);                
        }
    }
}
