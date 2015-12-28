namespace Rock.Properties
{
    using Rock;
    using System;
    using System.Windows.Forms;

    public class TextBoxTelefone : TextBox
    {
        public TextBoxTelefone()
        {
            base.KeyPress += new KeyPressEventHandler(this.TextBoxTelefone_KeyPress);
        }

        private void TextBoxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.validarTelefono(e.KeyChar);
        }
    }
}

