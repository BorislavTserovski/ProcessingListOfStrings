using System;


namespace ProcessingListOfStrings.Common
{
    public static class Exceptions
    {
        public static void InvalidCommandParametersException()
        {
            Console.WriteLine("Error: invalid command parameters");
        }

        public static void InvalidCommandException()
        {
            Console.WriteLine("Error: invalid command");
        }

        public static void InvalidIndexException(int index)
        {
            Console.WriteLine($"Error: invalid index {index}"); 
        }
    }
}
