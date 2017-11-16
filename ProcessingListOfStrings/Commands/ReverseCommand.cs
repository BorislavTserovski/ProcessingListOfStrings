using ProcessingListOfStrings.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingListOfStrings.Commands
{
    public class ReverseCommand : ICommand
    {
        public void Execute(List<string> listToProcess, List<string> inputArgs)
        {
            if (inputArgs.Count != 1)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                listToProcess.Reverse();
                List<string> result = listToProcess;
                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}
