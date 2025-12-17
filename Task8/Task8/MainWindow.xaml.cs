using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Windows.UI;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Task8
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public ElementTheme RequestedTheme { get; private set; }

        private void OnThemeToggled(object sender, RoutedEventArgs e)
        {
            if (ThemeToggle.IsOn)
            {
                // Темный режим
                RequestedTheme = ElementTheme.Dark;
                StatusBlock.Text = "Текущая тема: Темная";
                ThemePreview.Fill = new SolidColorBrush(Color.FromArgb(255, 32, 32, 32));
            }
            else
            {
                // Светлый режим
                RequestedTheme = ElementTheme.Light;
                StatusBlock.Text = "Текущая тема: Светлая";
                ThemePreview.Fill = new SolidColorBrush(Colors.White);
            }
        }
    }
}
