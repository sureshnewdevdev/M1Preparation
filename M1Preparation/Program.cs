namespace M1Preparation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check the given number is palindrome");
            string word = Console.ReadLine().ToLower();

            ReverseString reverseString = new ReverseString();

                    if (reverseString.IsPalindrome(word))
            {
                Console.WriteLine("The given word is palindrome");
            }
            else
            {
                Console.WriteLine("The given word is not palindrome");
            }
        }
    }

    // Reverse a string
    public class ReverseString
    {
        public string Reverse(string strInput)
        {
            string result = string.Empty;
            char[] charArray = strInput.ToCharArray();
            int length = strInput.Length;
            for (int i = length-1; i >=0; i--)
            {
                result+= charArray[i];
                //result = result + charArray[i];
            }
            return result;
        }

        public bool IsPalindrome(string strInput)
        {
            string reverse = Reverse(strInput);
            return strInput.Equals(reverse);
        }
    }
}
