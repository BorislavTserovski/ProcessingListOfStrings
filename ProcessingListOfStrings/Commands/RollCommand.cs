using ProcessingListOfStrings.Common;
using ProcessingListOfStrings.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProcessingListOfStrings.Commands
{
    public class RollCommand : ICommand
    {
        public void Execute(List<string> listToProcess, List<string> inputArgs)
        {
            if (inputArgs.Count != 2)
            {
               Exceptions.InvalidCommandParametersException();
            }
            else
            {
                if (inputArgs[1] == "left")
                {
                    string first = listToProcess[0];
                    listToProcess.RemoveAt(0);
                    listToProcess.Add(first);
                    Results.JoinList(listToProcess);
                }
                else if (inputArgs[1] == "right")
                {
                    string last = listToProcess.Last();
                    listToProcess.RemoveAt(listToProcess.Count - 1);
                    listToProcess.Insert(0, last);
                    Results.JoinList(listToProcess);
                }
                else
                {
                    Exceptions.InvalidCommandParametersException();
                }
            }
        }
    }
}
