namespace AlgoHomework1
{
    public class FlowChart
    {
        public static bool IsPrime(int number)
        {
            int d = 0;
            int i = 2;


		// Невозможно сделать цикл while с альтернативным условием, поэтому я сделал цикл на основе метки
        mark:
            if (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;

                goto mark;
            }
            else
            {
                return d == 0;
            }
			
			return false;
        }
    }
}