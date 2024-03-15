using System.Globalization;

namespace lab1
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void digitClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox.Text == "0" || calc.calculated == true)
            {
                textBox.Clear();
            }
            textBox.Text += button.Text;
            calc.ready_for_op = true;
            calc.calculated = false;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (calc.ready_for_op == true)
            {
                if (calc.op == "")
                {
                    calc.numbers.Enqueue(Convert.ToDouble(textBox.Text));
                    calc.op = button.Text;
                    textBox.Clear();
                    calc.ready_for_op = false;
                }
                else
                {
                    calc.numbers.Enqueue(Convert.ToDouble(textBox.Text));
                    calc.calculate();
                    if (calc.zero_error == true)
                    {
                        calc.numbers.Clear();
                        textBox.Text = "0";
                        calc.op = "";
                        calc.ready_for_op = true;
                        calc.zero_error = false;
                    }
                    else
                    {
                        textBox.Text = Convert.ToString(calc.numbers.Dequeue());
                        calc.numbers.Enqueue(Convert.ToDouble(textBox.Text));
                        calc.op = button.Text;
                        calc.ready_for_op = false;
                    }
                    calc.calculated = true;
                }
            }
            else
            {
                calc.op = button.Text;
                calc.ready_for_op = false;
            }
        }

        private void equalSignClick(object sender, EventArgs e)
        {
            if (calc.op != "" && calc.ready_for_op == true)
            {
                calc.numbers.Enqueue(Convert.ToDouble(textBox.Text));
                calc.calculate();
                if (calc.zero_error == true)
                {
                    calc.numbers.Clear();
                    textBox.Text = "0";
                    calc.op = "";
                    calc.ready_for_op = true;
                    calc.zero_error = false;
                }
                else
                {
                    textBox.Text = Convert.ToString(calc.numbers.Dequeue());
                    calc.op = "";
                }
                calc.calculated = true;
            }
        }

        private void delClick(object sender, EventArgs e)
        {
            calc.calculated = false;
            Button button = (Button)sender;
            if (textBox.Text.Length > 1)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
            else textBox.Text = "0";
        }
    }
}
