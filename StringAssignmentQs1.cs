namespace AssignmentString
{
    internal class StringAssignmentQs1
    {
        static void Main(string[] args)
        {
            //ask for user input and store it in a variable inputStr
            Console.WriteLine("Enter a string");
            String inputStr = Console.ReadLine();

            //intialise a count variable to count the number of characters in a string
            int count = 0;

            //looping through each character in  string 
            foreach (char c in inputStr)
            {
                count++; //increment count for each character in string
               
            }
            //print the length of the string to the console
            Console.WriteLine($"The length of string str : {count}");
        }
    }
}
