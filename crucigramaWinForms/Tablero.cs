using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crucigramaWinForms
{
    class Tablero
    {
        private string[,] tablero;

        private int[] posicionPuntajeDoble = { 0, 2, 3, 6, 7, 8, 11, 12, 14 };
        private int[] posicionPuntajeTriple = { 1, 5, 9, 13 };
        private int[] posicionPalabraDoble = { 1, 2, 3, 4, 10, 11, 12, 13 };
        private int[] posicionPalabraTriple = { 0, 7, 14 };

        List<string> palabras = new List<string>() { "LANA", "RATON", "ZANAHORIA", "TELEVISOR", "COCHE", "GATO", "PERRO", "ESPEJO", "BICICLETA", "REVISTA", "TELEFONO", "LLAVES" };

        public Tablero() { }

        public Tablero(int filas, int columnas)
        {
            this.tablero = new string[filas, columnas];
            this.LimpiarTabla();
        }

        private void LimpiarTabla()
        {
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(0); j++)
                {
                    tablero[i, j] = "";
                }
            }
        }

        public Label dibujarNumeros(int start, int end, string name, string text)
        {
            Label label = new Label();
            label.Name = name;
            label.Text = text;
            label.ForeColor = Color.OrangeRed;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Serif", 18, FontStyle.Bold);
            label.Width = 45;
            label.Height = 35;
            label.Location = new Point(start, end);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Margin = new Padding(25);
            return label;
        }

        public Label dibujarFicha(string name, string text, int size)
        {
            Label label = new Label();
            label.Name = name;
            label.Text = text;
            label.Font = new Font("Serif", size, FontStyle.Bold);
            label.ForeColor = Color.DarkMagenta;
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }

        public string [,] TableroFichas
        {
            get { return this.tablero; }
            set { this.tablero = value; }
        }

    }
}
