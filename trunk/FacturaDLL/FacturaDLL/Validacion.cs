namespace FacturaDLL
{
    using System;

    public class Validacion
    {
        public static bool validacionNumero(char key)
        {
            if (key == '.')
            {
                return false;
            }
            if (key == '\b')
            {
                return false;
            }
            return !char.IsNumber(key);
        }
    }
}

