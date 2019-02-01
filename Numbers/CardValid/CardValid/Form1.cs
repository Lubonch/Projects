using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardValid
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            string cardNumber = cardnumber.Text;
            if (luhn.Cvalidate(cardNumber))
            {
                cardnumber.Text = "The credit card number is valid";
            }
            else
            {
                cardnumber.Text = "The credit card number is invalid";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
