namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Functions<int> function = new Functions<int>();
            int[] testArray = {8,14,21,23,34,76};
            //function.starTriangle(1);
            function.Contains(testArray,23);

        }
    }
}
