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
    public class Individual : Form
    {
        [AccessedThroughProperty("btnCerrar")]
        private Button _btnCerrar;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("lblComision")]
        private Label _lblComision;
        [AccessedThroughProperty("lblImporte")]
        private Label _lblImporte;
        [AccessedThroughProperty("txtPrecioInmueble")]
        private TextBox _txtPrecioInmueble;

        public Individual()
        {
            this.InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form form = this;
            Formulario.cerrarFormulario(ref form);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura(this.txtPrecioInmueble.Text, "0", "0", this.lblImporte.Text, false, decimal.Zero, null);
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.lblComision = new Label();
            this.lblImporte = new Label();
            this.txtPrecioInmueble = new TextBox();
            this.Label7 = new Label();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.btnCerrar = new Button();
            this.Button1 = new Button();
            this.SuspendLayout();
            this.lblComision.BackColor = Color.White;
            this.lblComision.BorderStyle = BorderStyle.Fixed3D;
            this.lblComision.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Point point = new Point(0xdd, 0x81);
            this.lblComision.Location = point;
            this.lblComision.Name = "lblComision";
            Size size = new Size(0xcd, 20);
            this.lblComision.Size = size;
            this.lblComision.TabIndex = 0x15;
            this.lblImporte.BackColor = Color.White;
            this.lblImporte.BorderStyle = BorderStyle.Fixed3D;
            this.lblImporte.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0x9f);
            this.lblImporte.Location = point;
            this.lblImporte.Name = "lblImporte";
            size = new Size(0xcd, 20);
            this.lblImporte.Size = size;
            this.lblImporte.TabIndex = 20;
            this.txtPrecioInmueble.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xdd, 0x61);
            this.txtPrecioInmueble.Location = point;
            this.txtPrecioInmueble.Name = "txtPrecioInmueble";
            size = new Size(0xcd, 0x1a);
            this.txtPrecioInmueble.Size = size;
            this.txtPrecioInmueble.TabIndex = 0x13;
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 130);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            size = new Size(0x4e, 20);
            this.Label7.Size = size;
            this.Label7.TabIndex = 0x12;
            this.Label7.Text = "Comision:";
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 160);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            size = new Size(0x44, 20);
            this.Label4.Size = size;
            this.Label4.TabIndex = 0x11;
            this.Label4.Text = "Importe:";
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 100);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            size = new Size(0x98, 20);
            this.Label3.Size = size;
            this.Label3.TabIndex = 0x10;
            this.Label3.Text = "Precio del Inmueble:";
            this.btnCerrar.DialogResult = DialogResult.Cancel;
            this.btnCerrar.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0x152, 0xd9);
            this.btnCerrar.Location = point;
            this.btnCerrar.Name = "btnCerrar";
            size = new Size(0x58, 30);
            this.btnCerrar.Size = size;
            this.btnCerrar.TabIndex = 0x17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.Button1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(250, 0xd9);
            this.Button1.Location = point;
            this.Button1.Name = "Button1";
            size = new Size(0x52, 30);
            this.Button1.Size = size;
            this.Button1.TabIndex = 0x16;
            this.Button1.Text = "Facturar";
            this.Button1.UseVisualStyleBackColor = true;
            SizeF ef = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            size = new Size(0x228, 0x189);
            this.ClientSize = size;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.txtPrecioInmueble);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Name = "Individual";
            this.Text = "Individual";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void txtPrecioInmueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.validacionNumero(e.KeyChar);
        }

        private void txtPrecioInmueble_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtPrecioInmueble.Text != null)
                {
                    Operaciones operaciones = new Operaciones();
                    operaciones.calcularIndividual(Conversions.ToDecimal(this.txtPrecioInmueble.Text));
                    this.lblComision.Text = operaciones.comision.ToString("###,###0.00");
                    this.lblImporte.Text = operaciones.importe.ToString("###,###0.00");
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
                EventHandler handler = new EventHandler(this.btnCerrar_Click);
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

        internal virtual Button Button1
        {
            get
            {
                return this._Button1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.Button1_Click);
                if (this._Button1 != null)
                {
                    this._Button1.Click -= handler;
                }
                this._Button1 = value;
                if (this._Button1 != null)
                {
                    this._Button1.Click += handler;
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

        internal virtual Label lblImporte
        {
            get
            {
                return this._lblImporte;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblImporte = value;
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

