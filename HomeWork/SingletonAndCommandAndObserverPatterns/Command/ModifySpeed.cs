using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonAndCommandAndObserverPatterns
{
    public class ModifySpeed
    {
        private readonly List<ICommand> _commands;
        private ICommand _command;

        public ModifySpeed()
        {
            _commands = new List<ICommand>();
        }
        public void SetCommand(ICommand command) => _command = command;
        public void Invoke()
        {
            _commands.Add(_command);
            _command.ExecuteAction();
        }
    }
}
