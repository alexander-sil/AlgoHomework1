namespace AlgoHomework1
{
    class BigO
    {
        public static int StrangeSum(int[] inputArray)
        {
            // O(1) | variable initialization
            int sum = 0;

            // O(n^3) | three for loops with (i < inputArray.Length) precondition
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        // O(1) | variable initialization
                        int y = 0;

                        if (j != 0)
                        {
                            // O(1) | division
                            y = k / j;
                        }

                        // O(1) | addition assignment
                        sum += inputArray[i]

                        // O(1) | addition
                        + i

                        // O(1) | addition
                        + k

                        // O(1) | addition
                        + j

                        // O(1) | addition
                        + y;
                    }
                }
            }

            // O(1) | return value
            return sum;
        }
    }

    // Total: O(n^3) | constant values excluded
}