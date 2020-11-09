﻿using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessLayer;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessagesFacade messagesFacade = new MessagesFacade();
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {
            var form = new SendForm();
            form.ShowDialog();
            String message = form.returnMessage; //values preserved after close
            if(!message.Equals(""))
                MessageBox.Show(message);
        }
    }
}