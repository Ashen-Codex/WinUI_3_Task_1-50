using System;
using System.Timers;
using Microsoft.UI.Xaml;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Task2
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private Timer _timer;

        public MainWindow()
        {
            this.InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            _timer = new Timer(1000); // Обновляться каждые 1000 мс
            _timer.Elapsed += (s, e) =>
            {
                // Обновление на главном потоке UI
                DispatcherQueue.TryEnqueue(() =>
                {
                    TimeBlock.Text = DateTime.Now.ToString("HH:mm:ss");
                });
            };
            _timer.Start();

            // Установить начальное время
            TimeBlock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
