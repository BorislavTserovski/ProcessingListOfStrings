using ProcessingListOfStrings.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProcessingListOfStrings.Commands
{
    public class DeleteCommand : ICommand
    {
        public void Execute(List<string> listToProcess, List<string> inputArgs)
        {
            if (inputArgs.Count != 2)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                int index = -1;
                bool isNumber = int.TryParse(inputArgs[1], out index);
                if (!isNumber)
                {
                    Console.WriteLine($"Error: invalid command parameters");
                }
                else
                {
                    if (listToProcess.ElementAtOrDefault(index) != null)
                    {
                        listToProcess.RemoveAt(index);
                        Console.WriteLine(String.Join(" ", listToProcess));
                    }
                    else
                    {
                        Console.WriteLine($"Error: invalid index {inputArgs[1]}");
                    }
                }
            }
        }
    }
}
