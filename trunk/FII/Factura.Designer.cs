using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;
using System;

namespace FII
{
    public partial class Factura : Form
    {
        
        private ToolStripMenuItem _AbrirToolStripMenuItem;
        
        private ToolStripMenuItem _ArchivoToolStripMenuItem;

        private Button btnImprimir;
       
        private ToolStripMenuItem _CerrarToolStripMenuItem;

        private DateTimePicker _dtFecha;

        private ToolStripMenuItem _GuardarToolStripMenuItem;
        
        private Label _Label1;       
        private Label _Label10;        
        private Label _Label11;       
        private Label _Label12;        
        private Label _Label13;        
        private Label _Label14;        
        private Label _Label15;        
        private Label _Label2;        
        private Label _Label3;

        private Label _Label4;
        private Label _Label5;
        private Label _Label6;
        private Label _Label7;
        private Label _Label8;
        private Label _Label9;
        private MenuStrip _MenuStrip1;
        private NumericUpDown _nupCantidad;
        private ToolStripMenuItem _SalirToolStripMenuItem;
        private TextBox _txtCiudad;
        private TextBox _txtDescripcion;
        private TextBox _txtDomicilio;
        private TextBox _txtFolio;
        private TextBox _txtImporte;
        private TextBox _txtIVA;
        private TextBox _txtLugar;
        private TextBox _txtNombre;
        private TextBox _txtPrecioL;
        private TextBox _txtPrecioU;
        private TextBox _txtRetencion;
        private TextBox _txtRFC;
        private TextBox _txtTotal;

        #region Propiedades
        protected ToolStripMenuItem AbrirToolStripMenuItem
        {
            get
            {
                return this._AbrirToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.lecturaEscrituraClick);
                if (this._AbrirToolStripMenuItem != null)
                {
                    this._AbrirToolStripMenuItem.Click -= handler;
                }
                this._AbrirToolStripMenuItem = value;
                if (this._AbrirToolStripMenuItem != null)
                {
                    this._AbrirToolStripMenuItem.Click += handler;
                }
            }
        }

        protected ToolStripMenuItem ArchivoToolStripMenuItem
        {
            get
            {
                return this._ArchivoToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ArchivoToolStripMenuItem = value;
            }
        }

