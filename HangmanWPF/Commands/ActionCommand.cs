﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HangmanWPF.Commands
{
    class ActionCommand : ICommand
    {
        private Action _MethodToExecute;
        private Func<bool> _CanExecuteEvaluator;

        public ActionCommand(Action methodToExecute, Func<bool> canExecuteEvaluator)
        {
            _MethodToExecute = methodToExecute;
            _CanExecuteEvaluator = canExecuteEvaluator;
        }
        public ActionCommand(Action methodToExecute)
            : this(methodToExecute, null)
        {
        }

        public bool CanExecute(object parameter)
        {
            if (_CanExecuteEvaluator == null)
            {
                return true;
            }

            return _CanExecuteEvaluator.Invoke();
        }

        public void Execute(object parameter)
        {
            _MethodToExecute.Invoke();
        }


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
