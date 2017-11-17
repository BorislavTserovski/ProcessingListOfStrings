using ProcessingListOfStrings.Common;
using ProcessingListOfStrings.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProcessingListOfStrings.Commands
{
    public class InsertCommand : ICommand
    {
        public void Execute(List<string> listToProcess, List<string> inputArgs)
        {
            if (inputArgs.Count != 3)
            {
                Exceptions.InvalidCommandParametersException();
            }
            else
            {
                int index = -1;
                bool isNumber = int.TryParse(inputArgs[1], out index);
                if (!isNumber)
                {
                    Exceptions.InvalidCommandParametersException();
                }
                else
                {
                    if (listToProcess.ElementAtOrDefault(index) != null)
                    {
                        listToProcess.Insert(index, inputArgs[2]);
                        Results.JoinList(listToProcess);
                    }
                    else
                    {
                        Exceptions.InvalidIndexException(index);
                    }
                }
            }
        }
    }
}
