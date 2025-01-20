

namespace AssignmentString2
{
    internal class StringAssignmentQs2
    {
        static void Main(string[] args)
        {
            //ask user to input a string and store it in a variable inputString
            Console.WriteLine("Enter a string");
            String inputStr = Console.ReadLine();

            //intialise a countWord variable to count the number of words in a string
            int countWord =0;

            // Check if the input is null or empty
            if (String.IsNullOrEmpty(inputStr))
            {
                Console.WriteLine("The input string cannot be empty.");
                return; // Exit the program if the input is invalid
            }
            String wordString = " "; //initialize an empty string to store each word of the string
            //loop through each character in string
            foreach (char c in inputStr)
            {
                if (!char.IsWhiteSpace(c))
                {
                    wordString += c;
                    
                }
                else
                {

                    if (!string.IsNullOrWhiteSpace(wordString)) // Word is complete if it's not empty
                    {
                        countWord++;
                        wordString = ""; // Reset wordString for the next word
                    }
                }
            }
            // Check if the last word is completed 
            if (!string.IsNullOrWhiteSpace(wordString))
            {
                countWord++;
            }
            //print the total number of words in the string in the console
            Console.WriteLine($"The total number of words in the string inputStr : {countWord}");
            
        }
    }
}
