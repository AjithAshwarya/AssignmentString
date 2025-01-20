namespace AssignmentString6
{
    internal class StringAssignmentQs6
    {
        static void Main(string[] args)
        {
            // Ask the user to input a string
            Console.WriteLine("Enter a string");
            String inputStr = Console.ReadLine();

            // Ask the user to input an index value to start the substring
            Console.WriteLine("Enter the index value");
            int inputIndexValue;

            // Try parsing the input index value to ensure it's a valid integer
            int.TryParse(Console.ReadLine(), out inputIndexValue);

            // Initialize an empty string to hold the resulting substring
            String subString = "";

            // Loop through the string starting from the input index to the end of the string
            for (int i = inputIndexValue; i < inputStr.Length; i++)
            {
                // Concatenate each character starting from the input index to subString
                subString += inputStr[i];
            }

            // Output the resulting substring
            Console.WriteLine($"The substring is {subString}");
        }
    }
}
