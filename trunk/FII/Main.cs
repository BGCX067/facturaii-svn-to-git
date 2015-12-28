namespace FII
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Windows.Forms;

    public class Run
    {
        [STAThread]
        public static void Main(string[] args)
        {
            //UtilRegistry.AsociarExtension(".fac", Application.ExecutablePath, UtilRegistry.GetProgId(".fac"));
            if (args.Length <= 1)
            {
                if (args.Length == 1)
                {
                    Application.Run(new Entrada(args[0]));
                }
                else
                {
                    Application.Run(new Entrada());
                }
            }
        }
    }
}

