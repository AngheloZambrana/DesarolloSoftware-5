using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            IProgression fibonacciProgression = new FibonacciProgression(10);
            IProgression arithmeticProgression = new ArithmeticProgression(6);
            var pairs = fibonacciProgression.Generate().Where(p => p % 2 == 0);

            Console.WriteLine("Even Fibonacci numbers:");
            foreach (var num in pairs)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(arithmeticProgression);
        }

        public interface IProgression
        {
            IEnumerable<int> Generate();
        }

        public abstract class Progression : IProgression
        {
            protected int Limit { get; }

            protected Progression(int limit)
            {
                Limit = limit;
            }

            public abstract IEnumerable<int> Generate();
        }

        public interface IFibonacciProgression : IProgression
        {
        }

        public class FibonacciProgression : Progression, IFibonacciProgression
        {
            public FibonacciProgression(int limit) : base(limit)
            {
            }

            public override IEnumerable<int> Generate()
            {
                int a = 0;
                int b = 1;
                for (int i = 0; i < Limit; i++)
                {
                    yield return a;
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
            }
        }

        public interface IArithmeticProgression : IProgression
        {
        }

        public class ArithmeticProgression : Progression, IArithmeticProgression
        {
            private readonly int _difference;

            public ArithmeticProgression(int limit, int difference) : base(limit)
            {
                _difference = difference;
            }

            public override IEnumerable<int> Generate()
            {
                int current = 0;
                for (int i = 0; i < Limit; i++)
                {
                    yield return current;
                    current += _difference;
                }
            }
        }
    }
}
