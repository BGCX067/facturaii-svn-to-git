using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dialogos;
using FacturaDLL;
using Microsoft.VisualBasic.CompilerServices;

namespace FII
{
    public partial class Factura : Form
    {
        private bool cambio;
        private FileIO fileIO;
        private CuadroDeDialogos.OFile oFile;
        private CuadroDeDialogos.SFile sFile;
        private TextBox[] textboxs;
        private bool tipoFactura;

        public Factura(string archivo)
        {
            InitializeComponent();
            base.FormClosing += new FormClosingEventHandler(this.cerradoForm);
            base.Load += new EventHandler(this.Factura_Load);
            this.oFile = new CuadroDeDialogos.OFile("Archivos Fac|*.fac", ".fac", CuadroDeDialogos.tipoDialogo.openFileD, true);
            this.sFile = new CuadroDeDialogos.SFile("Archivos Fac|*.fac", ".fac", CuadroDeDialogos.tipoDialogo.saveFileD, true);
            this.cambio = false;
            this.InitializeComponent();
            this.lectura(archivo);
            this.cambiarEstado(false);
            this.ShowDialog();
        }

        public Factura(string importe, string iva, string retencion, string total, [Optional, DefaultParameterValue(false)] bool tipoF, [Optional, DecimalConstant(0, 0, (uint) 0, (uint) 0, (uint) 0)] decimal cantidad, [Optional, DefaultParameterValue(null)] string precioU)
        {
            base.FormClosing += new FormClosingEventHandler(this.cerradoForm);
            base.Load += new EventHandler(this.Factura_Load);
            this.oFile = new CuadroDeDialogos.OFile("Archivos Fac|*.fac", ".fac", CuadroDeDialogos.tipoDialogo.openFileD, true);
            this.sFile = new CuadroDeDialogos.SFile("Archivos Fac|*.fac", ".fac", CuadroDeDialogos.tipoDialogo.saveFileD, true);
            this.cambio = false;
            this.InitializeComponent();
            this.nupCantidad.Maximum = decimal.MaxValue;
            this.txtImporte.Text = importe;
            this.txtIVA.Text = iva;
            this.txtRetencion.Text = retencion;
            this.txtTotal.Text = total;
            this.txtPrecioU.Text = precioU;
            this.nupCantidad.Value = cantidad;
            this.tipoFactura = tipoF;
            if (!tipoF)
            {
                this.oFile = new CuadroDeDialogos.OFile("Archivos Fac|*.fac;*.txt", ".fac", CuadroDeDialogos.tipoDialogo.openFileD, false);
            }
            //this.txtPrecioU.Enabled = tipoF;
            //this.nupCantidad.Enabled = tipoF;
            this.textboxs = new TextBox[] { this.txtImporte, this.txtIVA, this.txtRetencion, this.txtTotal, this.txtPrecioU };
            foreach (Control control in textboxs)
            {
                if (control is TextBox)
                {
                    if (!String.IsNullOrEmpty(control.Text))
                    {
                        if (!control.Text.Substring(0, 1).Equals("$"))
                        {
                            control.Text = "$" + control.Text;
                        }
                    }
                    else
                    {
                        control.Text = "$0.00";
                    }
                }
            }
            this.cambiarEstado(false);
            this.ShowDialog();
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
        }

        private void cambiarEstado(bool cambio)
        {
            if (!this.cambio & cambio)
            {
                this.cambio = cambio;
                this.Text = this.Text + "*";
            }
            else
            {
                this.cambio = cambio;
                this.Text.Replace("*", "");
            }
        }

        private void cambioForm(object sender, EventArgs e)
        {
            if (!this.cambio)
            {
                this.Text = this.Text + "*";
                this.cambio = true;
            }
        }

        private void cambios(object sender, EventArgs e)
        {
            this.cambiarEstado(true);
        }

