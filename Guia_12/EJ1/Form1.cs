namespace EJ1
{
    public partial class Form1 : Form
    {
        int Resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            FormsDatos modal = new FormsDatos();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                Resultado = Convert.ToInt32(modal.tbValor.Text);
            }
            modal.Dispose();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            lbMostrarValor.Visible = true;
            lbMostrarValor.Text = Resultado.ToString();
        }
    }
}
