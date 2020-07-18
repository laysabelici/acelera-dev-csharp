using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public static class MeuExtensionMethod
    {
        public static int ContadorDePalavras(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
