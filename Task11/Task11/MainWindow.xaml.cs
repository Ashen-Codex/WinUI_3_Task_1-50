using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Task11
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private int _counter = 0;

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnIncrease(object sender, RoutedEventArgs e)
        {
            _counter++;
            UpdateDisplay();
        }

        private void OnDecrease(object sender, RoutedEventArgs e)
        {
            _counter--;
            UpdateDisplay();
        }

        private void OnReset(object sender, RoutedEventArgs e)
        {
            _counter = 0;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            CounterDisplay.Text = _counter.ToString();
        }
    }
}
