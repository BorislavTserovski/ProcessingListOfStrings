using ProcessingListOfStrings.Contracts;
using System;
using System.Collections.Generic;


namespace ProcessingListOfStrings.Commands
{
    public class EndCommand : ICommand
    {
        public void Execute(List<string> listToProcess, List<string> inputArgs)
        {
            if (inputArgs.Count != 1)
            {
                Console.WriteLine("Ërror: invalid command parameters");
            }
            else
            {
                Console.WriteLine("Finished");
            }
        }
    }
}
