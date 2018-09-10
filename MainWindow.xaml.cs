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

namespace SDC
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            miCadastrarProduto.Click += MiCadastrarProduto_Click;
            miCadastrarCliente.Click += MiCadastrarCliente_Click;
            miPesquisarCliente.Click += MiPesquisarCliente_Click;
            miPesquisarProduto.Click += MiPesquisarProduto_Click;
        }

        #region Eventos de Tela

        private void MiPesquisarProduto_Click(object sender, RoutedEventArgs e)
        {
            ViewPesquisaProduto viewPesquisaProduto = new ViewPesquisaProduto();
            viewPesquisaProduto.ShowDialog();
        }

        private void MiPesquisarCliente_Click(object sender, RoutedEventArgs e)
        {
            ViewPesquisaCliente viewPesquisaCliente = new ViewPesquisaCliente();
            viewPesquisaCliente.ShowDialog();
        }

        private void MiCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            ViewCadastroCliente cadastroCliente = new ViewCadastroCliente();
            cadastroCliente.ShowDialog();
        }

        private void MiCadastrarProduto_Click(object sender, RoutedEventArgs e)
        {
            ViewCadastroProduto cadastroProduto = new ViewCadastroProduto();
            cadastroProduto.ShowDialog();
        }
    }
    #endregion
}
