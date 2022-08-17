namespace AlgoHomework1
{
    public class Fibonacci
    {
        public static int FibRec(int input)
        {
            if (input == 0) return 0;

            if (input == 1) return 1;

            return FibRec(input - 1) + FibRec(input - 2);
        }

        public static int FibStd(int input)
        {
            int prev1 = 1;
            int prev2 = prev1;

            int i = input;

            while (i - 2 > 0)
            {
                (prev1, prev2) = (prev2, prev1 + prev2); i--;
            }

            return prev2;
        }
    }
}