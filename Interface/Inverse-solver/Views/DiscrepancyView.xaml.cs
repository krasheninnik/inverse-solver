﻿using Inverse_solver.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Inverse_solver.Views
{
    /// <summary>
    /// Interaction logic for DiscrepancyView.xaml
    /// </summary>
    public partial class DiscrepancyView : Window
    {
        public DiscrepancyView()
        {
            InitializeComponent();
        }

        void On_Closing(object sender, CancelEventArgs e)
        {
            (this.DataContext as TaskViewModel).DiscrepancyViewOpened = false;
            this.DataContext = null;
        }
    }
}
