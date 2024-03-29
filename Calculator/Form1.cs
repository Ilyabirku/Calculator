namespace Calculator
{
    public partial class Form1 : Form
    {
        string total, option;
        int num1, num2, result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text += btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtTotal.Text);

            if (option.Equals("+"))
            {
                result = num1 + num2;
            } else if (option.Equals("-"))
            {
                result = num1 - num2;
            } else if (option.Equals("*")) 
            { 
                result = num1 / num2;
            } else if (option.Equals ("/"))
            {
                result = num1 / num2;
            }

            txtTotal.Text = result + "";
        }
    }
}
