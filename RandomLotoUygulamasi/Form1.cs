namespace RandomLotoUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            label1.Text=rnd.Next(1, 10).ToString();
            label2.Text= rnd.Next(1, 10).ToString();
            label3.Text = rnd.Next(1, 10).ToString();
            label4.Text = rnd.Next(1, 10).ToString();
            label5.Text = rnd.Next(1, 10).ToString();
            label6.Text = rnd.Next(1, 10).ToString();


            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else {
                textBox3.BackColor = Color.Red;
            }

            if(textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else {  textBox4.BackColor = Color.Red; }

            if (textBox5.Text == label5.Text)
            {
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }

            if (label6.Text == textBox6.Text)
            {  
                textBox6.BackColor = Color.Green;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }
        }
    }
}
