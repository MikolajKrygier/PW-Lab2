using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace po_2
{
    public partial class Form2 : Form
    {
        int cena, wartosc;
        public Form2()
        {
            InitializeComponent();
            cena = 0;
            wartosc = 0;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cena = cena + 150;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
            if (!radioButton2.Checked)
            {
                cena = cena - 150;
                Form1.Cenakomp = cena;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cena = cena + 90;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
            if (!radioButton1.Checked)
            {
                cena = cena - 90;
                Form1.Cenakomp = cena;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                cena = cena + 250;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
            if (!radioButton3.Checked)
            {
                cena = cena - 250;
                Form1.Cenakomp = cena;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                cena = cena + 100;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
            if (!checkBox1.Checked)
            {
                cena = cena - 100;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                cena = cena + 300;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
            if (!checkBox2.Checked)
            {
                cena = cena - 300;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                cena = cena + 1200;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
            if (!checkBox3.Checked)
            {
                cena = cena - 1200;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                cena = cena + 3200;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
            if (!checkBox4.Checked)
            {
                cena = cena - 3200;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                cena = cena + 220;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
            if (!checkBox5.Checked)
            {
                cena = cena - 220;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                cena = cena + 400 - wartosc;
                wartosc = 400;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;

            }
            if(comboBox1.SelectedIndex == 1)
            {
                cena = cena + 100 - wartosc;
                wartosc = 100;
                label1.Text = cena.ToString();
                Form1.Cenakomp = cena;
            }
        }
    }
}
