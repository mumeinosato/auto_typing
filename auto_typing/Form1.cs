namespace auto_typing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            s = textBox1.Text;
            System.Threading.Thread.Sleep(5000);
            SendKeys.Send(s);
        }
    }
}