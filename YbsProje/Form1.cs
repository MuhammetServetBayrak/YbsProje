namespace YbsProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (textBox1.Text == "muhammet" && textBox2.Text == "bayrak" || textBox1.Text == "ömer" && textBox2.Text == "güleç")
            {
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý AdI veya Þifre hatalý!");
            }

            
        }
    }
}