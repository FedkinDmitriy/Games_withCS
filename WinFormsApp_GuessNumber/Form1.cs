namespace WinFormsApp_GuessNumber
{
    public partial class Form1 : Form
    {

        private string? _outputDate;
        private int _userInput;

        public Form1()
        {
            InitializeComponent();
            _outputDate = "Hello, let's play";
            label1.Text = _outputDate;

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _userInput = int.Parse(textBox1.Text);
            label1.Text = _userInput.ToString();
        }

    }
}
