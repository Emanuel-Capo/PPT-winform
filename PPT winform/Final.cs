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
    public partial class Final : Form
    {
        int[] vPuntos;
        string[] vNombres;

        public Final(int[] puntos, string[] nombres)
        {
            InitializeComponent();
            vPuntos = puntos;
            vNombres = nombres;
        }

        private void Final_Load(object sender, EventArgs e)
        {
            lblFelic.Text = $"¡¡¡FELICITACIONES {vNombres[0].ToUpper()}!!!";
            for (int i = 0; i < vPuntos.Length; i++)
            {
                lbNombres.Items.Add(vNombres[i]);
                lbPuntos.Items.Add(vPuntos[i]);
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
