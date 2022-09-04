using Calculadora2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsuma osuma = new clsuma(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = osuma.sumar().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clresta oresta = new clresta(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = oresta.restar().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cldivision odivision = new cldivision(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            textBox3.Text = odivision.dividir().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clmultiplicacion omultiplicacion = new clmultiplicacion(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = omultiplicacion.mutiplicar().ToString();
        }
    }
}