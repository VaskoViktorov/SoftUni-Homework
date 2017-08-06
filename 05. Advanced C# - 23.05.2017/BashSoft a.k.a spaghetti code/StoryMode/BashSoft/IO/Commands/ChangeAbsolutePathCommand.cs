using BashSoft.Attributes;
using BashSoft.Contracts;

namespace BashSoft.IO.Commands
{
    [Alias("cdabs")]
    public class ChangeAbsolutePathCommand : Command
    {
        [Inject]
        private IDirectoryManager inputOutputManager;

        public ChangeAbsolutePathCommand(string input, string[] data) 
            : base(input, data)
        {
        }

        public override void Execute()
        {
            string absolutePath = this.Data[1];
            this.inputOutputManager.ChangeCurrentDirectoryAbsoulute(absolutePath);
        }
    }
}
