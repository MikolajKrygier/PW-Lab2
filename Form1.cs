namespace po_2
{
    public partial class Form1 : Form
    {
        public static int Cenakomp,Cenamonitor,Cenaall;
        
        public Form1()
        {
            InitializeComponent();
            Cenakomp = 0;
            Cenamonitor = 0;
            Cenaall = 0;   
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cenamonitor = 0;
            Cenakomp = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

                Cenaall = Cenakomp + Cenamonitor;
                label1.Text = Cenaall.ToString();
           
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}