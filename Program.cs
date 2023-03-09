namespace AlgorithmProblemDemo
{
    public class Program
    {
        public static void swap(char[] chars, int i, int j)
        {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }

        public static void permutations(char[] chars, int currentIndex)
        {
            if (currentIndex == chars.Length - 1)
            {
               Console.WriteLine(chars);
            }

            for (int i = currentIndex; i < chars.Length; i++)
            {
                swap(chars, currentIndex, i);
                permutations(chars, currentIndex + 1);
                swap(chars, currentIndex, i);
            }
        }

        public static void findPermutations(String str)
        {

            // base case
            if (str == null || str.Length == 0)
            {
                return;
            }

            permutations(str.ToCharArray(), 0);
        }


        public static void Main(string[] args)
        {
            String str = "ABC";
            findPermutations(str);
        }
    }
}