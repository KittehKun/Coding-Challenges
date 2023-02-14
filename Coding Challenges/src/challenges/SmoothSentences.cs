namespace Coding_Challenges.src.challenges
{
    /// <summary>
    /// Challenge sourced from https://edabit.com/challenge/SkY5Nw3rS7WvkQmFc
    /// </summary>
    internal class SmoothSentences
    {
        public static bool IsSmooth(string sentence)
        {
            string[] words = sentence.Split(' '); //Splits words by space delimiter

            for (int i = 0; i < words.Length - 1; i++) //Subtracts one from the length to correctly compare the last and second to last elements
            {
                string currentWord = words[i]; //Sets current word to the current index from i
                string nextWord = words[i + 1]; //Sets the next work to the current index from i + 1

                if (currentWord.Substring(currentWord.Length - 1, 1).ToLower() != nextWord.Substring(0, 1).ToLower()) //Takes substring of last letter of the first word and compares with the substring of the next word's first letter. If they are the same then continue looping through the array otherwise return false.
                {
                    return false;
                }

            }
            return true; //If loop goes through all the way, then the sentence passed in was a 'Smooth Sentence'.
        }
    }
}
