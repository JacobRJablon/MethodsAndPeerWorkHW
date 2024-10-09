namespace MethodsAndPeerWork
{
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
            int jacobAddedNums = Add(10, 2);
            Console.WriteLine("Jacob's added numbers: " + jacobAddedNums);

            // calling the subtract function
            // Jayson calls sub function
            // Jayson console statement
        }

        static int Add(int param1, int param2)
        {
            return param1 + param2;
        }
    }
}
