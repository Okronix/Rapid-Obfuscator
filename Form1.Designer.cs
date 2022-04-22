namespace Rapid_Obfuscator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.linkCheckAll = new System.Windows.Forms.LinkLabel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.labelFileIn = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureDragInfo = new System.Windows.Forms.PictureBox();
            this.labelDragInfo = new System.Windows.Forms.Label();
            this.groupBoxParametrs.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDragInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "cs";
            this.openFileDialog1.Filter = "C# files|*.cs";
            this.openFileDialog1.Title = "Выберите файл";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(10, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(234, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Сменить названия переменных";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.groupBoxParametrs.Controls.Add(this.checkBox4);
            this.groupBoxParametrs.Controls.Add(this.linkCheckAll);
            this.groupBoxParametrs.Controls.Add(this.checkBox2);
            this.groupBoxParametrs.Controls.Add(this.checkBox3);
            this.groupBoxParametrs.Controls.Add(this.checkBox1);
            this.groupBoxParametrs.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxParametrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.groupBoxParametrs.Location = new System.Drawing.Point(12, 106);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(361, 163);
            this.groupBoxParametrs.TabIndex = 4;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Параметры обфускации";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(10, 102);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(148, 21);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Код в одну строку";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // linkCheckAll
            // 
            this.linkCheckAll.AutoSize = true;
            this.linkCheckAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkCheckAll.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkCheckAll.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(144)))), ((int)(((byte)(192)))));
            this.linkCheckAll.Location = new System.Drawing.Point(6, 136);
            this.linkCheckAll.Name = "linkCheckAll";
            this.linkCheckAll.Size = new System.Drawing.Size(80, 17);
            this.linkCheckAll.TabIndex = 6;
            this.linkCheckAll.TabStop = true;
            this.linkCheckAll.Text = "Выбрать все";
            this.linkCheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCheckAll_LinkClicked);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(10, 48);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(240, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Шифровать данные переменных";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(10, 75);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(174, 21);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Удалить комментарии";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(80)))), ((int)(((byte)(85)))));
            this.groupBoxPath.Controls.Add(this.labelFileIn);
            this.groupBoxPath.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.groupBoxPath.Location = new System.Drawing.Point(12, 14);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(361, 86);
            this.groupBoxPath.TabIndex = 5;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Пути файлов";
            // 
            // labelFileIn
            // 
            this.labelFileIn.AutoSize = true;
            this.labelFileIn.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileIn.Location = new System.Drawing.Point(7, 21);
            this.labelFileIn.Name = "labelFileIn";
            this.labelFileIn.Size = new System.Drawing.Size(13, 17);
            this.labelFileIn.TabIndex = 4;
            this.labelFileIn.Text = "-";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "cs";
            this.saveFileDialog1.Filter = "C# files|*.cs";
            this.saveFileDialog1.Title = "Сохранение файла";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBoxPath);
            this.panel1.Controls.Add(this.groupBoxParametrs);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 343);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Rapid_Obfuscator.Properties.Resources.btn;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(14, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 51);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.pictureDragInfo);
            this.panel2.Controls.Add(this.labelDragInfo);
            this.panel2.Location = new System.Drawing.Point(385, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 343);
            this.panel2.TabIndex = 8;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel2_DragEnter);
            this.panel2.DragLeave += new System.EventHandler(this.panel2_DragLeave);
            // 
            // pictureDragInfo
            // 
            this.pictureDragInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureDragInfo.BackgroundImage")));
            this.pictureDragInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureDragInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureDragInfo.Location = new System.Drawing.Point(74, 94);
            this.pictureDragInfo.Name = "pictureDragInfo";
            this.pictureDragInfo.Size = new System.Drawing.Size(116, 113);
            this.pictureDragInfo.TabIndex = 7;
            this.pictureDragInfo.TabStop = false;
            this.pictureDragInfo.Click += new System.EventHandler(this.pictureDragInfo_Click);
            // 
            // labelDragInfo
            // 
            this.labelDragInfo.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDragInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.labelDragInfo.Location = new System.Drawing.Point(16, 216);
            this.labelDragInfo.Name = "labelDragInfo";
            this.labelDragInfo.Size = new System.Drawing.Size(229, 44);
            this.labelDragInfo.TabIndex = 6;
            this.labelDragInfo.Text = "Перетащите файл сюда";
            this.labelDragInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(660, 339);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapid Obfuscator";
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxParametrs.PerformLayout();
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDragInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.Label labelFileIn;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.LinkLabel linkCheckAll;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDragInfo;
        private System.Windows.Forms.PictureBox pictureDragInfo;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

