using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            int a, b, z;// Объявление переменных типа int
            {
                textBox1.Focus(); // Передача управления строке ввода
                try
                {
                    if (textBox1.Text == "" || textBox2.Text == "")
                    /* Проверка наличия данных в текстовых строках */
                    {
                        MessageBox.Show("Введите аргументы"); /* Вывод сообщения об отсутсвии аргументов */
                        return;/*Если требуется выйти из процедуры досрочно, то можно воспользоваться оператором return */
                    }
                    a = Convert.ToInt16(textBox1.Text); /* Преобразование символьных данных, находящихся в строке редактирования textBox1, в тип double */
                    b = Convert.ToInt16(textBox2.Text);
                    b = b * b;
                    z = b + a; //Вычисление функции
                    richTextBox1.Text = Convert.ToString(z); /* Перевод числа в строковый тип и вывод результата в строке редактирования textBox3 */
                }
                catch (System.FormatException) /* Обработка неверно введенного формата, т.к пользователь может ввести не только цифры, но и буквы */
                {
                    MessageBox.Show("Ошибка: Введите цифры");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();// Очистка прежних значений
            textBox2.Clear();// в строковых полях
            richTextBox1.Clear();
        }
    }
}

