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

namespace Examen_Emanuel_Aguilar
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombreEmpleado.Text;
            string id = txtIdentidad.Text;
            decimal dedu = (Convert.ToDecimal(txtHorasTrabajadas.Text) * Convert.ToDecimal(txtPagoPorHora.Text));
            decimal ex = (Convert.ToDecimal(txtHorasExtras.Text) * Convert.ToDecimal(txtPagoHorasExtras.Text));
            decimal IH = (((Convert.ToDecimal(txtHorasTrabajadas.Text) * Convert.ToDecimal(txtPagoPorHora.Text)) * Convert.ToDecimal(0.04)));
            decimal RA = (((Convert.ToDecimal(txtHorasTrabajadas.Text) * Convert.ToDecimal(txtPagoPorHora.Text)) * Convert.ToDecimal(0.035)));
            decimal PT = ((dedu+ex)-(IH+RA));
            MessageBox.Show("Nombre: "+nombre+"\nIdentidad: "+id+"\nSueldo sin deducciones: "+dedu+"\nSueldo Horas Extras: "+ex+"\nDeducciones IHSS: "+IH+ "\nDeducciones RAP: " + RA + "\nPago Total: "+ PT);
        }
    }
}
