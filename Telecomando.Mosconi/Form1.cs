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
        private Telecomando tec;
        private Televisione tev;
        public Form1()
        {
            InitializeComponent();

            tec = new Telecomando("Sony", "Bravia", "Wi-Fi");
            tev = new Televisione("Sony", "Bravia", "Hdmi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //accendi
        {
            tec.accendi();
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            textBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e) //spegni
        {
            tec.spegni();
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            textBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{tec.getStato()}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tec.diminuisciVolume();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int c1 = int.Parse(textBox1.Text);
                tec.setCanale(c1);
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Inserire un valore Valido");
            }
        }
    }
}
