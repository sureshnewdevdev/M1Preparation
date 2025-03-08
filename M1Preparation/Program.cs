
namespace M1Preparation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check the given number is palindrome");
            //string sentense = Console.ReadLine().ToLower();
            string sentense = "SSSS";
            //string pracStr = " New   Madam    is from Karala she speak Malayalam.   She is a malayali   "; 

            string[] words = Cleanup(sentense);

            ReverseString reverseString = new ReverseString();

            foreach (var word in words)
            {

                string output = (reverseString.IsPalindrome(word)) ? $"The given word is palindrome -- {word}" : $"The given word is not palindrome -- {word}";
                Console.WriteLine(output);
                //if (reverseString.IsPalindrome(word))
                //{
                //    Console.WriteLine($"The given word is palindrome -- {word}");
                //}
                //else
                //{
                //    Console.WriteLine($"The given word is not palindrome -- {word}");
                //}

            }
            int n = int.MaxValue;
            int x = 0;
            try
            {

                //string name = "Srikanth";
                //name.Substring(10,10);

                //checked
                //{
                //    n = n + 100;
                //}

                //words[1000] = "sdfsdfS";

                ReverseString reverseString3 = new ReverseString();
                reverseString.AnyFunction(0);


            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                words[1000] = "sdfsdfS";

                Console.WriteLine("Index out of range. Please try with in the limit. Thanks for your continous support");
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine(x);
                Console.WriteLine("Too Big number to Handle . Please try with smaller number. Thanks for your continous support");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Limit is reached, . Please try later. Thanks for your continous support");
            }
            catch (MyOwnException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error now. Please try later. Thanks for your continous support");
            }
            finally // memory clean up
            {
                Console.WriteLine("Finally block");
            }

            ReverseString reverseString1 = new ReverseString();
            try
            {
                var result = reverseString1.AnyFunction(2);
                //words[10000] = "dssdfds";
            }
            catch(MyOwnException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

               
            }

            try
            {
                words[10000] = "dssdfds";

            }
            catch (Exception ex)
            {

                Console.WriteLine("Internal error");
            }


            //if (reverseString.IsPalindrome(word))
            //{
            //    Console.WriteLine("The given word is palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("The given word is not palindrome");
            //}
        }

        private static string[] Cleanup(string pracStr)
        {
            int dummy = 0;
            pracStr = pracStr.Replace(".", "");
            string result = string.Empty;
            // Left Trim
            result = pracStr.TrimStart();
            // Right Trim
            result = result.TrimEnd();
            //Replace double space with single space
            result = result.Replace("  ", " ");
            //result = pracStr.TrimStart().TrimEnd().Replace("  ", " ");

            var words = result.Split(' ');
            words = words.Where(x => x.Trim() != string.Empty && x.Length > 2).ToArray();
            return words;
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
            for (int i = length - 1; i >= 0; i--)
            {
                result += charArray[i];
                //result = result + charArray[i];
            }
            return result;
        }

        public bool IsPalindrome(string strInput)
        {
            string reverse = Reverse(strInput);
            return strInput.Equals(reverse);
        }

        public int  AnyFunction(int n)
        {
            if (n==0)
                throw new MyOwnException();
            return n * 2;
        }
    }
}
