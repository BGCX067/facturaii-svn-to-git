using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Serialization;
using CrystalDecisions.CrystalReports.Engine;

namespace FacturaDLL
{
    public enum FormatPrint
    {
        PDF
    }
    public class Impresion : IDisposable
    {
        [AccessedThroughProperty("impresion")]
        private PrintDocument _impresion;
        private string año;
        private string cantidad;
        private string ciudad;        
        private string descripcion;
        private string dia;
        private string domicilio;
        private string folio;
        private string importe;
        private string iva;
        private string lugar;
        private string mes;
        private string nombre;
        private string precioLetra;
        private string precioU;
        public bool previsualisacion;
        private PrintDialog propiedadesImpresion;
        private string retencion;
        private string rfc;
        private string total;
#region Propiedades
        public string Año { get { return año; } set { año = value; } }
        public string Cantidad { get { return cantidad; } set { cantidad = value; } }
        public string Ciudad { get { return ciudad; } set { ciudad = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Dia { get { return dia; } set { dia = value; } }
        public string Domicilio { get { return domicilio; } set { domicilio = value; } }
        public string Folio { get { return folio; } set { folio = value; } }
        public string Importe { get { return importe; } set { importe = value; } }
        public string Iva { get { return iva; } set { iva = value; } }
        public string Lugar { get { return lugar; } set { lugar = value; } }
        public string Mes { get { return mes; } set { mes = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Precio { get { return precioLetra; } set { precioLetra = value; } }
        public string PrecioUnitario { get { return precioU; } set { precioLetra = value; } }
        public bool Previsualizacion { get { return previsualisacion; } set { previsualisacion = value; } }
        public string Retencion { get { return retencion; } set { retencion = value; } }
        public string RFC { get { return rfc; } set { rfc = value; } }
        public string Total { get { return total; } set { total = value; } }
#endregion
        public Impresion(string nombre, string domicilio, string ciudad, string rfc, string lugar, DateTime fecha, string descripcion, string importe, string iva, string retencion, string total, string precioL, decimal cantidad, string precioU, [Optional, DefaultParameterValue(false)] bool previsualisacion, [Optional, DefaultParameterValue("")] string folio)
        {
            this.impresion = new PrintDocument();
            this.propiedadesImpresion = new PrintDialog();
            this.folio = folio;
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.domicilio = domicilio;
            this.rfc = rfc;
            this.lugar = lugar;
            this.descripcion = descripcion;
            this.importe = importe;
            this.iva = iva;
            this.retencion = retencion;
            this.total = total;
            this.precioLetra = precioL;
            this.cantidad = cantidad.ToString();
            this.precioU = precioU;
            this.dia = fecha.Day.ToString();
            this.mes = fecha.Month.ToString();
            this.año = fecha.Year.ToString();
            this.previsualisacion = previsualisacion;
        }
        /// <summary>
        /// Metodo que genera un ReportDocument
        /// </summary>
        public ReportDocument GetReportDocumentPrevius()
        {
            try
            {
                var informe = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                informe.Load("Impresion Factura Previo.rpt");
                informe.SetParameterValue("Nombre", nombre);
                informe.SetParameterValue("Folio", folio);
                informe.SetParameterValue("Año", año);
                informe.SetParameterValue("Mes", mes);
                informe.SetParameterValue("Dia", dia);
                informe.SetParameterValue("Cantidad", cantidad);
                informe.SetParameterValue("Ciudad", ciudad);
                informe.SetParameterValue("Domicilio", domicilio);
                informe.SetParameterValue("IVA", iva);
                informe.SetParameterValue("Lugar", lugar);
                informe.SetParameterValue("PrecioLetra", precioLetra);
                informe.SetParameterValue("PrecioUnitario", precioU);
                informe.SetParameterValue("Previsualizacion", previsualisacion);
                informe.SetParameterValue("Retencion", retencion);
                informe.SetParameterValue("RFC", rfc);
                informe.SetParameterValue("Total", total);
                informe.SetParameterValue("Importe", importe);
                informe.SetParameterValue("Descripcion", descripcion);

                return informe;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ReportDocument GetReportDocument()
        {
            try
            {
                var informe = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                informe.Load("Impresion Factura.rpt");
                informe.SetParameterValue("Nombre", nombre);
                informe.SetParameterValue("Folio", folio);
                informe.SetParameterValue("Año", año);
                informe.SetParameterValue("Mes", mes);
                informe.SetParameterValue("Dia", dia);
                informe.SetParameterValue("Cantidad", cantidad);
                informe.SetParameterValue("Ciudad", ciudad);
                informe.SetParameterValue("Domicilio", domicilio);
                informe.SetParameterValue("IVA", iva);
                informe.SetParameterValue("Lugar", lugar);
                informe.SetParameterValue("PrecioLetra", precioLetra);
                informe.SetParameterValue("PrecioUnitario", precioU);
                informe.SetParameterValue("Previsualizacion", previsualisacion);
                informe.SetParameterValue("Retencion", retencion);
                informe.SetParameterValue("RFC", rfc);
                informe.SetParameterValue("Total", total);
                informe.SetParameterValue("Importe", importe);
                informe.SetParameterValue("Descripcion", descripcion);

                return informe;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void dialogImpresora(bool imprimir)
        {
            this.propiedadesImpresion.Document = this.impresion;
            if (this.propiedadesImpresion.ShowDialog() == DialogResult.OK)
            {
                this.impresion.PrinterSettings = this.propiedadesImpresion.PrinterSettings;
                if (imprimir)
                {
                    this.impresion.Print();
                }
            }
        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {
            if (this.previsualisacion)
            {
                e.Graphics.DrawImage(Image.FromFile("factura.jpg"), 0, 0);
                e.Graphics.DrawString("No " + this.folio, new Font("Arial", 12f, FontStyle.Bold), Brushes.Red, (float) 670f, (float) 55f);
            }
            e.Graphics.DrawString(this.nombre, new Font("Arial", 9f), Brushes.Black, (float) 120f, (float) 108f);
            e.Graphics.DrawString(this.domicilio, new Font("Arial", 9f), Brushes.Black, (float) 120f, (float) 130f);
            e.Graphics.DrawString(this.ciudad, new Font("Arial", 9f), Brushes.Black, (float) 120f, (float) 155f);
            e.Graphics.DrawString(this.rfc, new Font("Arial", 9f), Brushes.Black, (float) 450f, (float) 155f);
            e.Graphics.DrawString(this.lugar, new Font("Arial", 9f), Brushes.Black, (float) 650f, (float) 100f);
            e.Graphics.DrawString(this.dia, new Font("Arial", 9f), Brushes.Black, (float) 630f, (float) 155f);
            e.Graphics.DrawString(this.mes, new Font("Arial", 9f), Brushes.Black, (float) 690f, (float) 155f);
            e.Graphics.DrawString(this.año, new Font("Arial", 9f), Brushes.Black, (float) 740f, (float) 155f);
            e.Graphics.DrawString(this.descripcion, new Font("Arial", 7f), Brushes.Black, (float) 100f, (float) 205f);
            e.Graphics.DrawString(this.importe, new Font("Arial", 9f), Brushes.Black, (float) 700f, (float) 210f);
            e.Graphics.DrawString(this.importe, new Font("Arial", 9f), Brushes.Black, (float) 700f, (float) 390f);
            e.Graphics.DrawString(this.iva, new Font("Arial", 9f), Brushes.Black, (float) 700f, (float) 405f);
            e.Graphics.DrawString(this.retencion, new Font("Arial", 9f), Brushes.Black, (float) 700f, (float) 425f);
            e.Graphics.DrawString(this.total, new Font("Arial", 9f), Brushes.Black, (float) 700f, (float) 440f);
            e.Graphics.DrawString(this.precioLetra, new Font("Arial", 7f), Brushes.Black, (float) 240f, (float) 400f);
            e.Graphics.DrawString(this.cantidad, new Font("Arial", 9f), Brushes.Black, (float) 60f, (float) 210f);
            e.Graphics.DrawString(this.precioU, new Font("Arial", 9f), Brushes.Black, (float) 600f, (float) 210f);
        }

        public virtual PrintDocument impresion
        {
            [DebuggerNonUserCode]
            get
            {
                return this._impresion;
            }
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                PrintPageEventHandler handler = new PrintPageEventHandler(this.imprimir);
                if (this._impresion != null)
                {
                    this._impresion.PrintPage -= handler;
                }
                this._impresion = value;
                if (this._impresion != null)
                {
                    this._impresion.PrintPage += handler;
                }
            }
        }

        #region Miembros de IDisposable

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}

