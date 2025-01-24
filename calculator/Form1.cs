namespace calculator
{
    public partial class Form1 : Form
    {

        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        //Button for the numbers
        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();

            

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        //Button for all operations that can be done
        private void buttonOper_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            result = double.Parse(textBox1.Text);
            operation = button.Text;
            isOperationPerformed = true;
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Button for clearing
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            operation = "";
            isOperationPerformed = false;
        }

        //Button for the result
        private void button12_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(textBox1.Text) != 0)
                        textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    else
                        textBox1.Text = "Error"; 
                    break;
            }

            result = 0;
            operation = "";
            isOperationPerformed = false;
        }
        
        //Button for exiting the calculator
        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
