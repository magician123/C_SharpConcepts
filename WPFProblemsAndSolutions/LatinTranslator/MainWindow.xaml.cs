using System.Windows;

namespace LatinTranslator
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

        private void buttonSinister_Click(object sender, RoutedEventArgs e)
        {
            labelSinister.Content = "left";

        }

        private void buttonDexter_Click(object sender, RoutedEventArgs e)
        {
            labelDexter.Content = "right";

        }

        private void buttonMedium_Click(object sender, RoutedEventArgs e)
        {
            labelMedium.Content = "center";
        }
    }
}
