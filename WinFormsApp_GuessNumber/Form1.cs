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
            // Проверяем, нажата ли клавиша Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Считываем текст из текстового поля
                string userInputText = textBox1.Text;

                // Пробуем преобразовать введенный текст в число
                if (int.TryParse(userInputText, out _userInput))
                {
                    // Логика после успешного ввода числа
                    MessageBox.Show($"Вы ввели число: {_userInput}");
                }
                else
                {
                    // Если не удалось преобразовать в число
                    MessageBox.Show("Пожалуйста, введите корректное число.");
                }

                // Можно очистить текстовое поле, если нужно
                textBox1.Clear();

                // Чтобы Enter не воспроизводил звук системного уведомления
                e.SuppressKeyPress = true;
            }
        }
    }
    }
