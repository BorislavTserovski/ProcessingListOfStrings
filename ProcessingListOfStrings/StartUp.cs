using ProcessingListOfStrings.Common;
using ProcessingListOfStrings.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace ProcessingListOfStrings
{
    public class StartUp
    {
        private const string CommandsNameSpace = "ProcessingListOfStrings.Commands";
        private const string CommandsSuffix = "Command";

        public static void Main()
        {
            List<string> initialList = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Results.JoinList(initialList);

            //If you want to add a new command, add it here as well!
            List<string> allowedCommands = new List<string>
            { "append", "prepend", "reverse",
                "insert", "delete", "roll",
                "sort", "count", "end"};

            string commandLine = Console.ReadLine();

            while (true)
            {
                List<string> args = commandLine.Split(' ').ToList();
                string command = args[0];

                if (!allowedCommands.Contains(command))
                {
                    Exceptions.InvalidCommandException();
                    commandLine = Console.ReadLine();
                    continue;
                }

                string concreteCommandName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(command) + CommandsSuffix;
                Type commandType = Type.GetType($"{CommandsNameSpace}.{concreteCommandName}");
                ICommand concreteCommand = (ICommand)Activator.CreateInstance(commandType);
                concreteCommand.Execute(initialList, args);

                if (command == "end" && args.Count == 1)
                {
                    break;
                }

                commandLine = Console.ReadLine();
            }

        }
    }
}
