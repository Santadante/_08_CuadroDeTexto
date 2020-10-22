using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace _08_CuadroDeTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = ayudaNombreTextBlock;
            ApellidosTextBox.Tag = ayudaApellidosTextBlock;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            TextBlock ayuda = (TextBlock)tb.Tag; 

            if (e.Key == Key.F1 && ayuda.Visibility == Visibility.Hidden)
                ayuda.Visibility = Visibility.Visible;
            else if (e.Key == Key.F1)
                ayuda.Visibility = Visibility.Hidden;
        }

        private void edadTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2 && !Regex.IsMatch(edadTextBox.Text, "^[0-9]+$"))
                comprobarEdadTextBlock.Text = "Edad Incorrecta";
            else if(e.Key == Key.F2)
                comprobarEdadTextBlock.Text = "";
        }
    }
}
