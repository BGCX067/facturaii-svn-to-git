namespace Rock
{
    using System;

    public static class Validacion
    {
        public static bool validarNumero(char tecla)
        {
            if (tecla.Equals('.'))
            {
                return false;
            }
            if (tecla == '\b')
            {
                return false;
            }
            if ((tecla > '/') && (tecla < ':'))
            {
                return false;
            }
            return true;
        }

        public static bool validarNumeroSinPunto(char tecla)
        {
            if (tecla == '\b')
            {
                return false;
            }
            if ((tecla > '/') && (tecla < ':'))
            {
                return false;
            }
            return true;
        }

        public static bool validarTelefono(char tecla)
        {
            if (tecla.Equals('-'))
            {
                return false;
            }
            if (tecla == '\b')
            {
                return false;
            }
            if ((tecla > '/') && (tecla < ':'))
            {
                return false;
            }
            return true;
        }
    }
}

