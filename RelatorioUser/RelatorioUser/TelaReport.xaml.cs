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

namespace RelatorioUser
{
    /// <summary>
    /// Lógica interna para TelaReport.xaml
    /// </summary>
    public partial class TelaReport : Window
    {
        public TelaReport()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {

          
            var dadosRelatorio = new List<variaveis>();

            dadosRelatorio.Add(staticValues.values);


            ReportViewer.LocalReport.ReportEmbeddedResource = "RelatorioUser.Report.rdlc";


            #region Parametro.

            this.ReportViewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("GitHubUser", staticValues.GitHub));
            this.ReportViewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Linkedin", staticValues.Linkedin));

            string data = DateTime.Now.ToShortDateString();

            this.ReportViewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataEmi", data));

            #endregion

            var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetUsuario", dadosRelatorio);
            ReportViewer.LocalReport.DataSources.Add(dataSource);

           

            this.ReportViewer.RefreshReport();

        }
    }
}
