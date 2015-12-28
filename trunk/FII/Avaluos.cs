namespace FII
{
    using FacturaDLL;
    using Microsoft.VisualBasic.CompilerServices;
    using Rock;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class Avaluos : Form
    {
        [AccessedThroughProperty("btnCerrar")]
        private Button _btnCerrar;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("lblImporte")]
        private Label _lblImporte;
        [AccessedThroughProperty("lblIva")]
        private Label _lblIva;
        [AccessedThroughProperty("lblTotal")]
        private Label _lblTotal;
        [AccessedThroughProperty("nupCantidad")]
        private NumericUpDown _nupCantidad;
        private Operaciones operaciones = new Operaciones();
        private TextBoxOnlyNumber txtHonorario;

        public Avaluos()
        {
            this.InitializeComponent();
            this.txtHonorario.TextChanged += new EventHandler(this.calculosAvaluos);
            this.nupCantidad.Maximum = 79228162514264337593543950335M;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form form = this;
            Formulario.cerrarFormulario(ref form);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura(this.lblImporte.Text, this.lblIva.Text, "", this.lblTotal.Text, true, this.nupCantidad.Value, this.txtHonorario.Text);
        }

        private void calculosAvaluos(object sender, EventArgs e)
        {
            try
            {
                if (this.txtHonorario.Text != null)
                {
                    this.operaciones.calcularAvaluo(Conversions.ToDecimal(this.txtHonorario.Text), this.nupCantidad.Value);
                    this.lblImporte.Text = this.operaciones.importe.ToString("$###,###0.00");
                    this.lblIva.Text = this.operaciones.iva.ToString("$###,###0.00");
                    this.lblTotal.Text = this.operaciones.total.ToString("$###,###0.00");
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                ProjectData.ClearProjectError();
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.Label7 = new Label();
            this.Label4 = new Label();
            this.Label3 = new Label();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.nupCantidad = new NumericUpDown();
            this.lblIva = new Label();
            this.lblTotal = new Label();
            this.lblImporte = new Label();
            this.Button1 = new Button();
            this.btnCerrar = new Button();
            this.txtHonorario = new TextBoxOnlyNumber();
            this.nupCantidad.BeginInit();
            this.SuspendLayout();
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Point point = new Point(50, 190);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            Size size = new Size(0x22, 20);
            this.Label7.Size = size;
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Iva:";
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 220);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            size = new Size(0x30, 20);
            this.Label4.Size = size;
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Total:";
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 160);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            size = new Size(0x44, 20);
            this.Label3.Size = size;
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Importe:";
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 130);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            size = new Size(0x4d, 20);
            this.Label2.Size = size;
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Cantidad:";
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(50, 100);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            size = new Size(0x5b, 20);
            this.Label1.Size = size;
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Honorarios:";
            this.nupCantidad.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(220, 0x80);
            this.nupCantidad.Location = point;
            decimal num = new decimal(new int[] { 0x3e7, 0, 0, 0 });
            this.nupCantidad.Maximum = num;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.nupCantidad.Minimum = num;
            this.nupCantidad.Name = "nupCantidad";
            size = new Size(0x88, 0x1a);
            this.nupCantidad.Size = size;
            this.nupCantidad.TabIndex = 13;
            num = new decimal(new int[] { 1, 0, 0, 0 });
            this.nupCantidad.Value = num;
            this.lblIva.BackColor = Color.White;
            this.lblIva.BorderStyle = BorderStyle.Fixed3D;
            this.lblIva.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(220, 0xbd);
            this.lblIva.Location = point;
            this.lblIva.Name = "lblIva";
            size = new Size(0x88, 20);
            this.lblIva.Size = size;
            this.lblIva.TabIndex = 0x10;
            this.lblTotal.BackColor = Color.White;
            this.lblTotal.BorderStyle = BorderStyle.Fixed3D;
            this.lblTotal.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(220, 0xdb);
            this.lblTotal.Location = point;
            this.lblTotal.Name = "lblTotal";
            size = new Size(0x88, 20);
            this.lblTotal.Size = size;
            this.lblTotal.TabIndex = 15;
            this.lblImporte.BackColor = Color.White;
            this.lblImporte.BorderStyle = BorderStyle.Fixed3D;
            this.lblImporte.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(220, 0xa1);
            this.lblImporte.Location = point;
            this.lblImporte.Name = "lblImporte";
            size = new Size(0x88, 20);
            this.lblImporte.Size = size;
            this.lblImporte.TabIndex = 14;
            this.Button1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(180, 0x10f);
            this.Button1.Location = point;
            this.Button1.Name = "Button1";
            size = new Size(0x52, 30);
            this.Button1.Size = size;
            this.Button1.TabIndex = 0x11;
            this.Button1.Text = "Facturar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new EventHandler(this.Button1_Click);
            this.btnCerrar.DialogResult = DialogResult.Cancel;
            this.btnCerrar.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0x10c, 0x10f);
            this.btnCerrar.Location = point;
            this.btnCerrar.Name = "btnCerrar";
            size = new Size(0x58, 30);
            this.btnCerrar.Size = size;
            this.btnCerrar.TabIndex = 0x13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.txtHonorario.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(220, 100);
            this.txtHonorario.Location = point;
            this.txtHonorario.Name = "txtHonorario";
            size = new Size(0x88, 0x1a);
            this.txtHonorario.Size = size;
            this.txtHonorario.TabIndex = 20;
            SizeF ef = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            size = new Size(0x1ca, 0x16d);
            this.ClientSize = size;
            this.ControlBox = false;
            this.Controls.Add(this.txtHonorario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.nupCantidad);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "Avaluos";
            this.Text = "Avaluos";
            this.WindowState = FormWindowState.Maximized;
            this.nupCantidad.EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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

        internal virtual NumericUpDown nupCantidad
        {
            get
            {
                return this._nupCantidad;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.calculosAvaluos);
                if (this._nupCantidad != null)
                {
                    this._nupCantidad.ValueChanged -= handler;
                }
                this._nupCantidad = value;
                if (this._nupCantidad != null)
                {
                    this._nupCantidad.ValueChanged += handler;
                }
            }
        }
    }
}

