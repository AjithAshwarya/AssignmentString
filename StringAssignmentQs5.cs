namespace AssignmentString5
{
    internal class StringAssignmentQs5
    {
        static void Main(string[] args)
        {
            // Ask user to input a string
            Console.WriteLine("Enter a string:");
            string inputStr = Console.ReadLine();

            // Initialize counters for alphabets, digits, and special characters
            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            // Loop through each character in the input string
            foreach (char inputChar in inputStr)
            {
                // Checking for Alphabet
                if ((inputChar >= 65 && inputChar <= 90) || (inputChar >= 97 && inputChar <= 122))
                {
                    alphabetCount++;
                }
                // Checking for Digits
                else if (inputChar >= 48 && inputChar <= 57)
                {
                    digitCount++;
                }
                // Otherwise Special Character
                else
                {
                    specialCharCount++;
                }
            }

            // Output the counts
            Console.WriteLine($"Total Alphabets: {alphabetCount}");
            Console.WriteLine($"Total Digits: {digitCount}");
            Console.WriteLine($"Total Special Characters: {specialCharCount}");
        }
    }
}
