namespace FacturaDLL
{
    using System;
    using System.Runtime.CompilerServices;

    public class Operaciones
    {
        protected decimal comision_;
        protected decimal importe_;
        protected decimal ingreso_;
        protected decimal iva_;
        protected decimal monto_;
        [DecimalConstant(2, 0, (uint) 0, (uint) 0, (uint) 0x10)]
        private static readonly decimal porcentajeIva = 0.16M;
        protected decimal retencion_;
        protected decimal total_;

        public void calcularAvaluo(decimal honorario, decimal cantidad)
        {
            this.importe = decimal.Multiply(honorario, cantidad);
            this.iva = decimal.Multiply(this.importe, 0.16M);
            this.total = decimal.Add(this.importe, this.iva);
        }

        public void calcularCredito(decimal credito)
        {
            this.importe = new decimal(Convert.ToDouble(credito) * 0.02);
        }

        public void calcularEspecial(decimal precio, decimal comision)
        {
            this.monto = precio;
            this.comision = comision;
            this.calculos();
        }

        public void calcularIndividual(decimal precio)
        {
            if ((decimal.Compare(precio, decimal.Zero) > 0) & (decimal.Compare(precio, 100001M) < 0))
            {
                this.comision = 10M;
            }
            else if ((decimal.Compare(precio, 100000M) > 0) & (decimal.Compare(precio, 200000M) <= 0))
            {
                this.comision = 9M;
            }
            else if ((decimal.Compare(precio, 200000M) > 0) & (decimal.Compare(precio, 300000M) <= 0))
            {
                this.comision = 8M;
            }
            else if ((decimal.Compare(precio, 300000M) > 0) & (decimal.Compare(precio, 400000M) <= 0))
            {
                this.comision = 7M;
            }
            else if ((decimal.Compare(precio, 400000M) > 0) & (decimal.Compare(precio, 500000M) <= 0))
            {
                this.comision = 6M;
            }
            else if ((decimal.Compare(precio, 500000M) > 0) & (decimal.Compare(precio, 1000000M) <= 0))
            {
                this.comision = 5M;
            }
            else if ((decimal.Compare(precio, 1000000M) > 0) & (decimal.Compare(precio, 5000000M) <= 0))
            {
                this.comision = 4.5M;
            }
            else if ((decimal.Compare(precio, 5000000M) > 0) & (decimal.Compare(precio, 10000000M) <= 0))
            {
                this.comision = 4M;
            }
            else if (decimal.Compare(precio, 10000000M) > 0)
            {
                this.comision = 3.5M;
            }
            else
            {
                this.comision = decimal.Zero;
            }
            this.importe = decimal.Multiply(precio, this.comision);
        }

        public void calcularNormal(int tipo, bool noReferido, decimal monto)
        {
            this.monto = monto;
            this.comision = decimal.Zero;
            if (noReferido)
            {
                if ((tipo > -1) & (tipo < 4))
                {
                    this.comision_ = decimal.Add(this.comision_, 2.5M);
                }
                else if ((tipo > 3) & (tipo < 8))
                {
                    this.comision_ = decimal.Add(this.comision_, 3M);
                }
                else if ((tipo > 7) & (tipo < 11))
                {
                    this.comision_ = decimal.Add(this.comision_, 4M);
                }
                if ((decimal.Compare(monto, decimal.Zero) > 0) & (decimal.Compare(monto, 1000001M) < 0))
                {
                    this.comision_ = decimal.Add(this.comision_, 2.5M);
                }
                else if ((decimal.Compare(monto, 1000000M) > 0) & (decimal.Compare(monto, 5000000M) <= 0))
                {
                    this.comision_ = decimal.Add(this.comision_, 2M);
                }
                else if ((decimal.Compare(monto, 5000000M) > 0) & (decimal.Compare(monto, 10000001M) <= 0))
                {
                    this.comision_ = decimal.Add(this.comision_, 1.5M);
                }
                else if (decimal.Compare(monto, 10000000M) > 0)
                {
                    this.comision_ = decimal.Add(this.comision_, decimal.One);
                }
            }
            else
            {
                if ((tipo > -1) & (tipo < 4))
                {
                    this.comision_ = decimal.Add(this.comision_, new decimal(Convert.ToDouble(this.comision_) + 1.25));
                }
                else if ((tipo > 3) & (tipo < 9))
                {
                    this.comision_ = decimal.Add(this.comision_, new decimal(Convert.ToDouble(this.comision_) + 2.25));
                }
                else if ((tipo > 8) & (tipo < 11))
                {
                    this.comision_ = decimal.Add(this.comision_, new decimal(Convert.ToDouble(this.comision_) + 2.5));
                }
                if ((decimal.Compare(monto, decimal.Zero) > 0) & (decimal.Compare(monto, 1000001M) < 0))
                {
                    this.comision_ = decimal.Add(this.comision_, 2.5M);
                }
                else if ((decimal.Compare(monto, 1000000M) > 0) & (decimal.Compare(monto, 5000000M) <= 0))
                {
                    this.comision_ = decimal.Add(this.comision_, 2M);
                }
                else if ((decimal.Compare(monto, 5000000M) > 0) & (decimal.Compare(monto, 10000001M) <= 0))
                {
                    this.comision_ = decimal.Add(this.comision_, 1.5M);
                }
                else if (decimal.Compare(monto, 10000000M) > 0)
                {
                    this.comision_ = decimal.Add(this.comision_, decimal.One);
                }
            }
            this.calculos();
        }

        private void calculos()
        {
            this.ingreso = decimal.Multiply(this.monto, this.comision);
            this.iva = decimal.Multiply(this.ingreso, 0.16M);
            this.retencion = decimal.Multiply(decimal.Divide(this.iva, 3M), 2M);
            this.total = decimal.Add(this.ingreso, decimal.Subtract(this.iva, this.retencion));
        }

        public decimal comision
        {
            get
            {
                return decimal.Divide(this.comision_, 100M);
            }
            set
            {
                this.comision_ = value;
            }
        }

        public decimal importe
        {
            get
            {
                return this.importe_;
            }
            set
            {
                this.importe_ = value;
            }
        }

        public decimal ingreso
        {
            get
            {
                return this.ingreso_;
            }
            set
            {
                this.ingreso_ = value;
            }
        }

        public decimal iva
        {
            get
            {
                return this.iva_;
            }
            set
            {
                this.iva_ = value;
            }
        }

        public decimal monto
        {
            get
            {
                return this.monto_;
            }
            set
            {
                this.monto_ = value;
            }
        }

        public decimal retencion
        {
            get
            {
                return this.retencion_;
            }
            set
            {
                this.retencion_ = value;
            }
        }

        public decimal total
        {
            get
            {
                return this.total_;
            }
            set
            {
                this.total_ = value;
            }
        }

        public enum tipoFactura
        {
            normal,
            avaluo,
            individual,
            credito,
            especial
        }
    }
}

