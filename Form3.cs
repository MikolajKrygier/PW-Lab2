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
    public partial class Form3 : Form
    {
        int Cena3,wartosc3,wartosc4;
        public Form3()
        {
            InitializeComponent();
            Cena3 = 0;
            wartosc3 = 0;
            wartosc4 = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    Cena3 = Cena3 + 500 - wartosc3;
                    wartosc3 = 500;
                    label1.Text = Cena3.ToString();
                    Form1.Cenamonitor = Cena3;
                    break;

                case 1:
                    Cena3 = Cena3 + 600 - wartosc3;
                    wartosc3 = 600;
                    label1.Text = Cena3.ToString();
                    Form1.Cenamonitor = Cena3;
                    break;

                case 2:
                    Cena3 = Cena3 + 350 - wartosc3;
                    wartosc3 = 350;
                    label1.Text = Cena3.ToString();
                    Form1.Cenamonitor = Cena3;
                    break;

                case 3:
                    Cena3 = Cena3 + 700 - wartosc3;
                    wartosc3 = 700;
                    label1.Text = Cena3.ToString();
                    Form1.Cenamonitor = Cena3;
                    break;

                case 4:
                    Cena3 = Cena3 + 650 - wartosc3;
                    wartosc3 = 650;
                    label1.Text = Cena3.ToString();
                    Form1.Cenamonitor = Cena3;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch(comboBox2.SelectedIndex)
            {
                case 0:
                    Cena3 = Cena3 + 300 - wartosc4;
                    wartosc4 = 300;
                    label1.Text = Cena3.ToString();
                    Form1.Cenamonitor = Cena3;
                    break;

                case 1:
                    Cena3 = Cena3 + 500 - wartosc4;
                    wartosc4 = 500;
                    label1.Text = Cena3.ToString();
                    Form1.Cenamonitor = Cena3;
                    break;

                case 2:
                    Cena3 = Cena3 + 800 - wartosc4;
                    wartosc4 = 800;
                    label1.Text = Cena3.ToString();
                    Form1.Cenamonitor = Cena3;
                    break;

                case 3:
                    Cena3 = Cena3 + 150 - wartosc4;
                    wartosc4 = 150;
                    label1.Text = Cena3.ToString();
                    Form1.Cenamonitor = Cena3;
                    break;

                case 4:
                    Cena3 = Cena3 + 200 - wartosc4;
                    wartosc4 = 200;
                    label1.Text = Cena3.ToString();
                    Form1.Cenamonitor = Cena3;
                    break;
            }
        }
    }
}
