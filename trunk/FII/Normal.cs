namespace FII
{
    using FacturaDLL;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Normal : Form
    {
        [AccessedThroughProperty("btnCerrar")]
        private Button _btnCerrar;
        [AccessedThroughProperty("btnFacturar")]
        private Button _btnFacturar;
        [AccessedThroughProperty("chkNoReferido")]
        private RadioButton _chkNoReferido;
        [AccessedThroughProperty("chkReferido")]
        private RadioButton _chkReferido;
        [AccessedThroughProperty("cmbTipoInmueble")]
        private ComboBox _cmbTipoInmueble;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("lblComision")]
        private Label _lblComision;
        [AccessedThroughProperty("lblIngreso")]
        private Label _lblIngreso;
        [AccessedThroughProperty("lblIva")]
        private Label _lblIva;
        [AccessedThroughProperty("lblRetencion")]
        private Label _lblRetencion;
        [AccessedThroughProperty("lblTotal")]
        private Label _lblTotal;
        [AccessedThroughProperty("txtPrecioInmueble")]
        private TextBox _txtPrecioInmueble;
        private IContainer components;
        private Operaciones operaciones;

        public Normal()
        {
            base.Load += new EventHandler(this.Normal_Load);
            this.operaciones = new Operaciones();
            this.InitializeComponent();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura(this.lblIngreso.Text, this.lblIva.Text, this.lblRetencion.Text, this.lblTotal.Text, false, decimal.Zero, null);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form form = this;
            Formulario.cerrarFormulario(ref form);
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtPrecioInmueble.Text != null)
                {
                    this.operaciones.calcularNormal(this.cmbTipoInmueble.SelectedIndex, this.chkNoReferido.Checked, Conversions.ToDecimal(this.txtPrecioInmueble.Text));
                    this.lblComision.Text = this.operaciones.comision.ToString("#%");
                    this.lblIngreso.Text = this.operaciones.ingreso.ToString("$###,##0.00");
                    this.lblIva.Text = this.operaciones.iva.ToString("$###,##0.00");
                    this.lblRetencion.Text = this.operaciones.retencion.ToString("$###,##0.00");
                    this.lblTotal.Text = this.operaciones.total.ToString("$###,##0.00");
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                ProjectData.ClearProjectError();
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.components != null))
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.Label5 = new Label();
            this.Label6 = new Label();
            this.Label7 = new Label();
            this.Label8 = new Label();
            this.txtPrecioInmueble = new TextBox();
            this.chkNoReferido = new RadioButton();
            this.chkReferido = new RadioButton();
            this.cmbTipoInmueble = new ComboBox();
            this.lblTotal = new Label();
            this.lblComision = new Label();
            this.lblRetencion = new Label();
            this.lblIva = new Label();
            this.lblIngreso = new Label();
            this.btnFacturar = new Button();
            this.btnCerrar = new Button();
            this.SuspendLayout();
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Point point = new Point(50, 100);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            Size size = new Size(50, 20);
            this.Label1.Size = size;
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Caso:";
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 130);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            size = new Size(0x87, 20);
            this.Label2.Size = size;
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Tipo de Inmueble:";
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 160);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            size = new Size(0x98, 20);
            this.Label3.Size = size;
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Precio del Inmueble:";
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 220);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            size = new Size(0x43, 20);
            this.Label4.Size = size;
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Ingreso:";
            this.Label5.AutoSize = true;
            this.Label5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 250);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            size = new Size(0x22, 20);
            this.Label5.Size = size;
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Iva:";
            this.Label6.AutoSize = true;
            this.Label6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 280);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            size = new Size(0x56, 20);
            this.Label6.Size = size;
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Retencion:";
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 190);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            size = new Size(0x4e, 20);
            this.Label7.Size = size;
            this.Label7.TabIndex = 6;
            this.Label7.Text = "Comision:";
            this.Label8.AutoSize = true;
            this.Label8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 310);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            size = new Size(0x30, 20);
            this.Label8.Size = size;
            this.Label8.TabIndex = 7;
            this.Label8.Text = "Total:";
            this.txtPrecioInmueble.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0x9d);
            this.txtPrecioInmueble.Location = point;
            this.txtPrecioInmueble.Name = "txtPrecioInmueble";
            size = new Size(0xcd, 0x1a);
            this.txtPrecioInmueble.Size = size;
            this.txtPrecioInmueble.TabIndex = 8;
            this.chkNoReferido.AutoSize = true;
            this.chkNoReferido.Checked = true;
            this.chkNoReferido.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0x62);
            this.chkNoReferido.Location = point;
            this.chkNoReferido.Name = "chkNoReferido";
            size = new Size(0x70, 0x18);
            this.chkNoReferido.Size = size;
            this.chkNoReferido.TabIndex = 9;
            this.chkNoReferido.TabStop = true;
            this.chkNoReferido.Text = "No Referido";
            this.chkNoReferido.UseVisualStyleBackColor = true;
            this.chkReferido.AutoSize = true;
            this.chkReferido.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0x152, 0x62);
            this.chkReferido.Location = point;
            this.chkReferido.Name = "chkReferido";
            size = new Size(0x58, 0x18);
            this.chkReferido.Size = size;
            this.chkReferido.TabIndex = 10;
            this.chkReferido.Text = "Referido";
            this.chkReferido.UseVisualStyleBackColor = true;
            this.cmbTipoInmueble.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbTipoInmueble.FormattingEnabled = true;
            this.cmbTipoInmueble.Items.AddRange(new object[] { "Casa", "Departamento", "Terreno Urbano", "Bodega", "Local Comercial", "Hotel", "Empresa", "Nave Industrial", "Oficinas", "Ranchos", "Terrenos Rusticos" });
            point = new Point(0xdd, 0x7f);
            this.cmbTipoInmueble.Location = point;
            this.cmbTipoInmueble.Name = "cmbTipoInmueble";
            size = new Size(0xcd, 0x1c);
            this.cmbTipoInmueble.Size = size;
            this.cmbTipoInmueble.TabIndex = 11;
            this.lblTotal.BackColor = Color.White;
            this.lblTotal.BorderStyle = BorderStyle.Fixed3D;
            this.lblTotal.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0x135);
            this.lblTotal.Location = point;
            this.lblTotal.Name = "lblTotal";
            size = new Size(0xcd, 20);
            this.lblTotal.Size = size;
            this.lblTotal.TabIndex = 0x10;
            this.lblComision.BackColor = Color.White;
            this.lblComision.BorderStyle = BorderStyle.Fixed3D;
            this.lblComision.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0xbd);
            this.lblComision.Location = point;
            this.lblComision.Name = "lblComision";
            size = new Size(0xcd, 20);
            this.lblComision.Size = size;
            this.lblComision.TabIndex = 15;
            this.lblComision.Text = "0%";
            this.lblRetencion.BackColor = Color.White;
            this.lblRetencion.BorderStyle = BorderStyle.Fixed3D;
            this.lblRetencion.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0x117);
            this.lblRetencion.Location = point;
            this.lblRetencion.Name = "lblRetencion";
            size = new Size(0xcd, 20);
            this.lblRetencion.Size = size;
            this.lblRetencion.TabIndex = 14;
            this.lblIva.BackColor = Color.White;
            this.lblIva.BorderStyle = BorderStyle.Fixed3D;
            this.lblIva.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0xf9);
            this.lblIva.Location = point;
            this.lblIva.Name = "lblIva";
            size = new Size(0xcd, 20);
            this.lblIva.Size = size;
            this.lblIva.TabIndex = 13;
            this.lblIngreso.BackColor = Color.White;
            this.lblIngreso.BorderStyle = BorderStyle.Fixed3D;
            this.lblIngreso.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0xdb);
            this.lblIngreso.Location = point;
            this.lblIngreso.Name = "lblIngreso";
            size = new Size(0xcd, 20);
            this.lblIngreso.Size = size;
            this.lblIngreso.TabIndex = 12;
            this.btnFacturar.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xf5, 0x15d);
            this.btnFacturar.Location = point;
            this.btnFacturar.Name = "btnFacturar";
            size = new Size(0x58, 30);
            this.btnFacturar.Size = size;
            this.btnFacturar.TabIndex = 0x11;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnCerrar.DialogResult = DialogResult.Cancel;
            this.btnCerrar.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(340, 0x15c);
            this.btnCerrar.Location = point;
            this.btnCerrar.Name = "btnCerrar";
            size = new Size(0x58, 30);
            this.btnCerrar.Size = size;
            this.btnCerrar.TabIndex = 0x12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            SizeF ef = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            size = new Size(0x259, 0x197);
            this.ClientSize = size;
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblRetencion);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.cmbTipoInmueble);
            this.Controls.Add(this.chkReferido);
            this.Controls.Add(this.chkNoReferido);
            this.Controls.Add(this.txtPrecioInmueble);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Normal";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Normal";
            this.WindowState = FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Normal_Load(object sender, EventArgs e)
        {
            this.cmbTipoInmueble.SelectedIndex = 0;
        }

        private void txtPrecioInmueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.validacionNumero(e.KeyChar);
        }

        internal virtual Button btnCerrar
        {
            get
            {
                return this._btnCerrar;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.Button1_Click);
                if (this._btnCerrar != null)
                {
                    this._btnCerrar.Click -= handler;
                }
                this._btnCerrar = value;
                if (this._btnCerrar != null)
                {
                    this._btnCerrar.Click += handler;
                }
            }
        }

        internal virtual Button btnFacturar
        {
            get
            {
                return this._btnFacturar;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnFacturar_Click);
                if (this._btnFacturar != null)
                {
                    this._btnFacturar.Click -= handler;
                }
                this._btnFacturar = value;
                if (this._btnFacturar != null)
                {
                    this._btnFacturar.Click += handler;
                }
            }
        }

        internal virtual RadioButton chkNoReferido
        {
            get
            {
                return this._chkNoReferido;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.CheckedChanged);
                if (this._chkNoReferido != null)
                {
                    this._chkNoReferido.CheckedChanged -= handler;
                }
                this._chkNoReferido = value;
                if (this._chkNoReferido != null)
                {
                    this._chkNoReferido.CheckedChanged += handler;
                }
            }
        }

        internal virtual RadioButton chkReferido
        {
            get
            {
                return this._chkReferido;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.CheckedChanged);
                if (this._chkReferido != null)
                {
                    this._chkReferido.CheckedChanged -= handler;
                }
                this._chkReferido = value;
                if (this._chkReferido != null)
                {
                    this._chkReferido.CheckedChanged += handler;
                }
            }
        }

        internal virtual ComboBox cmbTipoInmueble
        {
            get
            {
                return this._cmbTipoInmueble;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.CheckedChanged);
                if (this._cmbTipoInmueble != null)
                {
                    this._cmbTipoInmueble.SelectedIndexChanged -= handler;
                }
                this._cmbTipoInmueble = value;
                if (this._cmbTipoInmueble != null)
                {
                    this._cmbTipoInmueble.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual Label Label1
        {
            get
            {
                return this._Label1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label1 = value;
            }
        }

        internal virtual Label Label2
        {
            get
            {
                return this._Label2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label2 = value;
            }
        }

        internal virtual Label Label3
        {
            get
            {
                return this._Label3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label3 = value;
            }
        }

        internal virtual Label Label4
        {
            get
            {
                return this._Label4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label4 = value;
            }
        }

        internal virtual Label Label5
        {
            get
            {
                return this._Label5;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label5 = value;
            }
        }

        internal virtual Label Label6
        {
            get
            {
                return this._Label6;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label6 = value;
            }
        }

        internal virtual Label Label7
        {
            get
            {
                return this._Label7;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label7 = value;
            }
        }

        internal virtual Label Label8
        {
            get
            {
                return this._Label8;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label8 = value;
            }
        }

        internal virtual Label lblComision
        {
            get
            {
                return this._lblComision;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblComision = value;
            }
        }

        internal virtual Label lblIngreso
        {
            get
            {
                return this._lblIngreso;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblIngreso = value;
            }
        }

        internal virtual Label lblIva
        {
            get
            {
                return this._lblIva;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblIva = value;
            }
        }

        internal virtual Label lblRetencion
        {
            get
            {
                return this._lblRetencion;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblRetencion = value;
            }
        }

        internal virtual Label lblTotal
        {
            get
            {
                return this._lblTotal;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblTotal = value;
            }
        }

        internal virtual TextBox txtPrecioInmueble
        {
            get
            {
                return this._txtPrecioInmueble;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.txtPrecioInmueble_KeyPress);
                EventHandler handler2 = new EventHandler(this.CheckedChanged);
                if (this._txtPrecioInmueble != null)
                {
                    this._txtPrecioInmueble.KeyPress -= handler;
                    this._txtPrecioInmueble.TextChanged -= handler2;
                }
                this._txtPrecioInmueble = value;
                if (this._txtPrecioInmueble != null)
                {
                    this._txtPrecioInmueble.KeyPress += handler;
                    this._txtPrecioInmueble.TextChanged += handler2;
                }
            }
        }
    }
}

