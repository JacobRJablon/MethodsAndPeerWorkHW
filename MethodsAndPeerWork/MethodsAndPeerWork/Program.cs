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
            // Jayson declare favNum

            // initialize
            jacobFavoriteNumber = 10;
            // Jayson initialize favNum

            // start of our actual program
            Console.WriteLine("I am Jacob and my favorite number is: " +  jacobFavoriteNumber);
            // Jayson console statement

            // calling the add function
            int jacobAddedNums = Add(jacobFavoriteNumber, 2);
            Console.WriteLine("Jacob's added numbers: " + jacobAddedNums);

            // calling the subtract function
            // Jayson calls sub function
            // Jayson console statement
        }

        /// <summary>
        /// This function accepts two parameters, adds them to each other, and returns the sum
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        static int Add(int param1, int param2)
        {
            return param1 + param2;
        }
    }
}
