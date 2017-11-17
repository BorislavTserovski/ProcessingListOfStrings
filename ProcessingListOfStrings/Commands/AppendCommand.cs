using ProcessingListOfStrings.Common;
using ProcessingListOfStrings.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingListOfStrings.Commands
{
    public class AppendCommand : ICommand
    {
        public void Execute(List<string> listToProcess, List<string> inputArgs)
        {
            if (inputArgs.Count != 2)
            {
                Exceptions.InvalidCommandParametersException();
            }
            else
            {
                string stringToAppend = inputArgs[1];
                listToProcess.Add(stringToAppend);
                List<string> result = listToProcess;
                Results.JoinList(result);
            }
        }
    }
}
