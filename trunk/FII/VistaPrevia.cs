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
    public class VistaPrevia : Form
    {
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("Button2")]
        private Button _Button2;
        [AccessedThroughProperty("Button3")]
        private Button _Button3;
        [AccessedThroughProperty("ppcFactura")]
        private PrintPreviewControl _ppcFactura;
        private Impresion impresion;

        public VistaPrevia(Impresion impresion)
        {
            base.FormClosing += new FormClosingEventHandler(this.cerrarForm);
            this.InitializeComponent();
            this.impresion = impresion;
            impresion.previsualisacion = true;
            this.ppcFactura.Document = impresion.impresion;
            this.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.impresion.previsualisacion = true;
            this.impresion.impresion.DefaultPageSettings.Color = false;
            this.impresion.impresion.Print();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.impresion.previsualisacion = true;
            this.impresion.impresion.DefaultPageSettings.Color = true;
            this.impresion.impresion.Print();
        }

        private void cerrarForm(object sender, FormClosingEventArgs e)
        {
            this.impresion.previsualisacion = false;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.ppcFactura = new PrintPreviewControl();
            this.Button1 = new Button();
            this.Button2 = new Button();
            this.Button3 = new Button();
            this.SuspendLayout();
            this.ppcFactura.AutoZoom = false;
            this.ppcFactura.BackgroundImageLayout = ImageLayout.None;
            Point point = new Point(12, 12);
            this.ppcFactura.Location = point;
            this.ppcFactura.Name = "ppcFactura";
            Size size = new Size(0x338, 0x20e);
            this.ppcFactura.Size = size;
            this.ppcFactura.TabIndex = 0;
            this.ppcFactura.Zoom = 1.0;
            this.Button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0xa5, 0x220);
            this.Button1.Location = point;
            this.Button1.Name = "Button1";
            size = new Size(0xa2, 0x3d);
            this.Button1.Size = size;
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Imprimir Vista Previa en Blanco y Negro";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0x1e6, 0x220);
            this.Button2.Location = point;
            this.Button2.Name = "Button2";
            size = new Size(0x87, 0x3d);
            this.Button2.Size = size;
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Cerrar";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point = new Point(0x14d, 0x220);
            this.Button3.Location = point;
            this.Button3.Name = "Button3";
            size = new Size(0x93, 0x3d);
            this.Button3.Size = size;
            this.Button3.TabIndex = 3;
            this.Button3.Text = "Imprimir Vista Previa a Color";
            this.Button3.UseVisualStyleBackColor = true;
            SizeF ef = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            size = new Size(0x34f, 0x269);
            this.ClientSize = size;
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ppcFactura);
            this.Name = "VistaPrevia";
            this.Text = "VistaPrevia";
            this.ResumeLayout(false);
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

        internal virtual Button Button2
        {
            get
            {
                return this._Button2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.Button2_Click);
                if (this._Button2 != null)
                {
                    this._Button2.Click -= handler;
                }
                this._Button2 = value;
                if (this._Button2 != null)
                {
                    this._Button2.Click += handler;
                }
            }
        }

        internal virtual Button Button3
        {
            get
            {
                return this._Button3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.Button3_Click);
                if (this._Button3 != null)
                {
                    this._Button3.Click -= handler;
                }
                this._Button3 = value;
                if (this._Button3 != null)
                {
                    this._Button3.Click += handler;
                }
            }
        }

        internal virtual PrintPreviewControl ppcFactura
        {
            get
            {
                return this._ppcFactura;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ppcFactura = value;
            }
        }
    }
}

