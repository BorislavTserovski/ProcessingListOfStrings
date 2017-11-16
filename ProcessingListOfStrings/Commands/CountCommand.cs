using ProcessingListOfStrings.Contracts;
using System;
using System.Collections.Generic;


namespace ProcessingListOfStrings.Commands
{

    public class CountCommand : ICommand
    {
        public void Execute(List<string> listToProcess, List<string> inputArgs)
        {
            if (inputArgs.Count != 2)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                string searchWord = inputArgs[1];
                int counter = 0;

                foreach (var word in listToProcess)
                {
                    if (word == searchWord)
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter);
            }
        }
    }
}
