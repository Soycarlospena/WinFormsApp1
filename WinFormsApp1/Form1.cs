namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double pdominicano, dolar, euro, pmexicano, cambio;

            pdominicano = Convert.ToDouble(txtmon.Text);

            if (cboconvertir.SelectedIndex == 0)
            {
                dolar = pdominicano / 63.42;
                lblmsg.Visible = true;
                lblmsg.Text = " Dolares ";
                txtconver.Text = Convert.ToString(dolar);
            }
            else

            if (cboconvertir.SelectedIndex == 1)
            {
                euro = pdominicano / 74.39;
                lblmsg.Visible = true;
                lblmsg.Text = " Euros ";
                txtconver.Text = Convert.ToString(euro);
            }
            else
            {
                pmexicano = pdominicano / 3.44;
                lblmsg.Visible = true;
                lblmsg.Text = " Pesos Mexicanos ";
                txtconver.Text = Convert.ToString(pmexicano);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtconver_TextChanged(object sender, EventArgs e)
        {



        }

        private void cboconvertir_Click(object sender, EventArgs e)
        {
            if (txtmon.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar monto en DOP.");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtmon.Text = "";
            txtconver.Text = "";
            cboconvertir.SelectedIndex = -1;
            lblmsg.Visible = false;
            lblmsg.Text = "";
            txtmon.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}   
