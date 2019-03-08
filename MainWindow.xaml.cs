using System;
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

namespace _307699_WhileStringExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            String myWorld = "Hello";
            string output = " ";
            while (myWorld.Length > 0)
            {
                output += myWorld.Substring(0, 1)
                + Environment.NewLine;
                myWorld = myWorld.Substring(1);
            }
            lblOutput.Content = output;
        }
    }
}
