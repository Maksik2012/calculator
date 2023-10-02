using System.Net;

namespace calculator
{
    public partial class Form1 : Form
    {
        public string D;

        public string N1;
        public bool N2;
        public Form1()
        {
            N2 = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox2.Text);

            res = Math.Sqrt(dn);
            textBox2.Text = res.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox2.Text);

            res = Math.Pow(dn, 2);
            textBox2.Text = res.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox2.Text);

            res = 1 / dn;
            textBox2.Text = res.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox2.Text);

            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "×")
            {
                res = dn1 * dn2;
            }
            if (D == "%")
            {
                res = dn1 * dn2 / 100;
            }
            D = "=";
            textBox2.Text = res.ToString();
            N2 = true;

        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains(","))
                textBox2.Text = textBox2.Text + ",";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox2.Text);

            res = -dn;
            textBox2.Text = res.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
        }

        private void button38_Click(object sender, EventArgs e)
        {
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            if (textBox2.Text == "")
                textBox2.Text = "0";
        }

        private void button50_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            if (N2 == true)
            {
                N2 = false;
                textBox2.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox2.Text == "0")
                textBox2.Text = B.Text;
            else
                textBox2.Text = textBox2.Text + B.Text;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox2.Text;
            N2 = true;

        }
    }
}