using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private int currentTextBoxIndex = 0;
        public Form1()
        {
            InitializeComponent();
            button2.Click += ClearButton_Click;
            button3.Click += ClearButton_Click;
            button4.Click += ClearButton_Click;
            button5.Click += ClearButton_Click;
            button6.Click += ClearButton_Click;

            // Назначение обработчика события для кнопки добавления
            button1.Click += AddButton_Click;

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Определение, какая кнопка была нажата, и очистка соответствующего TextBox
            if (sender == button2)
            {
                textBox2.Clear();
            }
            else if (sender == button3)
            {
                textBox3.Clear();
            }
            else if (sender == button4)
            {
                textBox4.Clear();
            }
            else if (sender == button5)
            {
                textBox5.Clear();
            }
            else if (sender == button6)
            {
                textBox6.Clear();
            }

            ResetTextBoxIndexIfNeeded();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Добавление текста из textBox1 в первый доступный пустой TextBox на первой вкладке
            bool added = false;

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text = textBox1.Text;
                added = true;
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Text = textBox1.Text;
                added = true;
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Text = textBox1.Text;
                added = true;
            }
            else if (string.IsNullOrEmpty(textBox5.Text))
            {
                textBox5.Text = textBox1.Text;
                added = true;
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox6.Text = textBox1.Text;
                added = true;
            }

            if (added)
            {
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Все текстовые поля заполнены.");
            }
        }

        private void ResetTextBoxIndexIfNeeded()
        {
            // Сброс индекса, если все текстовые поля пусты
            if (string.IsNullOrEmpty(textBox2.Text) &&
                string.IsNullOrEmpty(textBox3.Text) &&
                string.IsNullOrEmpty(textBox4.Text) &&
                string.IsNullOrEmpty(textBox5.Text) &&
                string.IsNullOrEmpty(textBox6.Text))
            {
                // Сбрасываем индекс, чтобы можно было снова добавлять текст с начала
                currentTextBoxIndex = 0;
            }
        }


        private void tabPage1_Click(object sender, EventArgs e) //переключатель вкладок
        {
        }

        private void button2_Click(object sender, EventArgs e)//кнопка очистить
        {

        }

        private void button3_Click(object sender, EventArgs e)//кнопка очистить
        {

        }

        private void button4_Click(object sender, EventArgs e)//кнопка очистить
        {

        }

        private void button5_Click(object sender, EventArgs e)//кнопка очистить
        {

        }

        private void button6_Click(object sender, EventArgs e)//кнопка очистить
        {

        }

        private void button1_Click(object sender, EventArgs e)//кнопка добавить
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//textbox с текстом задачи на 2 вкладке
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//поле с задачей на 1
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//поле с задачей на 1
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//поле с задачей на 1
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//поле с задачей на 1
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)//поле с задачей на 1
        {

        }
    }
}
