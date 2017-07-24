
using BashSoft.Contracts;

namespace BashSoft.IO.Commands
{
    public class ChangeRelativePathCommand : Command
    {
        public ChangeRelativePathCommand(string input, string[] data, IContentComparer judge, IDatabase repository, IDirectoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            string relPath = this.Data[1];
            this.InputOutputManager.ChangeCurrentDirectoryRelative(relPath);
        }
    }
}
