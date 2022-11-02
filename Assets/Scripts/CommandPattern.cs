using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface ICommand
    {
        public void Execute();
        public void ExecuteUndo();
    }

    public class Invoker
    {
        Stack<ICommand> history;

        public Invoker()
        {
            history = new Stack<ICommand>();
        }

        public void Execute(ICommand command)
        {
            if (command != null)
            {
                history.Push(command);
                history.Peek().Execute();
            }
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                history.Peek().ExecuteUndo();
                history.Pop();
            }
        }

    }
}
