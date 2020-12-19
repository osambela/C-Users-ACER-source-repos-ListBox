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

namespace ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listaPoblaciones = new List<Poblaciones>();
            listaPoblaciones.Add(new Poblaciones() { nombrePoblacion1 = "Lima", nombrePoblacion2 = "Iquitos", 
                                                     temperatura1 = 22, temperatura2 = 33, diferencia = 11 });
            listaPoblaciones.Add(new Poblaciones() { nombrePoblacion1 = "Lima", nombrePoblacion2 = "Huancayo", 
                                                     temperatura1 = 22, temperatura2 = 12, diferencia = 10
            });
            listaPoblaciones.Add(new Poblaciones() { nombrePoblacion1 = "Lima", nombrePoblacion2 = "Tumbes", 
                                                     temperatura1 = 22, temperatura2 = 28, diferencia = 6 });
            listaPoblaciones.Add(new Poblaciones() { nombrePoblacion1 = "Lima", nombrePoblacion2 = "Arequipa", 
                                                     temperatura1 = 22, temperatura2 = 14, diferencia = 8 });

            lista.ItemsSource = listaPoblaciones;
            //==================================================================================================

            List<Capitales> listaCapitales = new List<Capitales>();
            listaCapitales.Add(new Capitales { NombreCapital = "Lima" });
            listaCapitales.Add(new Capitales { NombreCapital = "Quito" });
            listaCapitales.Add(new Capitales { NombreCapital = "Buenos Aires" });
            listaCapitales.Add(new Capitales { NombreCapital = "Santiago" });
            listaCapitales.Add(new Capitales { NombreCapital = "Bogotá" });
            listaCapitales.Add(new Capitales { NombreCapital = "Carácas" });

            Poblaciones.ItemsSource = listaCapitales;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lista.SelectedItem != null)
            {
                MessageBox.Show((lista.SelectedItem as Poblaciones).nombrePoblacion1 + " " +
               (lista.SelectedItem as Poblaciones).temperatura1 + "°C - " +
               (lista.SelectedItem as Poblaciones).nombrePoblacion2 + " " +
               (lista.SelectedItem as Poblaciones).temperatura2 + "°C");
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro de la lista");
            }
               
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (lista.SelectedItem != null)
            {
                MessageBox.Show((lista.SelectedItem as Poblaciones).nombrePoblacion1 + " " +
               (lista.SelectedItem as Poblaciones).temperatura1 + "°C - " +
               (lista.SelectedItem as Poblaciones).nombrePoblacion2 + " " +
               (lista.SelectedItem as Poblaciones).temperatura2 + "°C");
            }
            else
            {
                MessageBox.Show("Debes seleccionar un registro de la lista");
            }
        }


        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            peru.IsChecked = true;
            brasil.IsChecked = true;
            chile.IsChecked = true;
            argentina.IsChecked = true;
        }
        private void UnCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            peru.IsChecked = false;
            brasil.IsChecked = false;
            chile.IsChecked = false;
            argentina.IsChecked = false;
        }

        private void Individual_Checked(object sender, RoutedEventArgs e)
        {
            if(peru.IsChecked==true && brasil.IsChecked==true && chile.IsChecked==true && argentina.IsChecked == true)
            {
                allChecked.IsChecked = true;
            }
            else
            {
                allChecked.IsChecked = null;
            }
        }
        private void Individual_NoChecked(object sender, RoutedEventArgs e)
        {
            if (peru.IsChecked == false && brasil.IsChecked == false && chile.IsChecked == false && argentina.IsChecked == false)
            {
                allChecked.IsChecked = false;
            }
            else
            {
                allChecked.IsChecked = null;
            }
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            light_red.Visibility = Visibility.Visible;
            light_ambar.Visibility = Visibility.Hidden;
            light_green.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            light_red.Visibility = Visibility.Hidden;
            light_ambar.Visibility = Visibility.Visible;
            light_green.Visibility = Visibility.Hidden;

        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            light_red.Visibility = Visibility.Hidden;
            light_ambar.Visibility = Visibility.Hidden;
            light_green.Visibility = Visibility.Visible;

        }
    }

    public class Poblaciones
    {
        public string nombrePoblacion1 { get; set; }
        public int temperatura1 { get; set; }
        public string nombrePoblacion2 { get; set; }
        public int temperatura2 { get; set; }
        
        public int diferencia { get; set; }
    }

    public class Capitales
    {
        public string NombreCapital { get; set; }
    }
}
