using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool setEmptyError(TextBox tb)
        {
            if (tb.Text == "")
            {
                errorProvider1.SetError(tb, "Puste pole");
                return false;
            }
            else
                return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (setEmptyError(textBoxName)&&setEmptyError(textBoxLastName))
            {
                Pilkarz p = new Pilkarz(textBoxName.Text, textBoxLastName.Text, 23, 78, 192);
                textBox1.Text += p.ToString();
            }
        }
    }
}
