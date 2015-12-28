namespace FacturaDLL
{
    using System;
    using System.Windows.Forms;

    public class Formulario
    {
        public static bool abierto = false;

        public static void abrirFormulario(Form form, Form formPadre)
        {
            if (formPadre.ActiveMdiChild != null)
            {
                formPadre.ActiveMdiChild.Close();
            }
            form.MdiParent = formPadre;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.ControlBox = false;
            form.Size = formPadre.Size;
            form.StartPosition = FormStartPosition.CenterParent;
            form.WindowState = FormWindowState.Maximized;
            form.AutoScroll = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        public static void cerrarFormulario(ref Form form)
        {
            abierto = false;
            form.Close();
        }
    }
}

