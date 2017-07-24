using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BashSoft.Contracts;

namespace BashSoft
{
    public class Program
    {
        public static void Main()
        {
            IContentComparer tester = new Tester();
            IDirectoryManager ioManager = new IOManager();
            IDatabase repo = new StudentsRepository(new RepositoryFilter(), new RepositorySorter());
            IInterpreter currentInterpreter = new CommandInterpreter(tester, repo, ioManager);
            IReader reader = new InputReader(currentInterpreter);

            reader.StartReadingCommands();
        }
    }
}
