using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Herni_postava postava;
        Hrac hrac;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != string.Empty) && (textBox2.Text != string.Empty) && (textBox3.Text != string.Empty) && (textBox4.Text != string.Empty) && (textBox5.Text != string.Empty) && (textBox6.Text != string.Empty) && (textBox7.Text != string.Empty) && (textBox8.Text != string.Empty))
            {
                try
                {
                    postava = new Herni_postava(textBox1.Text);
                    postava.zmena_pozice(int.Parse(textBox2.Text), int.Parse(textBox3.Text));

                    hrac = new Hrac(textBox1.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                    hrac.pridej_XP(int.Parse(textBox8.Text));
                }
                catch
                {
                    MessageBox.Show("zkontroluj imput");
                }
            }
            else
            {
                {
                    MessageBox.Show("zadej neco do vsech boxu");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(postava.ToString() + hrac.ToString());
        }
    }
}
