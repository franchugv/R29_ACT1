using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R29_ACT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Controlador_Click(object sender, EventArgs e)
        {
            // Recursos Locales
            Button boton = (Button)sender;
            string figura = null;


            // Controlador - Manejador de Eventos centralzado
            switch (boton.Name)
            {
                // Solo se pone el nombre del botón, no "boton.bTriangulo"
                case "BotonTriangulo":
                    figura = UIFiguras.Triangulo();
                    break;
                case "BotonEscuadra":
                    figura = UIFiguras.Escuadra();
                    break;
                case "BotonEscuadra2":
                    figura = UIFiguras.Escuadra2();
                    break;
                case "BotonPiramideInvertida":
                    figura = UIFiguras.PiramideInvertida();
                    break;
                case "BotonPiramide":
                    figura = UIFiguras.Piramide();
                    break;
            }
            // Mostrar la figura elegida
            UIFiguras.MostrarDatos(figura);


        }


    }
}
