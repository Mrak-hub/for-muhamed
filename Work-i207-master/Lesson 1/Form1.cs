namespace Lesson_1
{
    public partial class Form1 : Form
    {
        public Form1(string mmm)
        {


            InitializeComponent();
            MessageBox.Show(mmm);

        }
        public Form1()

        {
            InitializeComponent();

            this.textCalc.TextChanged += (sender, e) => this.textBox2_TextChanged(sender, e);
        }
        bool newOperation = true;
        double firstValue;
        double secondValue;
        double result = 0.0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnNumberOperation(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (newOperation)
            {
                txtDisplay.Clear();
                newOperation = false;
            }
            if(btn.Text == ",")
            {
                var val = txtDisplay.Text.IndexOf(",");
                if (val > 0)
                    return;
            }
            txtDisplay.Text += btn.Text;
            if (btn.Text != ",")
                firstValue = Convert.ToDouble(txtDisplay.Text);
        }
        private void btnActionOperation(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)
            {
                case "+":
                    newOperation = true;
                    break;
                case "-":
                    newOperation = true;
                    break;
                case "*":
                    newOperation = true;
                    break;
                case "/":
                    newOperation = true;
                    break;
                case "%":
                    newOperation = true;
                    break;
                case "^":
                    newOperation = true;
                    break;
            }
            txtDisplay.Text += btn.Text;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
