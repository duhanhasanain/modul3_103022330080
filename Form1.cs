namespace modul3_103022330080
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String value;
        int nilai1,hasil;

        private void button1_Click(object sender, EventArgs e)
        {
            value = "1";
            label1.Text = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value = "2";
            label1.Text = value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            value = "3";
            label1.Text = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            value = "4";
            label1.Text = value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            value = "5";
            label1.Text = value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            value = "6";
            label1.Text = value;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            value = "7";
            label1.Text = value;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            value = "8";
            label1.Text = value;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            value = "9";
            label1.Text = value;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            value = "0";
            label1.Text = value;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hasil += int.Parse(label1.Text);
            value = "";
            label1.Text = value;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hasil += int.Parse(label1.Text);
            label1.Text = hasil.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
