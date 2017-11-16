using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingListOfStrings.Contracts
{
    public interface ICommand
    {
        void Execute(List<string> listToProcess, List<string> inputArgs);
    }
}
