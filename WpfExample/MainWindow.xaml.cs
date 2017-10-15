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
using WpfExample.ViewModels;

namespace WpfExample
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MantenimientoDeProductoVM mantenimientoDeProductoVm = new MantenimientoDeProductoVM();
        public MainWindow()
        {
            InitializeComponent();
            mantenimientoDeProductoVm.CargarProductos();
            this.DataContext = mantenimientoDeProductoVm;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.mantenimientoDeProductoVm.GrabarProducto();
        }
    }
}
