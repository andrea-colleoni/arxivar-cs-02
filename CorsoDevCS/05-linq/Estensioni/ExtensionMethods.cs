using System;
using System.Collections.Generic;
using System.Text;

namespace _05_linq.Estensioni
{
    public static class ExtensionMethods
    {
        public static bool IsGreaterThan(this int valore, int valoreDiConfronto)
        {
            return valore > valoreDiConfronto;
        }
    }
}
