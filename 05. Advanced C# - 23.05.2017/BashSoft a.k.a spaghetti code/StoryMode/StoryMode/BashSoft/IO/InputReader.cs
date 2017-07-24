using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BashSoft.Contracts;

namespace BashSoft
{
    public class InputReader : IReader
    {
        private IInterpreter interpreter;

        public InputReader(IInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }
        public  void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
            string input = Console.ReadLine().Trim();

            while (input != endCommand)
            {
                this.interpreter.InterpredCommand(input);
                OutputWriter.WriteMessage($"{SessionData.currentPath}> ");              
                input = Console.ReadLine().Trim();
                
            }
            


        }
        private const string endCommand = "quit";
    }
}
