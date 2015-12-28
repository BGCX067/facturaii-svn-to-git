namespace FacturaDLL
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.IO;

    public class FileIO
    {
        private string[] _datos;
        private StreamWriter escritor;
        private StreamReader lector;
        private string path;
        private ushort posicion;
        private string[] posiciones;

        public FileIO(string path)
        {
            this.path = path;
            this._datos = this.inicializacion();
            this.leerDatos();
        }

        public FileIO(string path, string[] datos)
        {
            this.path = path;
            this._datos = datos;
            this.posiciones = new string[] { "[Folio]", "[Nombre]", "[Domicilio]", "[Ciudad]", "[RFC]", "[Lugar de Expedicion]", "[Fecha de Expedicion]", "[Cantidad]", "[Precio Unitario]", "[Descripcion]", "[Importe]", "[IVA]", "[Retencion]", "[Total]", "[Precio en Letra]" };
        }

        public bool escribirDatos()
        {
            bool flag;
            this.posicion = 0;
            try
            {
                this.escritor = new StreamWriter(this.path);
                using (this.escritor)
                {
                    foreach (string str2 in this.posiciones)
                    {
                        this.escritor.WriteLine(str2);
                        string str = this._datos[this.posicion];
                        this.escritor.WriteLine(str);
                        this.posicion = (ushort) (this.posicion + 1);
                    }
                    return true;
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                flag = false;
                ProjectData.ClearProjectError();
                return flag;
                ProjectData.ClearProjectError();
            }
            return flag;
        }

        private string[] inicializacion()
        {
            string[] strArray = new string[0x10];
            int num2 = strArray.Length - 1;
            for (int i = 0; i <= num2; i++)
            {
                strArray[i] = "";
            }
            return strArray;
        }

        public string[] leerDatos()
        {
            string str;
            int posicion;
            string extension = Path.GetExtension(this.path);
            this.posicion = 0;
            this.lector = new StreamReader(this.path);
            if (extension.Equals(".txt"))
            {
                using (this.lector)
                {
                    this.posicion = 1;
                    this._datos[0] = "";
                    this._datos[14] = "";
                    while (!this.lector.EndOfStream)
                    {
                        if (this.posicion == 6)
                        {
                            this._datos[6] = "";
                            this._datos[7] = "";
                            this._datos[8] = "";
                            this.posicion = 9;
                        }
                        str = this.lector.ReadLine();
                        if (this.posicion == 13)
                        {
                            posicion = 8;
                            this._datos[posicion] = this._datos[posicion] + str + "\r\n";
                        }
                        else
                        {
                            posicion = this.posicion;
                            this._datos[posicion] = this._datos[posicion] + str + "\r\n";
                            this.posicion = (ushort) (this.posicion + 1);
                        }
                    }
                }
            }
            else if (extension.Equals(".fac"))
            {
                using (this.lector)
                {
                    while (!this.lector.EndOfStream)
                    {
                        str = this.lector.ReadLine();
                        string str3 = str;
                        if (str3 == "[Folio]")
                        {
                            this.posicion = 0;
                        }
                        else if (str3 == "[Nombre]")
                        {
                            this.posicion = 1;
                        }
                        else if (str3 == "[Domicilio]")
                        {
                            this.posicion = 2;
                        }
                        else if (str3 == "[Ciudad]")
                        {
                            this.posicion = 3;
                        }
                        else if (str3 == "[RFC]")
                        {
                            this.posicion = 4;
                        }
                        else if (str3 == "[Lugar de Expedicion]")
                        {
                            this.posicion = 5;
                        }
                        else if (str3 == "[Fecha de Expedicion]")
                        {
                            this.posicion = 6;
                        }
                        else if (str3 == "[Cantidad]")
                        {
                            this.posicion = 7;
                        }
                        else if (str3 == "[Precio Unitario]")
                        {
                            this.posicion = 8;
                        }
                        else if (str3 == "[Descripcion]")
                        {
                            this.posicion = 9;
                        }
                        else if (str3 == "[Importe]")
                        {
                            this.posicion = 10;
                        }
                        else if (str3 == "[IVA]")
                        {
                            this.posicion = 11;
                        }
                        else if (str3 == "[Retencion]")
                        {
                            this.posicion = 12;
                        }
                        else if (str3 == "[Total]")
                        {
                            this.posicion = 13;
                        }
                        else if (str3 == "[Precio en Letra]")
                        {
                            this.posicion = 14;
                        }
                        else
                        {
                            posicion = this.posicion;
                            this._datos[posicion] = this._datos[posicion] + str + "\r\n";
                        }
                    }
                }
            }
            return this.datos;
        }

        public string[] datos
        {
            get
            {
                return this._datos;
            }
        }
    }
}

