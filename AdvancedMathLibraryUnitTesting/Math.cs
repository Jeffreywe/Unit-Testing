using System;

namespace AdvancedMathLibraryUnitTesting {

    /// <summary>
    /// This class is for Unit Testing,
    /// All methods have to be static when the class is identified as static
    /// </summary>
    public static class Math {

        public const int Zero = 0;
        public static int AbsoluteValue(int a) {
            return (a < 0) ? -a : a;
        }
        public static int Add(int a, int b) {
            return a + b;
        }
        public static int Sub(int a, int b) {
            return a - b;
        }
        public static int Div(int a, int b) {
            if (b == 0) { // this first statement makes the test fail for Divide because it doesnt throw an exception in the TestIntMathLib method
                return 0;
            }
            return a / b;
        }
        public static int Mult(int a, int b) {
            return a * b;
        }

    }
}
