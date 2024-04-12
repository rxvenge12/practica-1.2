using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practica_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения переменных a и b из текстовых полей и преобразуем их в double
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);

                // Вычисляем значение выражения
                double result = Math.Pow(Math.Sin(a + Math.Pow(b, 3)), 2) * Math.Sqrt(Math.Exp(Math.Pow(a, 2) - 9.4) / Math.Pow(a + b, 3));

                // Выводим результат на текстовое поле labelResult
                label1.Text = $"Значение выражения sin^2(a+b^3) * sqrt(e^(a^2-9.4) / (a+b)^3) равно {result:F4}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Неверный формат числа. Пожалуйста, введите числовое значение для всех полей.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
