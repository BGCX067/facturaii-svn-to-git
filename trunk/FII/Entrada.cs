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
    public class Entrada : Form
    {
        [AccessedThroughProperty("ArchivoToolStripMenuItem")]
        private ToolStripMenuItem _ArchivoToolStripMenuItem;
        [AccessedThroughProperty("ConAvaluosToolStripMenuItem")]
        private ToolStripMenuItem _ConAvaluosToolStripMenuItem;
        [AccessedThroughProperty("CreditoToolStripMenuItem")]
        private ToolStripMenuItem _CreditoToolStripMenuItem;
        [AccessedThroughProperty("EspecialToolStripMenuItem")]
        private ToolStripMenuItem _EspecialToolStripMenuItem;
        [AccessedThroughProperty("IndividualToolStripMenuItem")]
        private ToolStripMenuItem _IndividualToolStripMenuItem;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("SalirToolStripMenuItem")]
        private ToolStripMenuItem _SalirToolStripMenuItem;
        private IContainer components;

        public Entrada()
        {
            this.InitializeComponent();
            Formulario.abrirFormulario(new Normal(), this);
        }

        public Entrada(string archivo)
        {
            this.InitializeComponent();
            Factura factura = new Factura(archivo);
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

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Entrada));
            this.MenuStrip1 = new MenuStrip();
            this.ArchivoToolStripMenuItem = new ToolStripMenuItem();
            this.EspecialToolStripMenuItem = new ToolStripMenuItem();
            this.ConAvaluosToolStripMenuItem = new ToolStripMenuItem();
            this.IndividualToolStripMenuItem = new ToolStripMenuItem();
            this.CreditoToolStripMenuItem = new ToolStripMenuItem();
            this.SalirToolStripMenuItem = new ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.MenuStrip1.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.MenuStrip1.Items.AddRange(new ToolStripItem[] { this.ArchivoToolStripMenuItem, this.EspecialToolStripMenuItem, this.ConAvaluosToolStripMenuItem, this.IndividualToolStripMenuItem, this.CreditoToolStripMenuItem, this.SalirToolStripMenuItem });
            Point point = new Point(0, 0);
            this.MenuStrip1.Location = point;
            this.MenuStrip1.Name = "MenuStrip1";
            Size size = new Size(0x248, 0x1d);
            this.MenuStrip1.Size = size;
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            this.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem";
            size = new Size(0x81, 0x19);
            this.ArchivoToolStripMenuItem.Size = size;
            this.ArchivoToolStripMenuItem.Text = "Venta Normal";
            this.EspecialToolStripMenuItem.Name = "EspecialToolStripMenuItem";
            size = new Size(0x54, 0x19);
            this.EspecialToolStripMenuItem.Size = size;
            this.EspecialToolStripMenuItem.Text = "Especial";
            this.ConAvaluosToolStripMenuItem.Name = "ConAvaluosToolStripMenuItem";
            size = new Size(0x75, 0x19);
            this.ConAvaluosToolStripMenuItem.Size = size;
            this.ConAvaluosToolStripMenuItem.Text = "Con Avaluos";
            this.IndividualToolStripMenuItem.Name = "IndividualToolStripMenuItem";
            size = new Size(100, 0x19);
            this.IndividualToolStripMenuItem.Size = size;
            this.IndividualToolStripMenuItem.Text = "Individual";
            this.CreditoToolStripMenuItem.Name = "CreditoToolStripMenuItem";
            size = new Size(0x4e, 0x19);
            this.CreditoToolStripMenuItem.Size = size;
            this.CreditoToolStripMenuItem.Text = "Credito";
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            size = new Size(0x38, 0x19);
            this.SalirToolStripMenuItem.Size = size;
            this.SalirToolStripMenuItem.Text = "Salir";
            SizeF ef = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            size = new Size(0x248, 0x19c);
            this.ClientSize = size;
            this.Controls.Add(this.MenuStrip1);
            //this.Icon = (Icon) manager.GetObject("$this.Icon");
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip1;
            size = new Size(600, 450);
            this.MinimumSize = size;
            this.Name = "Entrada";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Facturas Inmobiliaria Irving";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str2 = sender.ToString();
            if (str2 == "Venta Normal")
            {
                Formulario.abrirFormulario(new Normal(), this);
            }
            else if (str2 == "Con Avaluos")
            {
                Formulario.abrirFormulario(new Avaluos(), this);
            }
            else if (str2 == "Individual")
            {
                Formulario.abrirFormulario(new Individual(), this);
            }
            else if (str2 == "Credito")
            {
                Formulario.abrirFormulario(new Credito(), this);
            }
            else if (str2 == "Especial")
            {
                Formulario.abrirFormulario(new Especial(), this);
            }
            else
            {
                MessageBox.Show("Hay un error");
            }
        }

        internal virtual ToolStripMenuItem ArchivoToolStripMenuItem
        {
            get
            {
                return this._ArchivoToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.ToolStripMenuItem_Click);
                if (this._ArchivoToolStripMenuItem != null)
                {
                    this._ArchivoToolStripMenuItem.Click -= handler;
                }
                this._ArchivoToolStripMenuItem = value;
                if (this._ArchivoToolStripMenuItem != null)
                {
                    this._ArchivoToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem ConAvaluosToolStripMenuItem
        {
            get
            {
                return this._ConAvaluosToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.ToolStripMenuItem_Click);
                if (this._ConAvaluosToolStripMenuItem != null)
                {
                    this._ConAvaluosToolStripMenuItem.Click -= handler;
                }
                this._ConAvaluosToolStripMenuItem = value;
                if (this._ConAvaluosToolStripMenuItem != null)
                {
                    this._ConAvaluosToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem CreditoToolStripMenuItem
        {
            get
            {
                return this._CreditoToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.ToolStripMenuItem_Click);
                if (this._CreditoToolStripMenuItem != null)
                {
                    this._CreditoToolStripMenuItem.Click -= handler;
                }
                this._CreditoToolStripMenuItem = value;
                if (this._CreditoToolStripMenuItem != null)
                {
                    this._CreditoToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem EspecialToolStripMenuItem
        {
            get
            {
                return this._EspecialToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.ToolStripMenuItem_Click);
                if (this._EspecialToolStripMenuItem != null)
                {
                    this._EspecialToolStripMenuItem.Click -= handler;
                }
                this._EspecialToolStripMenuItem = value;
                if (this._EspecialToolStripMenuItem != null)
                {
                    this._EspecialToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem IndividualToolStripMenuItem
        {
            get
            {
                return this._IndividualToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.ToolStripMenuItem_Click);
                if (this._IndividualToolStripMenuItem != null)
                {
                    this._IndividualToolStripMenuItem.Click -= handler;
                }
                this._IndividualToolStripMenuItem = value;
                if (this._IndividualToolStripMenuItem != null)
                {
                    this._IndividualToolStripMenuItem.Click += handler;
                }
            }
        }

        internal virtual MenuStrip MenuStrip1
        {
            get
            {
                return this._MenuStrip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._MenuStrip1 = value;
            }
        }

        internal virtual ToolStripMenuItem SalirToolStripMenuItem
        {
            get
            {
                return this._SalirToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.SalirToolStripMenuItem_Click);
                if (this._SalirToolStripMenuItem != null)
                {
                    this._SalirToolStripMenuItem.Click -= handler;
                }
                this._SalirToolStripMenuItem = value;
                if (this._SalirToolStripMenuItem != null)
                {
                    this._SalirToolStripMenuItem.Click += handler;
                }
            }
        }
    }
}

