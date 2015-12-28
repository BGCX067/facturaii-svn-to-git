namespace Rock
{
    using System;
    using System.Windows.Forms;

    public class TextBoxOnlyNumber : TextBox
    {
        private bool usarPunto;

        public TextBoxOnlyNumber()
        {
            this.usarPunto = true;
            base.KeyPress += new KeyPressEventHandler(this.keyPress);
        }

        public TextBoxOnlyNumber(bool usarPunto)
        {
            this.usarPunto = true;
            this.usarPunto = usarPunto;
            base.KeyPress += new KeyPressEventHandler(this.keyPress);
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (this.usarPunto)
            {
                e.Handled = Validacion.validarNumero(e.KeyChar);
            }
            else
            {
                e.Handled = Validacion.validarNumeroSinPunto(e.KeyChar);
            }
        }

        public bool UsarPunto
        {
            get
            {
                return this.usarPunto;
            }
            set
            {
                this.usarPunto = value;
            }
        }
    }
}

