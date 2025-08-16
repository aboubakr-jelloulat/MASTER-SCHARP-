using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA._00_Intro.Stack_Queue
{


    internal class AppandTextCommand
    {
        private string _OriginText;
        private readonly string _TextToAppand;

        public AppandTextCommand(string OriginText, string TextToAppand)
        {
            this._OriginText = OriginText;
            this._TextToAppand = TextToAppand;

        }
        public string Execute()
        {
            _OriginText += _TextToAppand;

            Console.WriteLine("\n" + _OriginText + "\n");

            return _OriginText;
        }

        public string Undo()
        {
            _OriginText = _OriginText.Substring(0, _OriginText.Length - _TextToAppand.Length);

            Console.WriteLine("\n" + _OriginText + "\n");

            return _OriginText;

        }


        public string Redo()
        {
            _OriginText += _TextToAppand;

            Console.WriteLine("\n" + _OriginText + "\n");

            return _OriginText;

        }
    }


    internal class clsStack
    {
        public void ImplementUndoRedo()
        {
            var CommandStack = new Stack<AppandTextCommand>();
            var RedoStack = new Stack<AppandTextCommand>();
            var OriginText = "";

            while (true)
            {
                Console.Write("Type Text To Appand ('exit' to Exit 'undo' to Undo) :    ");

                var input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                else if (input.Equals("undo", StringComparison.OrdinalIgnoreCase))
                {
                    if (CommandStack.Count > 0)
                    {
                        var command = CommandStack.Pop();

                        command.Undo();

                        RedoStack.Push(command);
                    }
                    
                }

                else if (input.Equals("redo", StringComparison.OrdinalIgnoreCase))
                {
                    if (RedoStack.Count > 0)
                    {
                        var redocmd = RedoStack.Pop();

                        redocmd.Redo();

                        CommandStack.Push(redocmd);
                    }

                }

                else
                {
                    var command = new AppandTextCommand(OriginText, input);

                    OriginText = command.Execute();

                    CommandStack.Push(command);

                }

            }
            

        }

        



    }

}
