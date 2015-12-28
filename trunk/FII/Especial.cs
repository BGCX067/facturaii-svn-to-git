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
    public class Especial : Form
    {
        [AccessedThroughProperty("btnCerrar")]
        private Button _btnCerrar;
        [AccessedThroughProperty("btnFacturar")]
        private Button _btnFacturar;
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
        [AccessedThroughProperty("lblIngreso")]
        private Label _lblIngreso;
        [AccessedThroughProperty("lblIva")]
        private Label _lblIva;
        [AccessedThroughProperty("lblRetencion")]
        private Label _lblRetencion;
        [AccessedThroughProperty("lblTotal")]
        private Label _lblTotal;
        [AccessedThroughProperty("txtComision")]
        private TextBox _txtComision;
        [AccessedThroughProperty("txtPrecioInmueble")]
        private TextBox _txtPrecioInmueble;
        private IContainer components;
        private Operaciones operaciones = new Operaciones();

        public Especial()
        {
            this.InitializeComponent();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura(this.txtPrecioInmueble.Text, this.lblIva.Text, this.lblRetencion.Text, this.lblTotal.Text, false, decimal.Zero, null);
        }

        private void cerrar(object sender, EventArgs e)
        {
            Form form = this;
            Formulario.cerrarFormulario(ref form);
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
            this.btnCerrar = new Button();
            this.btnFacturar = new Button();
            this.lblTotal = new Label();
            this.lblRetencion = new Label();
            this.lblIva = new Label();
            this.lblIngreso = new Label();
            this.Label8 = new Label();
            this.Label7 = new Label();
            this.Label6 = new Label();
            this.Label5 = new Label();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.txtPrecioInmueble = new TextBox();
            this.txtComision = new TextBox();
            this.SuspendLayout();
            this.btnCerrar.DialogResult = DialogResult.Cancel;
            this.btnCerrar.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Point point = new Point(340, 0x120);
            this.btnCerrar.Location = point;
            this.btnCerrar.Name = "btnCerrar";
            Size size = new Size(0x58, 30);
            this.btnCerrar.Size = size;
            this.btnCerrar.TabIndex = 0x20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnFacturar.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xf5, 0x121);
            this.btnFacturar.Location = point;
            this.btnFacturar.Name = "btnFacturar";
            size = new Size(0x58, 30);
            this.btnFacturar.Size = size;
            this.btnFacturar.TabIndex = 0x1f;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.lblTotal.BackColor = Color.White;
            this.lblTotal.BorderStyle = BorderStyle.Fixed3D;
            this.lblTotal.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0xf9);
            this.lblTotal.Location = point;
            this.lblTotal.Name = "lblTotal";
            size = new Size(0xcd, 20);
            this.lblTotal.Size = size;
            this.lblTotal.TabIndex = 30;
            this.lblRetencion.BackColor = Color.White;
            this.lblRetencion.BorderStyle = BorderStyle.Fixed3D;
            this.lblRetencion.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0xdb);
            this.lblRetencion.Location = point;
            this.lblRetencion.Name = "lblRetencion";
            size = new Size(0xcd, 20);
            this.lblRetencion.Size = size;
            this.lblRetencion.TabIndex = 0x1c;
            this.lblIva.BackColor = Color.White;
            this.lblIva.BorderStyle = BorderStyle.Fixed3D;
            this.lblIva.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0xbd);
            this.lblIva.Location = point;
            this.lblIva.Name = "lblIva";
            size = new Size(0xcd, 20);
            this.lblIva.Size = size;
            this.lblIva.TabIndex = 0x1b;
            this.lblIngreso.BackColor = Color.White;
            this.lblIngreso.BorderStyle = BorderStyle.Fixed3D;
            this.lblIngreso.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0x9f);
            this.lblIngreso.Location = point;
            this.lblIngreso.Name = "lblIngreso";
            size = new Size(0xcd, 20);
            this.lblIngreso.Size = size;
            this.lblIngreso.TabIndex = 0x1a;
            this.Label8.AutoSize = true;
            this.Label8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 250);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            size = new Size(0x30, 20);
            this.Label8.Size = size;
            this.Label8.TabIndex = 0x18;
            this.Label8.Text = "Total:";
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 130);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            size = new Size(0x4e, 20);
            this.Label7.Size = size;
            this.Label7.TabIndex = 0x17;
            this.Label7.Text = "Comision:";
            this.Label6.AutoSize = true;
            this.Label6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 220);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            size = new Size(0x56, 20);
            this.Label6.Size = size;
            this.Label6.TabIndex = 0x16;
            this.Label6.Text = "Retencion:";
            this.Label5.AutoSize = true;
            this.Label5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 190);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            size = new Size(0x22, 20);
            this.Label5.Size = size;
            this.Label5.TabIndex = 0x15;
            this.Label5.Text = "Iva:";
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 160);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            size = new Size(0x43, 20);
            this.Label4.Size = size;
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Ingreso:";
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 100);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            size = new Size(0x98, 20);
            this.Label3.Size = size;
            this.Label3.TabIndex = 0x13;
            this.Label3.Text = "Precio del Inmueble:";
            this.txtPrecioInmueble.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0x61);
            this.txtPrecioInmueble.Location = point;
            this.txtPrecioInmueble.Name = "txtPrecioInmueble";
            size = new Size(0xcd, 0x1a);
            this.txtPrecioInmueble.Size = size;
            this.txtPrecioInmueble.TabIndex = 0x19;
            this.txtComision.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0x7f);
            this.txtComision.Location = point;
            this.txtComision.Name = "txtComision";
            size = new Size(0xcd, 0x1a);
            this.txtComision.Size = size;
            this.txtComision.TabIndex = 0x21;
            SizeF ef = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            size = new Size(0x264, 0x171);
            this.ClientSize = size;
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRetencion);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.txtPrecioInmueble);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Name = "Especial";
            this.Text = "Especial";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void tecleo(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.validacionNumero(e.KeyChar);
        }

        private void txtPrecioInmueble_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((this.txtComision.Text != null) & (this.txtPrecioInmueble.Text != null))
                {
                    this.operaciones.calcularEspecial(Conversions.ToDecimal(this.txtPrecioInmueble.Text), Conversions.ToDecimal(this.txtComision.Text));
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

        internal virtual Button btnCerrar
        {
            get
            {
                return this._btnCerrar;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cerrar);
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

        internal virtual TextBox txtComision
        {
            get
            {
                return this._txtComision;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.tecleo);
                EventHandler handler2 = new EventHandler(this.txtPrecioInmueble_TextChanged);
                if (this._txtComision != null)
                {
                    this._txtComision.KeyPress -= handler;
                    this._txtComision.TextChanged -= handler2;
                }
                this._txtComision = value;
                if (this._txtComision != null)
                {
                    this._txtComision.KeyPress += handler;
                    this._txtComision.TextChanged += handler2;
                }
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
                KeyPressEventHandler handler = new KeyPressEventHandler(this.tecleo);
                EventHandler handler2 = new EventHandler(this.txtPrecioInmueble_TextChanged);
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

