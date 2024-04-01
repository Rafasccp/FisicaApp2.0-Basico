namespace FisicaApp_Basico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVm_Click(object sender, EventArgs e)
        {
            decimal Vm = nmEntrada1.Value / nmEntrada2.Value;
            lblResultado.Text = Vm.ToString("0.0") + " m/s";
        }

        private void btAcel_Click(object sender, EventArgs e)
        {
            decimal Acel = nmEntrada1.Value / nmEntrada2.Value;
            lblResultado.Text = Acel.ToString("0.0") + " m/s²";
        }

        private void btMu_Click(object sender, EventArgs e)
        {
            decimal Mu = nmEntrada1.Value + nmEntrada2.Value * nmEntrada3.Value;
            lblResultado.Text = Mu.ToString("0.0") + " metros";
        }

        private void btTorr_Click(object sender, EventArgs e)
        {
            decimal Torr = (decimal)Math.Sqrt((double)((nmEntrada1.Value * nmEntrada1.Value) + 2 * nmEntrada2.Value * nmEntrada3.Value));
            lblResultado.Text = Torr.ToString("0.0") + " m/s";
        }
    }
}
