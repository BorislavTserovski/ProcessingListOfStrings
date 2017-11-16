using ProcessingListOfStrings.Contracts;
using System;
using System.Collections.Generic;


namespace ProcessingListOfStrings.Commands
{
    public class PrependCommand : ICommand
    {
        public void Execute(List<string> listToProcess, List<string> inputArgs)
        {
            if (inputArgs.Count != 2)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                string stringToPrepend = inputArgs[1];
                listToProcess.Insert(0, stringToPrepend);
                List<string> result = listToProcess;
                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}
