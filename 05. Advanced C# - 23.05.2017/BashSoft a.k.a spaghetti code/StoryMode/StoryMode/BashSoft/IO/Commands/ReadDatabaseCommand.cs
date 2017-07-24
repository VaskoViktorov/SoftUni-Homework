using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BashSoft.Contracts;

namespace BashSoft.IO.Commands
{
    public class ReadDatabaseCommand : Command
    {
        public ReadDatabaseCommand(string input, string[] data, IContentComparer judge, IDatabase repository, IDirectoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            string fileName = this.Data[1];
            this.Repository.LoadData(fileName);
        }
    }
}
