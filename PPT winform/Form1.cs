namespace PPT_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btComenzar_Click(object sender, EventArgs e)
        {
            Ingreso ventanaIngreso = new Ingreso();
            ventanaIngreso.ShowDialog();
        }
    }
}