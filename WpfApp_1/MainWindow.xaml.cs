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
using Entity;

namespace WpfApp_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            // Crear una instancia de la clase de entidad Product
            Product product = new Product();
            product.Name = "Nombre del Producto";
            product.Price = 19.99M;

            // Puedes utilizar la instancia de la clase de entidad en este contexto
            // Por ejemplo, mostrar datos en la interfaz de usuario
            MessageBox.Show($"Nombre: {product.Name}, Precio: {product.Price}");
        }
        private void HacerAlgo_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para lo que sucede cuando se hace clic en el botón "Hacer algo"
        }
    }
}
