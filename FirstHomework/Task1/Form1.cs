using System;
using System.Windows.Forms;

namespace Task1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            string surname = "Бекмухамбет";
            string name = "Алишер";
            string middleName = "Айболатулы";
            string birthday = "08.07.1995";
            string education = "Академии Шаг";
            MessageBox.Show(surname, "Фамилия");
            MessageBox.Show(name, "Имя");
            MessageBox.Show(middleName, "Отчество");
            MessageBox.Show(birthday, "Дата рождения");
            int length = (surname.Length + name.Length + middleName.Length + birthday.Length + education.Length) / 5;
            MessageBox.Show(education, length.ToString());
        }
    }
}
