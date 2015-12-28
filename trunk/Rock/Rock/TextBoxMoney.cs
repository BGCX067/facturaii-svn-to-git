namespace Rock
{
    using System;

    public class TextBoxMoney : TextBoxOnlyNumber
    {
        private string simboloMoneda;

        public TextBoxMoney()
        {
            this.simboloMoneda = "$";
            base.LostFocus += new EventHandler(this.TextBoxMoney_LostFocus);
        }

        public TextBoxMoney(string simboloMoneda)
        {
            this.simboloMoneda = "$";
            base.LostFocus += new EventHandler(this.TextBoxMoney_LostFocus);
            this.simboloMoneda = simboloMoneda;
        }

        private void TextBoxMoney_LostFocus(object sender, EventArgs e)
        {
            try
            {
                this.Text = string.Format("{0:###,###.00}", Convert.ToDouble(this.Text));
            }
            catch
            {
            }
        }
    }
}

