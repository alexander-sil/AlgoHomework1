using System;

namespace AlgoHomework1
{
    class Program
    {
        static void Main(string[] args)
        {
			TestAll();
            Console.ReadKey(true);
        }
		
		static void TestAll()
		{
            Console.WriteLine("Fibonacci -> " + TestFibonacci(10, 55, false));

            Console.WriteLine("Fibonacci (recursive) -> " + TestFibonacci(10, 55, true));
			
            Console.WriteLine("Prime number test #1 -> " + TestFlowchart(997, true));
			
            Console.WriteLine("Prime number test #2 -> " + TestFlowchart(1000, false));
		}
		
        static bool TestFibonacci(int sourceNumber, int expectedNumber, bool recursive)
        {
            int computedNumber = default;

            if (recursive)
            {
                computedNumber = Fibonacci.FibRec(sourceNumber);
            }
            else
            {
                computedNumber = Fibonacci.FibStd(sourceNumber);
            }

            return computedNumber == expectedNumber;
        }
		
		static bool TestFlowchart(int number, bool expectedResult)
		{
			bool computedResult = FlowChart.IsPrime(number);
			return computedResult == expectedResult;
		}
    }
}