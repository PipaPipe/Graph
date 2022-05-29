using System;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e) //кнопка начать
        {
            Hide(); //скрываем первую форму
            Form2 newForm = new Form2();
            newForm.Show(); //открываем вторую форму
        }

        private void exitBtn_Click(object sender, EventArgs e) //кнопка выход
        {
            DialogResult r = MessageBox.Show("Вы действительно хотите завершить работу?", "Завершение работы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes) //если результат диалогового окна - нажатие кнопки "Да" 
            {
                Application.Exit(); //завершение работы приложения
            }
        }
    }
}