        private void cerradoForm(object sender, FormClosingEventArgs e)
        {
            if (this.cambio)
            {
                this.DialogResult = MessageBox.Show("A realizado cambios, \n¿Desea guardar la factura?", "Guardado", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (this.DialogResult == DialogResult.Yes)
                {
                    this.escritura();
                    this.Text.Replace("*", "");
                }
                else if (this.DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void escritura()
        {
            if (this.sFile.showDialog() == DialogResult.OK)
            {
                this.fileIO = new FileIO(this.sFile.nombreArchivo, new string[] { this.txtFolio.Text, this.txtNombre.Text, this.txtDomicilio.Text, this.txtCiudad.Text, this.txtRFC.Text, this.txtLugar.Text, this.dtFecha.Value.ToShortDateString(), this.nupCantidad.Value.ToString(), this.txtPrecioU.Text, this.txtDescripcion.Text, this.txtImporte.Text, this.txtIVA.Text, this.txtRetencion.Text, this.txtTotal.Text, this.txtPrecioL.Text });
                if (!this.fileIO.escribirDatos())
                {
                    MessageBox.Show("Error al guardar archivo");
                }
            }
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            this.txtFolio.Focus();
        }

        private void lectura(string[] datos)
        {
            try
            {
                this.txtFolio.Text = datos[0];
                this.txtNombre.Text = datos[1];
                this.txtDomicilio.Text = datos[2];
                this.txtCiudad.Text = datos[3];
                this.txtRFC.Text = datos[4];
                this.txtLugar.Text = datos[5];
                this.dtFecha.Value = Convert.ToDateTime(datos[6]);
                this.nupCantidad.Value = Conversions.ToDecimal(datos[7]);
                this.txtPrecioU.Text = datos[8];
                this.txtDescripcion.Text = datos[9];
                this.txtImporte.Text = datos[10];
                this.txtIVA.Text = datos[11];
                this.txtRetencion.Text = datos[12];
                this.txtTotal.Text = datos[13];
                this.txtPrecioL.Text = datos[14];
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                MessageBox.Show("Archivo Invalido", "Archivo No Valido");
                ProjectData.ClearProjectError();
            }
        }

        private void lectura([Optional, DefaultParameterValue("")] string archivo)
        {
            FileIO eio;
            if (archivo.Equals(""))
            {
                if (this.oFile.showDialog() == DialogResult.OK)
                {
                    eio = new FileIO(this.oFile.nombreArchivo);
                    this.lectura(eio.datos);
                }
            }
            else
            {
                eio = new FileIO(archivo);
                this.lectura(eio.datos);
            }
        }

        private void lecturaEscrituraClick(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(RuntimeHelpers.GetObjectValue(sender), this.AbrirToolStripMenuItem))
            {
                this.lectura("");
            }
            else if (object.ReferenceEquals(RuntimeHelpers.GetObjectValue(sender), this.GuardarToolStripMenuItem))
            {
                this.escritura();
            }
            this.cambiarEstado(false);
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Enabled = false;
            try
            {
                if (!this.txtPrecioL.Text.Equals("( PESOS 00/100 M.N )") & !this.txtPrecioL.Text.Equals(""))
                {
                    Impresion impresion = new Impresion(this.txtNombre.Text, this.txtDomicilio.Text, this.txtCiudad.Text, this.txtRFC.Text,
                        this.txtLugar.Text, this.dtFecha.Value, this.txtDescripcion.Text, this.txtImporte.Text, this.txtIVA.Text,
                        this.txtRetencion.Text, this.txtTotal.Text, this.txtPrecioL.Text, this.nupCantidad.Value, this.txtPrecioU.Text,
                        false, this.txtFolio.Text);

                    VistaPreviaCrystal vistaPrevia = new VistaPreviaCrystal(impresion.GetReportDocumentPrevius(),impresion.GetReportDocument());

                    vistaPrevia.ShowDialog();

                    vistaPrevia.Dispose();

                    impresion.Dispose();
                }
                else
                {
                    MessageBox.Show("Falta llenar el campo PRECIO CON LETRA", "Precio Con Letra");
                }
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(@"C:/Debug.log" + Environment.NewLine, ex.Message);

                MessageBox.Show("A ocurrido un error al generar la factura, contacte al Administrador");
            }
            finally
            {
                btnImprimir.Enabled = true;
            }
        }

        private void _SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}

