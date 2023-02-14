namespace Coding_Challenges.src.challenges
{
    /// <summary>
    /// Challenge sourced from https://edabit.com/challenge/2QvnWexKoLfcJkSsc
    /// </summary>
    internal class ArrayOfMultiples
    {
        /// <summary>
        /// This method takes in two arguments and returns an array of the input's multiples.
        /// </summary>
        /// <param name="num">Number used for multiples calculation.</param>
        /// <param name="length">The length of the array.</param>
        /// <returns>An array of multiples based on the <c>num</c> variable.</returns>
        public static string Multiples(int num, int length)
        {
            int[] multipleArray = new int[length];
            multipleArray[0] = num;
            for (int i = 0; i < multipleArray.Length; i++)
            {
                int result = multipleArray[i] * 2;
                if (i + 1 != multipleArray.Length)
                {
                    multipleArray[i + 1] = result;
                }
            }
            return String.Join(", ", multipleArray);
        }
    }
}
