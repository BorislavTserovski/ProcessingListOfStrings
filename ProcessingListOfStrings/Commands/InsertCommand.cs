using ProcessingListOfStrings.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingListOfStrings.Commands
{
    public class InsertCommand : ICommand
    {
        public void Execute(List<string> listToProcess, List<string> inputArgs)
        {
            if (inputArgs.Count != 3)
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
                        listToProcess.Insert(index, inputArgs[2]);
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
