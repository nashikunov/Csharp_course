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

namespace ComponentInteraction
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClickCounter _counter = new ClickCounter();

        public MainWindow()
        {
            InitializeComponent();

            var buttonWindow = new ButtonWindow(_counter);           
            //buttonWindow.MainWindow = this;
            _counter.OnCounterChanged += UpdateCounter; // += и дальше метод который ловит
            
            buttonWindow.Show();

        }


        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Title = $"{Width} - {Height}";
        }

        public void UpdateCounter(int clickCount)
        {
            textBlockInfo.Text = $"Button clicked {clickCount} times";
        }
    }
}
