using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.Design.AxImporter;

namespace PPT_winform
{
    public partial class Juego : Form
    {
        Random rnd = new Random();
        int nroDeRondas, ronda, jugador;
        string[] jugadores;
        int[] parcial, puntos;

        public Juego(int rondas, string[] nombres)
        {
            InitializeComponent();
            nroDeRondas = rondas;
            jugadores = nombres;
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            ronda = 1;
            jugador = 0;
            lblRondas.Text = $"Rondas: {nroDeRondas}";
            lblJug.Text = $"Jugadores: {jugadores.Length}";
            Inicio();
            Ronda(ronda);
            Jugador(jugador);
            parcial = new int[] { 0, 0, 0 };
            puntos = new int[jugadores.Length];
            btProxJug.Visible = false;
            btResult.Visible = false;
        }

        private void Inicio()
        {
            lblMje.Text = "Elige una opción";
            btSiguiente.Visible = false;
            imgPapelBot.Visible = false;
            imgPapelJug.Visible = false;
            imgPiedraBot.Visible = false;
            imgPiedraJug.Visible = false;
            imgTijeraBot.Visible = false;
            imgTijeraJug.Visible = false;
            imgPapel1.Visible = true;
            imgPiedra1.Visible = true;
            imgTijera1.Visible = true;
        }

        private void Ronda(int nro)
        {
            lblRonda.Text = $"RONDA Nº {nro}";
        }

        private void Jugador(int nro)
        {
            lblJugador.Text = $"JUGADOR: {jugadores[nro]}";
        }

        private void Jugar(int selJ)
        {
            int selM = rnd.Next(3);

            imgPiedra1.Visible = false;
            imgPapel1.Visible = false;
            imgTijera1.Visible = false;

            if (selJ == 0) imgPiedraJug.Visible = true;
            else if (selJ == 1) imgPapelJug.Visible = true;
            else imgTijeraJug.Visible = true;

            if (selM == 0) imgPiedraBot.Visible = true;
            else if (selM == 1) imgPapelBot.Visible = true;
            else imgTijeraBot.Visible = true;

            if (selJ == selM)
            {
                parcial[1]++;
                lblMje.Text = "Empate.. que aburrido :[";
            }
            else if (selJ - selM == 1 || selJ - selM == -2)
            {
                parcial[0]++;
                lblMje.Text = "Ganaste.. pero solo fué suerte";
            }
            else
            {
                parcial[2]++;
                lblMje.Text = "HA HA HA, perdiste!! :]";
            }

            MostrarRes();

            if (ronda == nroDeRondas)
            {
                if (jugador == jugadores.Length - 1)
                {
                    btResult.Visible = true;
                }
                else btProxJug.Visible = true;
            }
            else
            {
                btSiguiente.Visible = true;
            }
        }

        private void MostrarRes()
        {
            lblResultados.Text = $"Ganados: {parcial[0]}    Empatados: {parcial[1]}     Perdidos: {parcial[2]}      Puntos: {parcial[0] * 2 - parcial[2]}";
        }

        private void imgPiedra1_Click(object sender, EventArgs e)
        {
            Jugar(0);
        }

        private void imgPapel1_Click(object sender, EventArgs e)
        {
            Jugar(1);
        }

        private void imgTijera1_Click(object sender, EventArgs e)
        {
            Jugar(2);
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            Inicio();
            ronda++;
            Ronda(ronda);
        }

        private void btProxJug_Click(object sender, EventArgs e)
        {
            Inicio();
            ronda = 1;
            Ronda(ronda);
            puntos[jugador] = parcial[0] * 2 - parcial[2];
            jugador++;
            Jugador(jugador);
            parcial = new int[] { 0, 0, 0 };
            MostrarRes();
            btProxJug.Visible = false;
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            puntos[jugador] = parcial[0] * 2 - parcial[2];
            Array.Sort(puntos, jugadores);
            Array.Reverse(puntos);
            Array.Reverse(jugadores);

            Final ventanaFinal = new Final(puntos, jugadores);
            ventanaFinal.ShowDialog();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
