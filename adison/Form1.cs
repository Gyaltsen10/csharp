namespace adison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Show();
            Form2 form = new Form2();
            form.ShowDialog();
             this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Show();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Hide();
        }
    }
}