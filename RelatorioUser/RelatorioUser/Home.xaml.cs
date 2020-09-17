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

namespace RelatorioUser
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void PnlLeft_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnTeste_Click(object sender, RoutedEventArgs e)
        {
            // Valores pessoais
            staticValues.values.profi = txtProf.Text;
            staticValues.values.nome = txtNome.Text;
            staticValues.values.telefone = txtNumero.Text;
            staticValues.values.email = txtEmail.Text;
            //

            staticValues.values.introducao = txtIntroducao.Text;

            staticValues.values.experiencias = txtexperiencias.Text;

            staticValues.values.resumo = txtResumo.Text;

            staticValues.values.conclusao = txtCoclu.Text;

            // Variáveis para parametros Report

            staticValues.Linkedin = txtLinkedin.Text;

            staticValues.GitHub = txtGitHub.Text;

            //

            TelaReport reportTela = new TelaReport();

            reportTela.ShowDialog();
        }

        #region Links Copy

        private void BtnCopyLinkedin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtLinkedin.Text = Clipboard.GetText();
        }

        private void BtnCopyGitHub_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtGitHub.Text = Clipboard.GetText();
        }


        #endregion

        private void GridRight_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
