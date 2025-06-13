namespace EJ2
{
    public partial class Form1 : Form
    {
        int Numero = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Fmostar modal = new Fmostar();
            modal.ShowDialog();
            Numero = Convert.ToInt32(tbValor.Text);
            modal.lbNumero.Text = Numero.ToString();
        }
    }
}
