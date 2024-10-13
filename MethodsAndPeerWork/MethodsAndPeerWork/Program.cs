namespace MethodsAndPeerWork
{
    /*
     * Jacob Jablon
     * Jayson Packer
     * IGME 201.01 - Interac Des & Alg Prob Sol III
     * Due Date: Oct 13, 2024
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring our favorite numbers
            int jacobFavoriteNumber;
            int jaysonFavoriteNumber;
            // initialize
            jacobFavoriteNumber = 10;
            jaysonFavoriteNumber = 8;

            // subtract takes 2 numbers and returns the difference
            static int Subtract(int a, int b){
                 return a - b;
            }

            // start of our actual program
            Console.WriteLine("I am Jacob and my favorite number is: " +  jacobFavoriteNumber);
            Console.WriteLine("I am Jayson and my favorite number is: " + jaysonFavoriteNumber);

            // calling the add function 
            int addedNums = Add(jacobFavoriteNumber, jaysonFavoriteNumber);
            // display the result of addition
            Console.WriteLine("The sum of our favorite numbers: " + addedNums);

            // calling the subtract function
            int subtractedNums = Subtract(jacobFavoriteNumber, jaysonFavoriteNumber);
            // display resut of subtraction
            Console.WriteLine("The difference of our favorite numbers: " + subtractedNums);

        }

        /// <summary>
        /// This function accepts two parameters, adds them to each other, and returns the sum
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns>sum of both parameters</returns>
        static int Add(int param1, int param2)
        {
            return param1 + param2;
        }
    }
}
