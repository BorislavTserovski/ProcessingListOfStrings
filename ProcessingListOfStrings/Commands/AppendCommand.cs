using ProcessingListOfStrings.Common;
using ProcessingListOfStrings.Contracts;
using System.Collections.Generic;


namespace ProcessingListOfStrings.Commands
{
    public class AppendCommand : ICommand
    {
        public void Execute(List<string> listToProcess, List<string> inputArgs)
        {
            if (inputArgs.Count != 2||string.IsNullOrWhiteSpace(inputArgs[1]))
            {
                Exceptions.InvalidCommandParametersException();
            }
            else
            {
                string stringToAppend = inputArgs[1];
                listToProcess.Add(stringToAppend);
                Results.JoinList(listToProcess);
            }
        }
    }
}
