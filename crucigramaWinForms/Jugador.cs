﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crucigramaWinForms
{
    class Jugador
    {
        private int puntaje;
        private string[] fichas = new string[7];
        private string numeroJugador;
        private int palabrasEncontradas = 0;

        public Jugador(string numeroJugador)
        {
            this.numeroJugador = numeroJugador;
            int i = 0;
            foreach (var ficha in Ficha.generarFichas())
            {
                this.fichas[i] = ficha;
                i++;
            }
        }

        public int Puntaje
        {
            get { return this.puntaje; }
            set { this.puntaje = value; }
        }

        public string[] Fichas
        {
            get { return this.fichas; }
        }

        public string NumeroJugador
        {
            get { return this.numeroJugador; }
        }

        public int PalabrasEncontradas
        {
            get { return this.palabrasEncontradas; }
            set { this.palabrasEncontradas = value; }
        }

        public void imprimirFichas()
        {
            foreach (var ficha in this.fichas)
            {
                Console.Write(ficha + " | ");
            }
        }

        public void reemplazarFicha(int idx)
        {
            this.fichas[idx] = Ficha.generarFichaRandom();
        }

    }
}
