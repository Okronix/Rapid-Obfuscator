using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Rapid_Obfuscator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //Размеры окна 676; 374
        }
        private void btnOpenFileIn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = openFileDialog1.FileName;
            labelFileIn.Text = fileName;
            labelDragInfo.Text = Path.GetFileName(fileName);
            pictureDragInfo.BackgroundImage = Properties.Resources.proga;
        }

        private void linkCheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3, checkBox4 };
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


        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string fileName = files[0].ToString();
                if (Path.GetExtension(fileName) == ".cs")
                {
                    pictureDragInfo.BackgroundImage = Properties.Resources.plus;
                    labelDragInfo.Text = "Отпустите мышь";
                    e.Effect = DragDropEffects.Copy;
                }
                else
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

        private void panel2_DragLeave(object sender, EventArgs e)
        {
            if(labelFileIn.Text != "")
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

        private void pictureDragInfo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            if(Path.GetExtension(openFileDialog1.FileName) == ".cs")
            {
            string fileName = openFileDialog1.FileName;
                labelFileIn.Text = fileName;
            labelDragInfo.Text = Path.GetFileName(fileName);
            pictureDragInfo.BackgroundImage = Properties.Resources.proga;
            }
            else
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
            //size 144; 52
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

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.btn;
            //CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3 };
            bool status = false;
            Obfuscate ob = new Obfuscate();
            if(File.Exists(labelFileIn.Text))
            {
                if (checkBox1.Checked)
                {
                    ob.ReplaceVariable(labelFileIn.Text);
                    status = true;
                }
                if (checkBox2.Checked)
                {
                    status = true;
                }
                if (checkBox3.Checked)
                {
                    status = true;
                }
                if (checkBox4.Checked)
                {
                    status = true;
                }
                if (status)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return;
                    ob.SaveFile(saveFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать хотя бы один параметр обфускации.", "Rapid Obfuscator - Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Необходимо указать файл с исходным кодом.", "Rapid Obfuscator - Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //foreach (CheckBox checkBox in checkBoxes)
            //{
            //    if(checkBox.Checked)
            //    {
            //        switch (checkBox.Text)
            //        {
            //            case "Сменить названия переменных":
            //                {
            //                    break;
            //                }
            //            case "Шифровать данные переменных":
            //                {
            //                    break;
            //                }
            //            case "Код в одну строку":
            //                {
            //                    break;
            //                }
            //        }
            //    }
            //}
            //if (!status)
            //{
            //    MessageBox.Show("Необходимо выбрать хотя бы один параметр обфускации.", "Rapid Obfuscator - Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
    }
}
