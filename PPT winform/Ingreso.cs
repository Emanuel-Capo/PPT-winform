using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPT_winform
{
    public partial class Ingreso : Form
    {
        int nroDeJugadores, nroDeRondas;
        string[] jugadores;
        int ind = 0;

        public Ingreso()
        {
            InitializeComponent();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            tbNombre.Enabled = false;
            btAgregar.Enabled = false;
            btJugar.Enabled = false;
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            nroDeJugadores = Convert.ToInt32(selJugadores.Value);
            nroDeRondas = Convert.ToInt32(selRondas.Value);
            jugadores = new string[nroDeJugadores];
            lblNombre.Text = "Nombre del jugador 1";
            tbNombre.Enabled = true;
            btAgregar.Enabled = true;
            tbNombre.Focus();
            listJugadores.Items.Clear();

            ind = 0;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (ind < nroDeJugadores)
            {
                listJugadores.Items.Add($"{ind + 1}. {tbNombre.Text}");
                jugadores[ind] = tbNombre.Text;
                ind++;
                lblNombre.Text = $"Nombre del jugador {ind + 1}";
                tbNombre.Clear();
                tbNombre.Focus();
                if (ind == nroDeJugadores)
                {
                    lblNombre.Text = "Lista completa";
                    btAgregar.Enabled = false;
                    tbNombre.Enabled = false;
                    btJugar.Enabled = true;
                }
            }
        }

        private void btborrar_Click(object sender, EventArgs e)
        {
            ind = 0;
            listJugadores.Items.Clear();
            btAgregar.Enabled = true;
            tbNombre.Enabled = true;
            btJugar.Enabled = false;
            lblNombre.Text = $"Nombre del jugador {ind + 1}";
        }

        private void btJugar_Click(object sender, EventArgs e)
        {
            Juego ventanaJugar = new Juego(nroDeRondas, jugadores);
            ventanaJugar.ShowDialog();
        }
    }
}
