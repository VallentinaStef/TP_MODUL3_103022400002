namespace TP_MODUL3_103022400002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            angka1 = int.Parse(lblOutput.Text);
            operasi = "+";
            lblOutput.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "0";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            angka2 = int.Parse(lblOutput.Text);

            if (operasi == "+")
            {
                int hasil = angka1 + angka2;
                lblOutput.Text = hasil.ToString();
            }
        }
    }
}
