﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Inverse_solver.ViewModel.Commands
{
    public class OpenSettingsFormCommand : ICommand
    {
        public TaskViewModel ViewModel { get; set; }
        public OpenSettingsFormCommand(TaskViewModel viewModel)
        {
            ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // execute this method in any cases
            return true;
        }

        public void Execute(object parameter)
        {
            this.ViewModel.OpenSettingsForm();
        }
    }
}
