/*Write a program in C# Sharp to print the first n natural number using recursion.
 * Test Data :
    * How many numbers to print : 10
    * Expected Output : 1 2 3 4 5 6 7 8 9 10*/

namespace CCAD16_Assignment5_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers to print: ");
            int numSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You chose to print {numSelection} numbers");

            displayNumbers(1, numSelection);
        }

        static int displayNumbers(int stVal, int ctr)
        {
            if (stVal > ctr)
            {
                return stVal;
            }
           
            Console.WriteLine(stVal);
            return displayNumbers(stVal + 1, ctr);
        }
    }
}
