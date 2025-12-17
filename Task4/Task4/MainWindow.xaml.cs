// MainWindow.xaml.cs
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Task4
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private int _colorIndex = 0;
        private Color[] _colors = new[]
        {
        Color.FromArgb(255, 255, 0, 0),     // Красный
        Color.FromArgb(255, 0, 128, 0),     // Зеленый
        Color.FromArgb(255, 0, 0, 255)      // Синий
    };
        private string[] _colorNames = new[] { "Красный", "Зеленый", "Синий" };

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnColorChange(object sender, RoutedEventArgs e)
        {
            _colorIndex = (_colorIndex + 1) % _colors.Length;

            RootGrid.Background = new SolidColorBrush(_colors[_colorIndex]);
            ColorLabel.Text = _colorNames[_colorIndex];
        }
    }
}
