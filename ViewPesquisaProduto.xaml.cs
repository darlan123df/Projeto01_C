using SDC.BancoDados;
using SDC.Controller;
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

namespace SDC
{
    /// <summary>
    /// Lógica interna para ViewPesquisaProduto.xaml
    /// </summary>
    public partial class ViewPesquisaProduto : Window
    {
        ProdutoController produtoController = new ProdutoController();
        BancoContext bancoContext = new BancoContext();

        public ViewPesquisaProduto()
        {
            InitializeComponent();
            btBuscarProduto.Click += BtBuscarProduto_Click;
        }

        #region Eventos da tela
        private void BtBuscarProduto_Click(object sender, RoutedEventArgs e)
        {
            listar(tbPesquisarProduto.Text);
        }

        #endregion

        #region Funções

        private void listar(string valorDigitado)
        {
            //Lista na DataGrid As informações da Lista de Objetos.
            //dgListaDePesquisaProduto.Items.Clear();
            if(valorDigitado == null)
            {
                MessageBox.Show("Digite um valor valido para pesquisa!");
            }
            else
            {
                dgListaDePesquisaProduto.ItemsSource = produtoController.ListarProdutos(valorDigitado);
            }
            
        }

        #endregion

    }



}
