using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace FII
{
	public partial class VistaPreviaCrystal: Form
	{
        private ReportDocument reporteFacturaPrevio;
        private ReportDocument reporteFactura;
        /// <summary>
        /// Constructor del Visualizador de Reportes
        /// Se visualizara el reportDocument que se pase
        /// </summary>
        /// <param name="rFactura">Report Document a visualizar</param>
		public VistaPreviaCrystal(ReportDocument rFacturaPreviu,ReportDocument rFactura)
		{
			InitializeComponent();
            reporteFactura = rFactura;
            reporteFacturaPrevio = rFacturaPreviu;
		}

        private void VistaPreviaCrystal_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            crvFactura.ReportSource = reporteFactura;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            /*ReportObject imageReport = (imageReport = reporteFactura.ReportDefinition.ReportObjects["PictureImage"]);
            if ( imageReport!= null)
            {
                imageReport.ObjectFormat.EnableSuppress=true;
            }*/

            crvFactura.ReportSource = reporteFactura;

            crvFactura.PrintReport();
        }
	}
}
