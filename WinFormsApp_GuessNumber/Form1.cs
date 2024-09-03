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

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void buttonGO_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // ���������, ������ �� ������� Enter
            if (e.KeyCode == Keys.Enter)
            {
                // ��������� ����� �� ���������� ����
                string userInputText = textBox1.Text;

                // ������� ������������� ��������� ����� � �����
                if (int.TryParse(userInputText, out _userInput))
                {
                    // ������ ����� ��������� ����� �����
                    MessageBox.Show($"�� ����� �����: {_userInput}");
                }
                else
                {
                    // ���� �� ������� ������������� � �����
                    MessageBox.Show("����������, ������� ���������� �����.");
                }

                // ����� �������� ��������� ����, ���� �����
                textBox1.Clear();

                // ����� Enter �� ������������� ���� ���������� �����������
                e.SuppressKeyPress = true;
            }
        }
    }
    }
