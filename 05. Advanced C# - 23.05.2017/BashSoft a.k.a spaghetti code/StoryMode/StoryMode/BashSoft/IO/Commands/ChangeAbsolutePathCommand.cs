
using BashSoft.Contracts;

namespace BashSoft.IO.Commands
{
    public class ChangeAbsolutePathCommand : Command
    {
        public ChangeAbsolutePathCommand(string input, string[] data, IContentComparer judge, IDatabase repository, IDirectoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            string absolutePath = this.Data[1];
            this.InputOutputManager.ChangeCurrentDirectoryAbsoulute(absolutePath);
        }
    }
}
