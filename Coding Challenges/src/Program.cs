using Coding_Challenges.src.challenges;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("[" + ArrayOfMultiples.Multiples(2, 5) + "]"); //Challenge #1
        Console.WriteLine("[" + FindLargest.Largest(new int[] { 3, 4, 71 }, new int[] { 50, 12, 1 }, new int[] { 19, 22, 100 }) + "]"); //Challenge #2
    }

}