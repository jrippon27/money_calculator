using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace money_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //whole dollars
            double oneHundred = 100;
            double fifty = 50;
            double twenty = 20;
            double ten = 10;
            double five = 5;
            double one = 1;

            //cents
            double twentyFiveCents = 0.25;
            double tenCents = 0.10;
            double fiveCents = 0.05;
            double oneCent = 0.01;

            //answer
            double answer;
            //converts to double
            oneHundred = double.Parse(textOneHundred.Text) * 100;
            fifty = double.Parse(textFifty.Text) * 50;
            twenty = double.Parse(textTwenty.Text) * 20;
            ten = double.Parse(textTen.Text) * 10;
            five = double.Parse(textFive.Text) * 5;
            one = double.Parse(textOneCent.Text) * 1;

            twentyFiveCents = double.Parse(textTwentyFiveCents.Text) * 0.25;
            tenCents = double.Parse(textTenCents.Text) * 0.10;
            fiveCents = double.Parse(textFiveCents.Text) * 0.05;
            oneCent = double.Parse(textOneCent.Text) * 0.01;

            answer = oneHundred + fifty + twenty + ten + five +
                one + twentyFiveCents + tenCents + fiveCents + oneCent;
            
            MessageBox.Show(answer.ToString());

        }

        private void textOneHundred_TextChanged(object sender, EventArgs e)
        {
            double oneHundred;
            oneHundred = double.Parse(textOneHundred.Text);
        }

        private void textFifty_TextChanged(object sender, EventArgs e)
        {
            double fifty;
            fifty = double.Parse(textFifty.Text);
        }

        private void textTwentyFive_TextChanged(object sender, EventArgs e)
        {
            double twenty;
            twenty = double.Parse(textTwenty.Text);
        }

        private void textTen_TextChanged(object sender, EventArgs e)
        {
            double ten;
            ten = double.Parse(textTen.Text);
        }

        private void textFive_TextChanged(object sender, EventArgs e)
        {
            double five;
            five = double.Parse(textFive.Text);
        }

        private void txtOne_TextChanged(object sender, EventArgs e)
        {
            double one;
            one = double.Parse(textOneHundred.Text);
        }

        private void textTwentyFiveCents_TextChanged(object sender, EventArgs e)
        {
            double twentyFiveCents;
            twentyFiveCents = double.Parse(textTwenty.Text);
            
        }

        private void textTenCents_TextChanged(object sender, EventArgs e)
        {
            double tenCents;
            tenCents = double.Parse(textTenCents.Text);

        }

        private void textFiveCents_TextChanged(object sender, EventArgs e)
        {
            double fiveCents;
            fiveCents = double.Parse(textFiveCents.Text);
        }

        private void textOneCent_TextChanged(object sender, EventArgs e)
        {
            double oneCent;
            oneCent = double.Parse(textOneCent.Text);
        }
    }
}
