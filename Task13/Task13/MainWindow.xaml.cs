using System;
using System.Timers;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Task13
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private Timer _progressTimer;
        private double _progress = 0;

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnStart(object sender, RoutedEventArgs e)
        {
            if (_progress >= 100)
            {
                OnReset(null, null);
            }

            StartButton.IsEnabled = false;

            _progressTimer = new Timer(100); // Обновление каждые 100 мс
            _progressTimer.Elapsed += (s, args) =>
            {
                _progress += 5; // Увеличиваем на 5% каждый раз

                DispatcherQueue.TryEnqueue(() =>
                {
                    MyProgressBar.Value = _progress;
                    ProgressText.Text = $"{(int)_progress}%";

                    if (_progress >= 100)
                    {
                        _progressTimer.Stop();
                        StartButton.IsEnabled = true;
                    }
                });
            };
            _progressTimer.Start();
        }

        private void OnReset(object sender, RoutedEventArgs e)
        {
            _progress = 0;
            MyProgressBar.Value = 0;
            ProgressText.Text = "0%";
            StartButton.IsEnabled = true;
        }
    }
}