        protected Button btnVistaPrevia
        {
            get
            {
                return this._btnVistaPrevia;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnVistaPrevia_Click);
                if (this._btnVistaPrevia != null)
                {
                    this._btnVistaPrevia.Click -= handler;
                }
                this._btnVistaPrevia = value;
                if (this._btnVistaPrevia != null)
                {
                    this._btnVistaPrevia.Click += handler;
                }
            }
        }

        protected DateTimePicker dtFecha
        {
            get
            {
                return this._dtFecha;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._dtFecha != null)
                {
                    this._dtFecha.ValueChanged -= handler;
                    this._dtFecha.ValueChanged -= handler2;
                }
                this._dtFecha = value;
                if (this._dtFecha != null)
                {
                    this._dtFecha.ValueChanged += handler;
                    this._dtFecha.ValueChanged += handler2;
                }
            }
        }

        protected ToolStripMenuItem GuardarToolStripMenuItem
        {
            get
            {
                return this._GuardarToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.lecturaEscrituraClick);
                if (this._GuardarToolStripMenuItem != null)
                {
                    this._GuardarToolStripMenuItem.Click -= handler;
                }
                this._GuardarToolStripMenuItem = value;
                if (this._GuardarToolStripMenuItem != null)
                {
                    this._GuardarToolStripMenuItem.Click += handler;
                }
            }
        }

        protected Label Label1
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

        protected Label Label10
        {
            get
            {
                return this._Label10;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label10 = value;
            }
        }

        protected Label Label11
        {
            get
            {
                return this._Label11;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label11 = value;
            }
        }

        protected Label Label12
        {
            get
            {
                return this._Label12;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label12 = value;
            }
        }

        protected Label Label13
        {
            get
            {
                return this._Label13;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label13 = value;
            }
        }

        protected Label Label14
        {
            get
            {
                return this._Label14;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label14 = value;
            }
        }

        protected Label Label15
        {
            get
            {
                return this._Label15;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label15 = value;
            }
        }

        protected Label Label2
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

        protected Label Label3
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

        protected Label Label4
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

        protected Label Label5
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

        protected Label Label6
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

        protected Label Label7
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

        protected Label Label8
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

        protected Label Label9
        {
            get
            {
                return this._Label9;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label9 = value;
            }
        }

        protected MenuStrip MenuStrip1
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

        protected NumericUpDown nupCantidad
        {
            get
            {
                return this._nupCantidad;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._nupCantidad != null)
                {
                    this._nupCantidad.ValueChanged -= handler;
                    this._nupCantidad.ValueChanged -= handler2;
                }
                this._nupCantidad = value;
                if (this._nupCantidad != null)
                {
                    this._nupCantidad.ValueChanged += handler;
                    this._nupCantidad.ValueChanged += handler2;
                }
            }
        }

        protected ToolStripMenuItem SalirToolStripMenuItem
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

        protected TextBox txtCiudad
        {
            get
            {
                return this._txtCiudad;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._txtCiudad != null)
                {
                    this._txtCiudad.TextChanged -= handler;
                    this._txtCiudad.TextChanged -= handler2;
                }
                this._txtCiudad = value;
                if (this._txtCiudad != null)
                {
                    this._txtCiudad.TextChanged += handler;
                    this._txtCiudad.TextChanged += handler2;
                }
            }
        }

        protected TextBox txtDescripcion
        {
            get
            {
                return this._txtDescripcion;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._txtDescripcion != null)
                {
                    this._txtDescripcion.TextChanged -= handler;
                    this._txtDescripcion.TextChanged -= handler2;
                }
                this._txtDescripcion = value;
                if (this._txtDescripcion != null)
                {
                    this._txtDescripcion.TextChanged += handler;
                    this._txtDescripcion.TextChanged += handler2;
                }
            }
        }

        protected TextBox txtDomicilio
        {
            get
            {
                return this._txtDomicilio;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._txtDomicilio != null)
                {
                    this._txtDomicilio.TextChanged -= handler;
                    this._txtDomicilio.TextChanged -= handler2;
                }
                this._txtDomicilio = value;
                if (this._txtDomicilio != null)
                {
                    this._txtDomicilio.TextChanged += handler;
                    this._txtDomicilio.TextChanged += handler2;
                }
            }
        }

        protected TextBox txtFolio
        {
            get
            {
                return this._txtFolio;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtFolio = value;
            }
        }

        protected TextBox txtImporte
        {
            get
            {
                return this._txtImporte;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._txtImporte != null)
                {
                    this._txtImporte.TextChanged -= handler;
                    this._txtImporte.TextChanged -= handler2;
                }
                this._txtImporte = value;
                if (this._txtImporte != null)
                {
                    this._txtImporte.TextChanged += handler;
                    this._txtImporte.TextChanged += handler2;
                }
            }
        }

        protected TextBox txtIVA
        {
            get
            {
                return this._txtIVA;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._txtIVA != null)
                {
                    this._txtIVA.TextChanged -= handler;
                    this._txtIVA.TextChanged -= handler2;
                }
                this._txtIVA = value;
                if (this._txtIVA != null)
                {
                    this._txtIVA.TextChanged += handler;
                    this._txtIVA.TextChanged += handler2;
                }
            }
        }

        protected TextBox txtLugar
        {
            get
            {
                return this._txtLugar;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._txtLugar != null)
                {
                    this._txtLugar.TextChanged -= handler;
                    this._txtLugar.TextChanged -= handler2;
                }
                this._txtLugar = value;
                if (this._txtLugar != null)
                {
                    this._txtLugar.TextChanged += handler;
                    this._txtLugar.TextChanged += handler2;
                }
            }
        }

        protected TextBox txtNombre
        {
            get
            {
                return this._txtNombre;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._txtNombre != null)
                {
                    this._txtNombre.TextChanged -= handler;
                    this._txtNombre.TextChanged -= handler2;
                }
                this._txtNombre = value;
                if (this._txtNombre != null)
                {
                    this._txtNombre.TextChanged += handler;
                    this._txtNombre.TextChanged += handler2;
                }
            }
        }

        protected TextBox txtPrecioL
        {
            get
            {
                return this._txtPrecioL;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._txtPrecioL != null)
                {
                    this._txtPrecioL.TextChanged -= handler;
                    this._txtPrecioL.TextChanged -= handler2;
                }
                this._txtPrecioL = value;
                if (this._txtPrecioL != null)
                {
                    this._txtPrecioL.TextChanged += handler;
                    this._txtPrecioL.TextChanged += handler2;
                }
            }
        }

        protected TextBox txtPrecioU
        {
            get
            {
                return this._txtPrecioU;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._txtPrecioU != null)
                {
                    this._txtPrecioU.TextChanged -= handler;
                    this._txtPrecioU.TextChanged -= handler2;
                }
                this._txtPrecioU = value;
                if (this._txtPrecioU != null)
                {
                    this._txtPrecioU.TextChanged += handler;
                    this._txtPrecioU.TextChanged += handler2;
                }
            }
        }

        protected TextBox txtRetencion
        {
            get
            {
                return this._txtRetencion;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._txtRetencion != null)
                {
                    this._txtRetencion.TextChanged -= handler;
                    this._txtRetencion.TextChanged -= handler2;
                }
                this._txtRetencion = value;
                if (this._txtRetencion != null)
                {
                    this._txtRetencion.TextChanged += handler;
                    this._txtRetencion.TextChanged += handler2;
                }
            }
        }

        protected TextBox txtRFC
        {
            get
            {
                return this._txtRFC;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambios);
                EventHandler handler3 = new EventHandler(this.cambioForm);
                if (this._txtRFC != null)
                {
                    this._txtRFC.TextChanged -= handler;
                    this._txtRFC.TextChanged -= handler2;
                    this._txtRFC.TextChanged -= handler3;
                }
                this._txtRFC = value;
                if (this._txtRFC != null)
                {
                    this._txtRFC.TextChanged += handler;
                    this._txtRFC.TextChanged += handler2;
                    this._txtRFC.TextChanged += handler3;
                }
            }
        }

        protected TextBox txtTotal
        {
            get
            {
                return this._txtTotal;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cambios);
                EventHandler handler2 = new EventHandler(this.cambioForm);
                if (this._txtTotal != null)
                {
                    this._txtTotal.TextChanged -= handler;
                    this._txtTotal.TextChanged -= handler2;
                }
                this._txtTotal = value;
                if (this._txtTotal != null)
                {
                    this._txtTotal.TextChanged += handler;
                    this._txtTotal.TextChanged += handler2;
                }
            }
        }
