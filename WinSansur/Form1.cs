namespace WinSansur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yeniMetin;
            foreach (var item in listBox1.Items)
            {
                textBox1.Text = textBox1.Text.Replace(item.ToString(), "***");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
           

        }
    }
}