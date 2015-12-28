namespace Dialogos
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class CuadroDeDialogos
    {
        private DialogResult dialogResult_;
        private string nombreArchivo_;
        private OpenFileDialog oDialog = new OpenFileDialog();
        private SaveFileDialog sDialog = new SaveFileDialog();

        public CuadroDeDialogos(string filtro, string extension, tipoDialogo tipoDialog, [Optional, DefaultParameterValue(true)] bool agregarExtension)
        {
            if (tipoDialog == tipoDialogo.openFileD)
            {
                this.oDialog.Filter = filtro;
                this.oDialog.DefaultExt = extension;
                this.oDialog.DefaultExt = Conversions.ToString(agregarExtension);
                this.oDialog.InitialDirectory = @"D:\Inmobiliaria Irving\Bancomer\Facturas";
            }
            else
            {
                this.sDialog.Filter = filtro;
                this.sDialog.DefaultExt = extension;
                this.sDialog.DefaultExt = Conversions.ToString(agregarExtension);
                this.oDialog.InitialDirectory = @"D:\Inmobiliaria Irving\Bancomer\Facturas";
            }
        }

        public string nombreArchivo
        {
            get
            {
                return this.nombreArchivo_;
            }
        }

        public class OFile : CuadroDeDialogos
        {
            public OFile(string filtro, string extension, CuadroDeDialogos.tipoDialogo tipoDialog, [Optional, DefaultParameterValue(true)] bool agregarExtension) : base(filtro, extension, tipoDialog, true)
            {
            }

            public DialogResult showDialog()
            {
                base.nombreArchivo_ = "";
                base.dialogResult_ = base.oDialog.ShowDialog();
                base.nombreArchivo_ = base.oDialog.FileName;
                return base.dialogResult_;
            }
        }

        public class SFile : CuadroDeDialogos
        {
            public SFile(string filtro, string extension, CuadroDeDialogos.tipoDialogo tipoDialog, [Optional, DefaultParameterValue(true)] bool agregarExtension) : base(filtro, extension, tipoDialog, true)
            {
            }

            public DialogResult showDialog()
            {
                base.nombreArchivo_ = "";
                base.dialogResult_ = base.sDialog.ShowDialog();
                base.nombreArchivo_ = base.sDialog.FileName;
                return base.dialogResult_;
            }
        }

        public enum tipoDialogo
        {
            saveFileD,
            openFileD
        }
    }
}

