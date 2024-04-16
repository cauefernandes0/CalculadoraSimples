using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonDivisor_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "÷";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "*";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancela_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }

        private void buttonSubtrair_Click_1(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "-";
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "+";
        }

        private void buttonMultiplica_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "*";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "=";
        }

        private void buttonPorcentagem_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = textBoxDisplay.Text + "%";
        }

        private void button_Num(object sender, EventArgs e)
        {

        }
    }
}