#endregion

        private void InitializeComponent()
        {
            this._Label1 = new System.Windows.Forms.Label();
            this._Label2 = new System.Windows.Forms.Label();
            this._Label3 = new System.Windows.Forms.Label();
            this._Label4 = new System.Windows.Forms.Label();
            this._Label5 = new System.Windows.Forms.Label();
            this._Label6 = new System.Windows.Forms.Label();
            this._Label7 = new System.Windows.Forms.Label();
            this._Label8 = new System.Windows.Forms.Label();
            this._Label9 = new System.Windows.Forms.Label();
            this._Label10 = new System.Windows.Forms.Label();
            this._Label11 = new System.Windows.Forms.Label();
            this._Label12 = new System.Windows.Forms.Label();
            this._Label13 = new System.Windows.Forms.Label();
            this._Label14 = new System.Windows.Forms.Label();
            this._MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this._ArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._AbrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._GuardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._CerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtDomicilio = new System.Windows.Forms.TextBox();
            this._txtCiudad = new System.Windows.Forms.TextBox();
            this._txtRFC = new System.Windows.Forms.TextBox();
            this._txtLugar = new System.Windows.Forms.TextBox();
            this._txtPrecioU = new System.Windows.Forms.TextBox();
            this._txtDescripcion = new System.Windows.Forms.TextBox();
            this._txtImporte = new System.Windows.Forms.TextBox();
            this._txtIVA = new System.Windows.Forms.TextBox();
            this._txtRetencion = new System.Windows.Forms.TextBox();
            this._txtTotal = new System.Windows.Forms.TextBox();
            this._txtPrecioL = new System.Windows.Forms.TextBox();
            this._nupCantidad = new System.Windows.Forms.NumericUpDown();
            this._dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnImprimir = new System.Windows.Forms.Button();
            this._txtFolio = new System.Windows.Forms.TextBox();
            this._Label15 = new System.Windows.Forms.Label();
            this._btnVistaPrevia = new System.Windows.Forms.Button();
            this._MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nupCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // _Label1
            // 
            this._Label1.AutoSize = true;
            this._Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label1.Location = new System.Drawing.Point(35, 70);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(69, 20);
            this._Label1.TabIndex = 0;
            this._Label1.Text = "Nombre:";
            // 
            // _Label2
            // 
            this._Label2.AutoSize = true;
            this._Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label2.Location = new System.Drawing.Point(35, 99);
            this._Label2.Name = "_Label2";
            this._Label2.Size = new System.Drawing.Size(76, 20);
            this._Label2.TabIndex = 1;
            this._Label2.Text = "Domicilio:";
            // 
            // _Label3
            // 
            this._Label3.AutoSize = true;
            this._Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label3.Location = new System.Drawing.Point(35, 129);
            this._Label3.Name = "_Label3";
            this._Label3.Size = new System.Drawing.Size(63, 20);
            this._Label3.TabIndex = 2;
            this._Label3.Text = "Ciudad:";
            // 
            // _Label4
            // 
            this._Label4.AutoSize = true;
            this._Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label4.Location = new System.Drawing.Point(35, 159);
            this._Label4.Name = "_Label4";
            this._Label4.Size = new System.Drawing.Size(54, 20);
            this._Label4.TabIndex = 3;
            this._Label4.Text = "R.F.C.";
            // 
            // _Label5
            // 
            this._Label5.AutoSize = true;
            this._Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label5.Location = new System.Drawing.Point(35, 189);
            this._Label5.Name = "_Label5";
            this._Label5.Size = new System.Drawing.Size(157, 20);
            this._Label5.TabIndex = 4;
            this._Label5.Text = "Lugar de Expedicion:";
            // 
            // _Label6
            // 
            this._Label6.AutoSize = true;
            this._Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label6.Location = new System.Drawing.Point(35, 221);
            this._Label6.Name = "_Label6";
            this._Label6.Size = new System.Drawing.Size(161, 20);
            this._Label6.TabIndex = 5;
            this._Label6.Text = "Fecha de Expedicion:";
            // 
            // _Label7
            // 
            this._Label7.AutoSize = true;
            this._Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label7.Location = new System.Drawing.Point(34, 249);
            this._Label7.Name = "_Label7";
            this._Label7.Size = new System.Drawing.Size(77, 20);
            this._Label7.TabIndex = 6;
            this._Label7.Text = "Cantidad:";
            // 
            // _Label8
            // 
            this._Label8.AutoSize = true;
            this._Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label8.Location = new System.Drawing.Point(34, 280);
            this._Label8.Name = "_Label8";
            this._Label8.Size = new System.Drawing.Size(116, 20);
            this._Label8.TabIndex = 7;
            this._Label8.Text = "Precio Unitario:";
            // 
            // _Label9
            // 
            this._Label9.AutoSize = true;
            this._Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label9.Location = new System.Drawing.Point(34, 312);
            this._Label9.Name = "_Label9";
            this._Label9.Size = new System.Drawing.Size(96, 20);
            this._Label9.TabIndex = 8;
            this._Label9.Text = "Descripcion:";
            // 
            // _Label10
            // 
            this._Label10.AutoSize = true;
            this._Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label10.Location = new System.Drawing.Point(34, 455);
            this._Label10.Name = "_Label10";
            this._Label10.Size = new System.Drawing.Size(64, 20);
            this._Label10.TabIndex = 9;
            this._Label10.Text = "Importe";
            // 
            // _Label11
            // 
            this._Label11.AutoSize = true;
            this._Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label11.Location = new System.Drawing.Point(34, 485);
            this._Label11.Name = "_Label11";
            this._Label11.Size = new System.Drawing.Size(48, 20);
            this._Label11.TabIndex = 10;
            this._Label11.Text = "I.V.A.";
            // 
            // _Label12
            // 
            this._Label12.AutoSize = true;
            this._Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label12.Location = new System.Drawing.Point(34, 514);
            this._Label12.Name = "_Label12";
            this._Label12.Size = new System.Drawing.Size(82, 20);
            this._Label12.TabIndex = 11;
            this._Label12.Text = "Retencion";
            // 
            // _Label13
            // 
            this._Label13.AutoSize = true;
            this._Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label13.Location = new System.Drawing.Point(34, 543);
            this._Label13.Name = "_Label13";
            this._Label13.Size = new System.Drawing.Size(48, 20);
            this._Label13.TabIndex = 12;
            this._Label13.Text = "Total:";
            // 
            // _Label14
            // 
            this._Label14.AutoSize = true;
            this._Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label14.Location = new System.Drawing.Point(34, 573);
            this._Label14.Name = "_Label14";
            this._Label14.Size = new System.Drawing.Size(120, 20);
            this._Label14.TabIndex = 13;
            this._Label14.Text = "Precio en Letra:";
            // 
            // _MenuStrip1
            // 
            this._MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ArchivoToolStripMenuItem,
            this._CerrarToolStripMenuItem,
            this._SalirToolStripMenuItem});
            this._MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this._MenuStrip1.Name = "_MenuStrip1";
            this._MenuStrip1.Size = new System.Drawing.Size(855, 29);
            this._MenuStrip1.TabIndex = 14;
            this._MenuStrip1.Text = "MenuStrip1";
            // 
            // _ArchivoToolStripMenuItem
            // 
            this._ArchivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._AbrirToolStripMenuItem,
            this._GuardarToolStripMenuItem});
            this._ArchivoToolStripMenuItem.Name = "_ArchivoToolStripMenuItem";
            this._ArchivoToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this._ArchivoToolStripMenuItem.Text = "Archivo";
            // 
            // _AbrirToolStripMenuItem
            // 
            this._AbrirToolStripMenuItem.Name = "_AbrirToolStripMenuItem";
            this._AbrirToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this._AbrirToolStripMenuItem.Text = "Abrir";
            this._AbrirToolStripMenuItem.Click += new System.EventHandler(this.lecturaEscrituraClick);
            // 
            // _GuardarToolStripMenuItem
            // 
            this._GuardarToolStripMenuItem.Name = "_GuardarToolStripMenuItem";
            this._GuardarToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this._GuardarToolStripMenuItem.Text = "Guardar";
            this._GuardarToolStripMenuItem.Click += new System.EventHandler(this.lecturaEscrituraClick);
            // 
            // _CerrarToolStripMenuItem
            // 
            this._CerrarToolStripMenuItem.Name = "_CerrarToolStripMenuItem";
            this._CerrarToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this._CerrarToolStripMenuItem.Text = "Cerrar";
            this._CerrarToolStripMenuItem.Click += new System.EventHandler(this._CerrarToolStripMenuItem_Click);
            // 
            // _SalirToolStripMenuItem
            // 
            this._SalirToolStripMenuItem.Name = "_SalirToolStripMenuItem";
            this._SalirToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this._SalirToolStripMenuItem.Text = "Salir";
            this._SalirToolStripMenuItem.Click += new System.EventHandler(this._SalirToolStripMenuItem_Click);
            // 
            // _txtNombre
            // 
            this._txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNombre.Location = new System.Drawing.Point(254, 67);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(582, 26);
            this._txtNombre.TabIndex = 15;
            this._txtNombre.Text = "BBVA BANCOMER, S.A.";
            // 
            // _txtDomicilio
            // 
            this._txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDomicilio.Location = new System.Drawing.Point(254, 96);
            this._txtDomicilio.Name = "_txtDomicilio";
            this._txtDomicilio.Size = new System.Drawing.Size(582, 26);
            this._txtDomicilio.TabIndex = 16;
            this._txtDomicilio.Text = "AV. UNIVERSIDAD 1200 COLONIA XOCO";
            // 
            // _txtCiudad
            // 
            this._txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtCiudad.Location = new System.Drawing.Point(254, 126);
            this._txtCiudad.Name = "_txtCiudad";
            this._txtCiudad.Size = new System.Drawing.Size(582, 26);
            this._txtCiudad.TabIndex = 17;
            this._txtCiudad.Text = "MEXICO, D.F.   C.P. 03339";
            // 
            // _txtRFC
            // 
            this._txtRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtRFC.Location = new System.Drawing.Point(254, 156);
            this._txtRFC.Name = "_txtRFC";
            this._txtRFC.Size = new System.Drawing.Size(582, 26);
            this._txtRFC.TabIndex = 18;
            this._txtRFC.Text = "BBA-830831-LJ2";
            // 
            // _txtLugar
            // 
            this._txtLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLugar.Location = new System.Drawing.Point(254, 186);
            this._txtLugar.Name = "_txtLugar";
            this._txtLugar.Size = new System.Drawing.Size(582, 26);
            this._txtLugar.TabIndex = 19;
            this._txtLugar.Text = "CULIACAN, SINALOA";
            // 
            // _txtPrecioU
            // 
            this._txtPrecioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPrecioU.Location = new System.Drawing.Point(254, 277);
            this._txtPrecioU.Name = "_txtPrecioU";
            this._txtPrecioU.Size = new System.Drawing.Size(582, 26);
            this._txtPrecioU.TabIndex = 20;
            // 
            // _txtDescripcion
            // 
            this._txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDescripcion.Location = new System.Drawing.Point(254, 309);
            this._txtDescripcion.Multiline = true;
            this._txtDescripcion.Name = "_txtDescripcion";
            this._txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtDescripcion.Size = new System.Drawing.Size(582, 140);
            this._txtDescripcion.TabIndex = 21;
            this._txtDescripcion.Text = "\r\nDEPOSITO EN CUENTA 0074 0610 1421520776 (BBVA BANCOMER)\r\nCLAVE CODIGO INTERBANC" +
                "ARIO 012 730 0142 15207764\r\nPAGO HECHO EN UNA SOLA EXHIBICION RETENCION CONFORME" +
                " AL ART. 1a, Ley del IVA";
            // 
            // _txtImporte
            // 
            this._txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtImporte.Location = new System.Drawing.Point(254, 452);
            this._txtImporte.Name = "_txtImporte";
            this._txtImporte.Size = new System.Drawing.Size(582, 26);
            this._txtImporte.TabIndex = 22;
            // 
            // _txtIVA
            // 
            this._txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtIVA.Location = new System.Drawing.Point(254, 482);
            this._txtIVA.Name = "_txtIVA";
            this._txtIVA.Size = new System.Drawing.Size(582, 26);
            this._txtIVA.TabIndex = 23;
            // 
            // _txtRetencion
            // 
            this._txtRetencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtRetencion.Location = new System.Drawing.Point(254, 511);
            this._txtRetencion.Name = "_txtRetencion";
            this._txtRetencion.Size = new System.Drawing.Size(582, 26);
            this._txtRetencion.TabIndex = 24;
            // 
            // _txtTotal
            // 
            this._txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtTotal.Location = new System.Drawing.Point(254, 540);
            this._txtTotal.Name = "_txtTotal";
            this._txtTotal.Size = new System.Drawing.Size(582, 26);
            this._txtTotal.TabIndex = 25;
            // 
            // _txtPrecioL
            // 
            this._txtPrecioL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPrecioL.Location = new System.Drawing.Point(254, 570);
            this._txtPrecioL.Multiline = true;
            this._txtPrecioL.Name = "_txtPrecioL";
            this._txtPrecioL.Size = new System.Drawing.Size(582, 59);
            this._txtPrecioL.TabIndex = 26;
            this._txtPrecioL.Text = "( PESOS 00/100 M.N )";
            // 
            // _nupCantidad
            // 
            this._nupCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nupCantidad.Location = new System.Drawing.Point(254, 247);
            this._nupCantidad.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this._nupCantidad.Name = "_nupCantidad";
            this._nupCantidad.Size = new System.Drawing.Size(582, 26);
            this._nupCantidad.TabIndex = 27;
            // 
            // _dtFecha
            // 
            this._dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dtFecha.Location = new System.Drawing.Point(254, 216);
            this._dtFecha.Name = "_dtFecha";
            this._dtFecha.Size = new System.Drawing.Size(582, 26);
            this._dtFecha.TabIndex = 28;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(679, 635);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(157, 36);
            this.btnImprimir.TabIndex = 29;
            this.btnImprimir.Text = "Generar Factura";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this._btnImprimir_Click);
            // 
            // _txtFolio
            // 
            this._txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtFolio.Location = new System.Drawing.Point(254, 36);
            this._txtFolio.Name = "_txtFolio";
            this._txtFolio.Size = new System.Drawing.Size(582, 26);
            this._txtFolio.TabIndex = 32;
            // 
            // _Label15
            // 
            this._Label15.AutoSize = true;
            this._Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label15.Location = new System.Drawing.Point(35, 39);
            this._Label15.Name = "_Label15";
            this._Label15.Size = new System.Drawing.Size(47, 20);
            this._Label15.TabIndex = 31;
            this._Label15.Text = "Folio:";
            // 
            // _btnVistaPrevia
            // 
            this._btnVistaPrevia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnVistaPrevia.Location = new System.Drawing.Point(431, 635);
            this._btnVistaPrevia.Name = "_btnVistaPrevia";
            this._btnVistaPrevia.Size = new System.Drawing.Size(131, 36);
            this._btnVistaPrevia.TabIndex = 30;
            this._btnVistaPrevia.Text = "Vista Previa";
            this._btnVistaPrevia.UseVisualStyleBackColor = true;
            this._btnVistaPrevia.Visible = false;
            // 
            // Factura
            // 
            this.ClientSize = new System.Drawing.Size(855, 678);
            this.Controls.Add(this._txtFolio);
            this.Controls.Add(this._Label15);
            this.Controls.Add(this._btnVistaPrevia);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this._dtFecha);
            this.Controls.Add(this._nupCantidad);
            this.Controls.Add(this._txtPrecioL);
            this.Controls.Add(this._txtTotal);
            this.Controls.Add(this._txtRetencion);
            this.Controls.Add(this._txtIVA);
            this.Controls.Add(this._txtImporte);
            this.Controls.Add(this._txtDescripcion);
            this.Controls.Add(this._txtPrecioU);
            this.Controls.Add(this._txtLugar);
            this.Controls.Add(this._txtRFC);
            this.Controls.Add(this._txtCiudad);
            this.Controls.Add(this._txtDomicilio);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._Label14);
            this.Controls.Add(this._Label13);
            this.Controls.Add(this._Label12);
            this.Controls.Add(this._Label11);
            this.Controls.Add(this._Label10);
            this.Controls.Add(this._Label9);
            this.Controls.Add(this._Label8);
            this.Controls.Add(this._Label7);
            this.Controls.Add(this._Label6);
            this.Controls.Add(this._Label5);
            this.Controls.Add(this._Label4);
            this.Controls.Add(this._Label3);
            this.Controls.Add(this._Label2);
            this.Controls.Add(this._Label1);
            this.Controls.Add(this._MenuStrip1);
            this.MainMenuStrip = this._MenuStrip1;
            this.MinimizeBox = false;
            this.Name = "Factura";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this._MenuStrip1.ResumeLayout(false);
            this._MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nupCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button _btnVistaPrevia;
    }
}