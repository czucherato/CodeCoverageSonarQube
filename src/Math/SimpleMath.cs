using System;

namespace Math
{
    public class SimpleMath
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public decimal Divide(int a, int b) => (b == 0) ? throw new DivideByZeroException() : a / b;

        public decimal Multiply(int a, int b) => a * b;
    }
}