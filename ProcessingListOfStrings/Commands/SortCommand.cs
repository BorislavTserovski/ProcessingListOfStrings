using ProcessingListOfStrings.Contracts;
using System;
using System.Collections.Generic;


namespace ProcessingListOfStrings.Commands
{
    public class SortCommand : ICommand
    {
        public void Execute(List<string> listToProcess, List<string> inputArgs)
        {
            if (inputArgs.Count != 1)
            {
                Console.WriteLine("Error invalid command parameters");
            }
            else
            {
                listToProcess.Sort();
                List<string> result = listToProcess;
                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}
