﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Inverse_solver.ViewModel.Commands
{
    public class OpenDiscrepancyViewCommand : ICommand
    {
        public TaskViewModel ViewModel { get; set; }
        public OpenDiscrepancyViewCommand(TaskViewModel viewModel)
        {
            ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return this.ViewModel.IsTaskCalculated && !this.ViewModel.DiscrepancyViewOpened;
        }

        public void Execute(object parameter)
        {
            this.ViewModel.OpenDiscrepancyView();
        }
    }
}
