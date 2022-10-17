using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telecomando.Mosconi
{
    public partial class Form1 : Form
    {
        private Telecomando t;
        private Televisione c;
        public Form1()
        {
            InitializeComponent();

            t = new Telecomando("Sony", "Bravia", "Wi-Fi");
            c = new Televisione("Sony", "Bravia");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //accendi
        {
            t.accendi();
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            textBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e) //spegni
        {
            t.spegni();
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            textBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{t.getStato()}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{t.getVolume()}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{t.getCanale()}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            t.aumentaVolume();
            MessageBox.Show($"{t.getVolume()}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            t.diminuisciVolume();
            MessageBox.Show($"{t.getVolume()}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int c1 = int.Parse(textBox1.Text);
                t.setCanale(c1);
                textBox1.Text = "";
                MessageBox.Show($"{t.getCanale()}");
            }
            catch
            {
                MessageBox.Show("Inserire un valore Valido");
            }
        }
    }
}
