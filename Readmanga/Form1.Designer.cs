﻿namespace Readmanga
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameManga = new System.Windows.Forms.TextBox();
            this.numTom = new System.Windows.Forms.NumericUpDown();
            this.numChapter = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createPdf = new System.Windows.Forms.CheckBox();
            this.deletePic = new System.Windows.Forms.CheckBox();
            this.downloadAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChapter)).BeginInit();
            this.SuspendLayout();
            // 
            // nameManga
            // 
            this.nameManga.Location = new System.Drawing.Point(15, 25);
            this.nameManga.Name = "nameManga";
            this.nameManga.Size = new System.Drawing.Size(188, 20);
            this.nameManga.TabIndex = 1;
            // 
            // numTom
            // 
            this.numTom.Location = new System.Drawing.Point(15, 64);
            this.numTom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTom.Name = "numTom";
            this.numTom.Size = new System.Drawing.Size(188, 20);
            this.numTom.TabIndex = 2;
            this.numTom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numChapter
            // 
            this.numChapter.Location = new System.Drawing.Point(15, 116);
            this.numChapter.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numChapter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChapter.Name = "numChapter";
            this.numChapter.Size = new System.Drawing.Size(188, 20);
            this.numChapter.TabIndex = 3;
            this.numChapter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(15, 239);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(188, 23);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название манги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Номер тома";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Номер главы (до этого номера \r\nскачаются все главы в томе)";
            // 
            // createPdf
            // 
            this.createPdf.AutoSize = true;
            this.createPdf.Location = new System.Drawing.Point(15, 143);
            this.createPdf.Name = "createPdf";
            this.createPdf.Size = new System.Drawing.Size(181, 30);
            this.createPdf.TabIndex = 11;
            this.createPdf.Text = "Создать pdf после скачивания\r\n(изображения НЕ удалятся)";
            this.createPdf.UseVisualStyleBackColor = true;
            // 
            // deletePic
            // 
            this.deletePic.AutoSize = true;
            this.deletePic.Location = new System.Drawing.Point(15, 179);
            this.deletePic.Name = "deletePic";
            this.deletePic.Size = new System.Drawing.Size(140, 30);
            this.deletePic.TabIndex = 12;
            this.deletePic.Text = "Удалить изображения\r\n(создастся pdf файл)";
            this.deletePic.UseVisualStyleBackColor = true;
            // 
            // downloadAll
            // 
            this.downloadAll.AutoSize = true;
            this.downloadAll.Location = new System.Drawing.Point(15, 216);
            this.downloadAll.Name = "downloadAll";
            this.downloadAll.Size = new System.Drawing.Size(123, 17);
            this.downloadAll.TabIndex = 13;
            this.downloadAll.Text = "Скачать всю мангу";
            this.downloadAll.UseVisualStyleBackColor = true;
            this.downloadAll.CheckedChanged += new System.EventHandler(this.DownloadAll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 276);
            this.Controls.Add(this.downloadAll);
            this.Controls.Add(this.deletePic);
            this.Controls.Add(this.createPdf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.numChapter);
            this.Controls.Add(this.numTom);
            this.Controls.Add(this.nameManga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Readmanga";
            ((System.ComponentModel.ISupportInitialize)(this.numTom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChapter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameManga;
        private System.Windows.Forms.NumericUpDown numTom;
        private System.Windows.Forms.NumericUpDown numChapter;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox createPdf;
        private System.Windows.Forms.CheckBox deletePic;
        private System.Windows.Forms.CheckBox downloadAll;
    }
}
