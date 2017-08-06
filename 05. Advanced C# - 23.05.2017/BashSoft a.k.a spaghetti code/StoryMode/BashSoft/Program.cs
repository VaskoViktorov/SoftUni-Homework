using BashSoft.Contracts;

namespace BashSoft
{
    public class Program
    {
        public static void Main()
        {
            IContentComparer tester = new Tester();
            IDirectoryManager directoryManager = new IOManager();
            IDatabase repo = new StudentsRepository(new RepositoryFilter(), new RepositorySorter());
            IInterpreter currentInterpreter = new CommandInterpreter(tester, repo, directoryManager);
            IReader reader = new InputReader(currentInterpreter);

            reader.StartReadingCommands();
        }
    }
}
