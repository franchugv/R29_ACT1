using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R29_ACT1
{
    public static class UIFiguras
    {
        public static string Triangulo()
        {
            return "*\n* *\n* * *\n* * * *\n* * * * *";
        }

        public static string Escuadra()
        {
            return "* * * * *\n* * * *\n* * *\n* *\n*";
        }

        public static string Escuadra2()
        {
            return 
                "* * * * *\n" +
                "  * * * *\n" +
                "    * * *\n" +
                "      * *\n" +
                "        *";
        }


        public static string PiramideInvertida()
        {
            return
                "* * * * *\n" +
                " * * * *\n" +
                "  * * *\n" +
                "   * *\n" +
                "    *";
        }


        public static string Piramide()
        {
            return
                "    *\n" +
                "   * *\n" +
                "  * * *\n" +
                " * * * *\n" +
                "* * * * *";
        }

        internal static void MostrarDatos(string cadena)
        {

            MessageBox.Show(cadena);

        }
    }
}
