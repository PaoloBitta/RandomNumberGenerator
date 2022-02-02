namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FormuleMatematiche formuleMath = new FormuleMatematiche();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
               button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           label1.Text=Convert.ToString(Convert.ToInt32(formuleMath.rnd(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))));
        }

    }
}