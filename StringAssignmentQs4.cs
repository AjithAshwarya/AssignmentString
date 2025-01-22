namespace AssignmentString4
{
    internal class StringAssignmetQs4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            bool areEqual = true;

            // Check if lengths are different
            if (str1.Length != str2.Length)
            {
                areEqual = false;
            }
            else
            {
                // Compare characters one by one
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }

            // Output result
            if (areEqual)
            {
                Console.WriteLine("\nThe two strings are equal.");
            }
            else
            {
                Console.WriteLine("\nThe two strings are not equal.");
            }
        }
    }
}
