using System;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Rapid_Obfuscator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void linkCheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //функция клика пункта "выбрать все" (параметры обфускации)
        {
            CheckBox[] checkBoxes = { checkBox1, checkBox3, checkBox4 }; //массив элементов checkbox
            bool status;
            if (linkCheckAll.Text == "Выбрать все")
            {
                status = true;
                linkCheckAll.Text = "Очистить все";
            }
            else
            {
                status = false;
                linkCheckAll.Text = "Выбрать все";
            }

            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.Checked = status;
            }
        }


        private void panel2_DragEnter(object sender, DragEventArgs e) //функция в панели если файл навели в ее область
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) //проверка данных которые навели на панель
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop); //записываем перенесенные файлы в массив
                string fileName = files[0].ToString();
                if (Path.GetExtension(fileName) == ".cs") //проверка верного расширения, если верно, то:
                {
                    pictureDragInfo.BackgroundImage = Properties.Resources.plus;
                    labelDragInfo.Text = "Отпустите мышь";
                    e.Effect = DragDropEffects.Copy;
                }
                else // если расширение не подходит, выводим соответсвующее сообщение
                {
                    pictureDragInfo.BackgroundImage = Properties.Resources.error;
                    labelDragInfo.Text = "Поддерживаются файлы\nтолько с раширением \"cs\""; 
                }
            }
        }

        private void panel2_DragDrop(object sender, DragEventArgs e) 
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string fileName = files[0].ToString();
            if (Path.GetExtension(fileName) == ".cs")
            {
                labelDragInfo.Text = Path.GetFileName(fileName);
                pictureDragInfo.BackgroundImage = Properties.Resources.proga;
                labelFileIn.Text = fileName;
                openFileDialog1.FileName = fileName;
                labelFileIn.Text = fileName;
            }
            else
            {
                pictureDragInfo.BackgroundImage = Properties.Resources.error;
                labelDragInfo.Text = "Поддерживаются файлы\nс раширением \"cs\"";
            }
        }

        private void panel2_DragLeave(object sender, EventArgs e)  //событие когда мышь убрана с панели
        {
            if (labelFileIn.Text != "")
            {
                labelDragInfo.Text = Path.GetFileName(labelFileIn.Text);
                pictureDragInfo.BackgroundImage = Properties.Resources.proga;
            }
            else
            {
                pictureDragInfo.BackgroundImage = Properties.Resources.plus;
                labelDragInfo.Text = "Перетащите файл сюда";
            }
        }

        private void pictureDragInfo_Click(object sender, EventArgs e)  //событие при нажатии на икноку плюсика
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)  //открываем диалоговое окно выбора файла
                return;
            if (Path.GetExtension(openFileDialog1.FileName) == ".cs")   //проверка верного расширения
            {
                string fileName = openFileDialog1.FileName;
                labelFileIn.Text = fileName;
                labelDragInfo.Text = Path.GetFileName(fileName);
                pictureDragInfo.BackgroundImage = Properties.Resources.proga;
            }
            else  //если расширение неверное, выводим сообщение об этом
            {
                MessageBox.Show("Поддерживаются файлы только с раширением \"cs\".", "Rapid Obfuscator - Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.btn_click;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.btn_enter;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.btn_click;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.btn;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.btn_click;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.btn_enter;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.btn;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)  //функция клика по кнопке "обфускаия"
        {
            pictureBox1.BackgroundImage = Properties.Resources.btn;
            bool status = false;
            Obfuscate ob = new Obfuscate();
            if (File.Exists(labelFileIn.Text))
            {
                if (!checkBox3.Checked && checkBox4.Checked)  //проверяем выбор параметров "код в одну строку" и "удаление комментариев"
                {
                    MessageBox.Show("Для правильной работы обфускации по параметру \"Код в одну строку\", необходимо выбрать параметр \"Удаление комментариев\"", "Rapid Obfuscator - Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    File.Copy(labelFileIn.Text, "temp.ro", true);  //копируем исходный код программы во временный файл
                    if (checkBox1.Checked)  //если выбран первый параметр
                    {
                        ob.ReplaceVariable();  //заменяем название переменных
                        status = true;
                    }
                    if (checkBox3.Checked)  //если выбран 2 параметр
                    {
                        StringBuilder content = new StringBuilder();
                        content.Append(File.ReadAllText(labelFileIn.Text));

                        ob.DeleteComment(content, "/*", "*/");  //удаляем многострочные комментарии
                        ob.DeleteComment(content, "/// <summary>", "/// </summary>"); //удаляем summary комментарии
                        ob.DeleteComment(content, "//", Environment.NewLine); //удаляем однострочные комментарии

                        status = true;
                    }
                    if (checkBox4.Checked) //если выбран 3 параметр
                    {
                        ob.MakeOneSting(); //преобразовываем код в одну строку
                        status = true;
                    }
                    if (status)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)  //открываем диалог сохранения файлов
                            return;
                        ob.SaveFile(saveFileDialog1.FileName); //сохраняем файл
                    }
                    else //если не выбран ни один параметр обфускации
                    {
                        MessageBox.Show("Необходимо выбрать хотя бы один параметр обфускации.", "Rapid Obfuscator - Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);  //выводим сообщение об ошибке
                    }
                }
            }
            else  //если файл был не указан
            {
                MessageBox.Show("Необходимо указать файл с исходным кодом.", "Rapid Obfuscator - Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);  //выводим сообщение об ошибке
            }

        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)  //вывод справки об обфускаторе
        {
            MessageBox.Show(" Обфуска́ция (от английского obfuscate — делать неочевидным, запутанным, сбивать с толку)  в широком смысле - приведение исходного текста или исполняемого кода программы к виду, сохраняющему её функциональность, но затрудняющему анализ, понимание алгоритмов работы и модификацию при декомпиляции.\n\n Для обфускацирования файла, перетащите файл исходного кода C# на панель в правой части программы, либо нажмите на иконку плюса и укажите необходимый файл.\n Далее в левой части экрана выберите параметры обфускации и нажмите на кнопку \"Обфусцировать\"", "Rapid Obfuscator - Справка");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)  //кнопка редактирования исходного кода
        {
            string filePath = labelFileIn.Text;
            if (filePath != "-")
            {
                System.Diagnostics.Process.Start(filePath);  //открытие исходного кода в редакторе по умолчанию
            }
            else  //если файл не указан
            {
                MessageBox.Show("Необходимо указать файл с исходным кодом.", "Rapid Obfuscator - Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);  //выводим сообщение об ошибке
            }
        }
    }
}
