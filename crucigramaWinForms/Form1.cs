using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crucigramaWinForms
{
    public partial class PantallaScrabble : Form
    {
        Tablero tablero = new Tablero(15, 15);
        Jugador j1 = new Jugador("Jugador 1");
        Jugador j2 = new Jugador("Jugador 2");
        Jugador jugadorActual;

        int posicionArr, filaDest, colDest;
        bool turno = true;


        //Se usa para ubicar los labels dentro de la pantalla
        int startPositition = 20;
        int endPosition = 13;
        int startPositionSide = 6;
        int endPositionSide = 20;


        public PantallaScrabble()
        {
            InitializeComponent();
        }

        private void PantallaScrabble_Load(object sender, EventArgs e)
        {
            jugadorActual = j1;

            //Ciclo el cual se encarga de pintar los labels en pantalla
            for(int i = 0; i < 15; i++)
            {
                grpNumeros.Controls.Add(tablero.dibujarNumeros(startPositition, endPosition, $"label{i}", $"{ i + 1}"));
                grpNumerosSide.Controls.Add(tablero.dibujarNumeros(startPositionSide, endPositionSide, $"lbl{i}", $"{ i + 1}"));
                startPositition += 61;
                endPositionSide += 46;
            }


            for(int i = 0; i < 15; i++)
            {
                this.cboFilaPosicion.Items.Add(i + 1);
                this.cboColPosicion.Items.Add(i + 1);
            }

            this.tablero.TableroFichas[0, 0] = "A";
            this.tablero.TableroFichas[0, 1] = "B";
            this.tablero.TableroFichas[0, 2] = "C";
            this.tablero.TableroFichas[0, 3] = "D";

            this._dibujarTablero();

        }

        private void BtnColocarFicha_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Fila: { this.cboFilaPosicion.SelectedIndex } Columna: { this.cboColPosicion.SelectedIndex }");
        }

        private void _dibujarTablero()
        {
            for(int i = 0; i < this.tablero.TableroFichas.GetLength(0); i++)
            {
                for(int j = 0; j < this.tablero.TableroFichas.GetLength(1); j++)
                {
                    this.tlpTablero.Controls.Add(this.tablero.dibujarFicha($"lbl_ficha[{i + "," + j}]", this.tablero.TableroFichas[i, j], 18), j, i);
                }
            }
            this._actualizarControles();
        }


        private void _actualizarControles()
        {
            this.lblPuntajeJ1.Text = $"{ j1.Puntaje }";
            this.lblPuntajeJ2.Text = $"{ j2.Puntaje }";
            this.lblTurnoActual.Text = jugadorActual.NumeroJugador;
            this.cboFichas.Items.Add("Elija un elemento");

            for(int i = 0; i < this.jugadorActual.Fichas.Length; i++)
            {
                this.tlpFichasJugadorActual.Controls.Add(this.tablero.dibujarFicha("lblFicha",jugadorActual.Fichas[i], 14), i, 0);
                this.cboFichas.Items.Add(jugadorActual.Fichas[i]);
            }

            this.cboFichas.SelectedIndex = 0;
        }

    }
}
