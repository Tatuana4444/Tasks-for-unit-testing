using System;

namespace Task2
{
    /// <summary>
    /// Class that contains operations on integers.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Implement the algorithm for finding the Greatest common divisor of two integers.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <returns>Greatest common divisor.</returns>
        /// <exception cref="System.ArgumentException">Throw when Two numbers are 0 at the same time.</exception>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.", nameof(a));
            }

            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            return Math.Abs(a);
        }
    }
}