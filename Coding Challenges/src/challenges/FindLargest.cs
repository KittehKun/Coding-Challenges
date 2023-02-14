namespace Coding_Challenges.src.challenges
{
    /// <summary>
    /// Challenge sourced from https://edabit.com/challenge/nermqxzovZbfFBC9X
    /// </summary>
    internal class FindLargest
    {
        public static string Largest(int[] firstArray, int[] secondArray, int[] thirdArray)
        {
            return String.Join(", ", FindMax(firstArray), FindMax(secondArray), FindMax(thirdArray));
            //return new int[] { FindMax(firstArray), FindMax(secondArray), FindMax(thirdArray) };
        }

        private static int FindMax(int[] numbers)
        {
            int max = numbers[0]; //Setting intial value as first value
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }

            return max;
        }
    }
}
