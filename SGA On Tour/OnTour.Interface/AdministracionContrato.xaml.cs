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
using System.Windows.Shapes;

namespace OnTour.Interface
{
    /// <summary>
    /// Lógica de interacción para RegistrosMonetarios.xaml
    /// </summary>
    public partial class AdministracionContrato : UserControl
    {
        public AdministracionContrato()
        {
            InitializeComponent();
        }

        private void BtnAgrega_Click(object sender, RoutedEventArgs e)
        {
            Contrato contrato = new Contrato();
            contrato.Show();
        }

        private void BtnModifica_Click(object sender, RoutedEventArgs e)
        {
            Contrato contrato = new Contrato();
            contrato.Show();
        }
    }
}
