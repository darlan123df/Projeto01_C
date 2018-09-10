using SDC.Controller;
using SDC.Model;
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
    /// Lógica interna para ViewCadastroProduto.xaml
    /// </summary>
    public partial class ViewCadastroProduto : Window
    {
        Ibpt ibpt;
        ProdutoController produtoController = new ProdutoController();

        public ViewCadastroProduto()
        {
            InitializeComponent();
            btImportaNcmProduto.Click += TbImportaNcmProduto_Click;
            btGravarProduto.Click += BtGravarProduto_Click;
        }

        private void BtGravarProduto_Click(object sender, RoutedEventArgs e)
        {
            Produto produto = new Produto();

            produto.descricaoProduto = tbDescricaoProduto.Text;
            produto.estoqueAtualProduto = Int32.Parse(tbEstoqueAtual.Text);
            produto.precoVendaproduto = Double.Parse(tbPrecoVenda.Text);
            produto.ncmProduto = Int32.Parse(tbNcm.Text);
            ibpt.ibptImpostoFederal = ibpt.ibptImpostoFederal;
            ibpt.ibptImpostoEstadual = ibpt.ibptImpostoEstadual;
            ibpt.ibptImpostoMunicipal = ibpt.ibptImpostoMunicipal;

            produtoController.GravarProduto(produto);
        }

        private void TbImportaNcmProduto_Click(object sender, RoutedEventArgs e)
        {
            PercentualDeImpostoController percentualDeImposto = new PercentualDeImpostoController();
            ibpt = percentualDeImposto.importadadosIBPT(tbNcm.Text);

            tbImpostoFederal.Text = ibpt.ibptImpostoFederal.ToString();
            tbImpostoEstadual.Text = ibpt.ibptImpostoEstadual.ToString();
            tbImpostoMunicipal.Text = ibpt.ibptImpostoMunicipal.ToString();
        }
    }
}
