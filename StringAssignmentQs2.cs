namespace AssignmentString2
{
    internal class StringAssignmentQs2
    {
        static void Main(string[] args)
        {
            //ask user to input a string and store it in a variable inputString
            Console.WriteLine("Enter a string");
            String inputStr =Console.ReadLine();

            // Check if the input is null or empty
            if (String.IsNullOrEmpty(inputStr))
            {
                Console.WriteLine("The input string cannot be empty.");
                return; // Exit the program if the input is invalid
            }

            //loop through each character in  string in reverse order 
            for (int i = inputStr.Length-1;i>=0;i--)
            {
                Console.WriteLine(inputStr[i]);//printing each character in reverse order
            }
        }
    }
}
