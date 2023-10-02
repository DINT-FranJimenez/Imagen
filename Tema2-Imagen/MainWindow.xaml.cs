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

namespace Tema2_Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void RellenoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(rellenoRadioButton.IsChecked == true){
                imagenImage.Stretch = Stretch.Fill;
            }
        }

        private void UniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(uniformeRadioButton.IsChecked == true)
            {
                imagenImage.Stretch = Stretch.Uniform;
            }

        }

        private void RellenoUniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(rellenoUniformeRadioButton.IsChecked == true)
            {
                imagenImage.Stretch = Stretch.UniformToFill;
            }
        }

        private void SinAjustesRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(sinAjustesRadioButton.IsChecked == true)
            {
                imagenImage.Stretch = Stretch.None;
            }
        }

        private void OpacidadAlta_Checked(object sender, RoutedEventArgs e)
        {
            if (altaRadioButton.IsChecked == true)
            {
                imagenImage.Opacity = 1;
            }
        }

        private void OpacidadMedia_Checked(object sender, RoutedEventArgs e)
        {
            if (mediaRadioButton.IsChecked == true)
            {
                imagenImage.Opacity = 0.6;
            }
        }

        private void OpacidadBaja_Checked(object sender, RoutedEventArgs e)
        {
            if (bajaRadioButton.IsChecked == true)
            {
                imagenImage.Opacity = 0.3;
            }
        }
    }
}
