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
    public class Credito : Form
    {
        [AccessedThroughProperty("btnCerrar")]
        private Button _btnCerrar;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("lblImporte")]
        private Label _lblImporte;
        private IContainer components;
        private Operaciones operaciones = new Operaciones();
        private TextBoxOnlyNumber txtCredito;

        public Credito()
        {
            this.InitializeComponent();
            this.txtCredito.TextChanged += new EventHandler(this.txtCredito_TextChanged);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura(this.lblImporte.Text, "0", "0", this.lblImporte.Text, false, decimal.Zero, null);
        }

        private void cerrarForm(object sender, EventArgs e)
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
            this.lblImporte = new Label();
            this.Label7 = new Label();
            this.Label3 = new Label();
            this.btnCerrar = new Button();
            this.Button1 = new Button();
            this.txtCredito = new TextBoxOnlyNumber();
            this.SuspendLayout();
            this.lblImporte.BackColor = Color.White;
            this.lblImporte.BorderStyle = BorderStyle.Fixed3D;
            this.lblImporte.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Point point = new Point(0xde, 0x81);
            this.lblImporte.Location = point;
            this.lblImporte.Name = "lblImporte";
            Size size = new Size(0xcd, 20);
            this.lblImporte.Size = size;
            this.lblImporte.TabIndex = 0x19;
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0x33, 130);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            size = new Size(0x44, 20);
            this.Label7.Size = size;
            this.Label7.TabIndex = 0x17;
            this.Label7.Text = "Importe:";
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0x33, 100);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            size = new Size(0x40, 20);
            this.Label3.Size = size;
            this.Label3.TabIndex = 0x16;
            this.Label3.Text = "Credito:";
            this.btnCerrar.DialogResult = DialogResult.Cancel;
            this.btnCerrar.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0x153, 0xb9);
            this.btnCerrar.Location = point;
            this.btnCerrar.Name = "btnCerrar";
            size = new Size(0x58, 30);
            this.btnCerrar.Size = size;
            this.btnCerrar.TabIndex = 0x1b;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.Button1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xfb, 0xb9);
            this.Button1.Location = point;
            this.Button1.Name = "Button1";
            size = new Size(0x52, 30);
            this.Button1.Size = size;
            this.Button1.TabIndex = 0x1a;
            this.Button1.Text = "Facturar";
            this.Button1.UseVisualStyleBackColor = true;
            this.txtCredito.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xde, 0x61);
            this.txtCredito.Location = point;
            this.txtCredito.Name = "txtCredito";
            size = new Size(0xcd, 0x1a);
            this.txtCredito.Size = size;
            this.txtCredito.TabIndex = 0x1c;
            SizeF ef = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            size = new Size(0x272, 0x173);
            this.ClientSize = size;
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label3);
            this.Name = "Credito";
            this.Text = "Credito";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void txtCredito_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.operaciones.calcularCredito(Conversions.ToDecimal(this.txtCredito.Text));
                this.lblImporte.Text = this.operaciones.importe.ToString("###,###0.00");
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
                EventHandler handler = new EventHandler(this.cerrarForm);
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
    }
}

