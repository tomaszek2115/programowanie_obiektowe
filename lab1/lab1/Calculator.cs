using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Calculator
    {
        public Queue<double> numbers = new Queue<double>();
        public string op = "";
        public bool ready_for_op = false;
        public bool calculated = false;
        public bool zero_error = false;
        public Calculator() { }
        public void calculate()
        {
            double result = 0;
            switch (this.op)
            {
                case "+":
                    result = this.numbers.Dequeue() + this.numbers.Dequeue();
                    break;

                case "-":
                    result = this.numbers.Dequeue() - this.numbers.Dequeue();
                    break;

                case "*":
                    result = this.numbers.Dequeue() * this.numbers.Dequeue();
                    break;

                case "/":
                    result = this.numbers.Dequeue() / this.numbers.Dequeue();
                    if (double.IsInfinity(result))
                    {
                        MessageBox.Show("cannot divide by zero");
                        this.zero_error = true;
                        result = 0;
                    }
                    break;
            }
            this.numbers.Clear();
            this.numbers.Enqueue(result);
        }
    }
}
