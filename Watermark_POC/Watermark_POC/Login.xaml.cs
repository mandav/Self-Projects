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

namespace Watermark_POC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string username = (string) usertxtbx.Text;
            string password = (string)passwordbx.Password;
            if (username == "admin" && password == "hello")
            {
                ImageManager imgmanager = new ImageManager();
                App.Current.MainWindow = imgmanager;
                this.Close();
                imgmanager.Show();
            }
            else if (username == "" && password == "")
            {
                MessageBox.Show("Please enter Username and Password");
            }
            else
            {
                MessageBox.Show("Incorrect User");
            }
        }
    }
}
