namespace pract_3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateTable = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTable = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.table = new System.Windows.Forms.DataGridView();
            this.countRow = new System.Windows.Forms.NumericUpDown();
            this.countColumn = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setRowToAnswer = new System.Windows.Forms.NumericUpDown();
            this.answerS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.answerP = new System.Windows.Forms.TextBox();
            this.GetAnswer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setRowToAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.AboutUs,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.SaveFile,
            this.GenerateTable,
            this.ClearTable});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(133, 22);
            this.OpenFile.Text = "Открыть";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(133, 22);
            this.SaveFile.Text = "Сохранить";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // GenerateTable
            // 
            this.GenerateTable.Name = "GenerateTable";
            this.GenerateTable.Size = new System.Drawing.Size(133, 22);
            this.GenerateTable.Text = "Заполнить";
            this.GenerateTable.Click += new System.EventHandler(this.GenerateTable_Click);
            // 
            // ClearTable
            // 
            this.ClearTable.Name = "ClearTable";
            this.ClearTable.Size = new System.Drawing.Size(133, 22);
            this.ClearTable.Text = "Очистить";
            this.ClearTable.Click += new System.EventHandler(this.ClearTable_Click);
            // 
            // AboutUs
            // 
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(94, 20);
            this.AboutUs.Text = "О программе";
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(53, 20);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(13, 28);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(359, 112);
            this.table.TabIndex = 1;
            // 
            // countRow
            // 
            this.countRow.Location = new System.Drawing.Point(12, 159);
            this.countRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countRow.Name = "countRow";
            this.countRow.Size = new System.Drawing.Size(148, 20);
            this.countRow.TabIndex = 2;
            this.countRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // countColumn
            // 
            this.countColumn.Location = new System.Drawing.Point(12, 198);
            this.countColumn.Name = "countColumn";
            this.countColumn.Size = new System.Drawing.Size(148, 20);
            this.countColumn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Число строк";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Число столбцов";
            // 
            // setRowToAnswer
            // 
            this.setRowToAnswer.Location = new System.Drawing.Point(12, 239);
            this.setRowToAnswer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setRowToAnswer.Name = "setRowToAnswer";
            this.setRowToAnswer.Size = new System.Drawing.Size(148, 20);
            this.setRowToAnswer.TabIndex = 6;
            this.setRowToAnswer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // answerS
            // 
            this.answerS.Location = new System.Drawing.Point(210, 239);
            this.answerS.Name = "answerS";
            this.answerS.ReadOnly = true;
            this.answerS.Size = new System.Drawing.Size(162, 20);
            this.answerS.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Получить ответ из строки";
            // 
            // answerP
            // 
            this.answerP.Location = new System.Drawing.Point(210, 198);
            this.answerP.Name = "answerP";
            this.answerP.ReadOnly = true;
            this.answerP.Size = new System.Drawing.Size(162, 20);
            this.answerP.TabIndex = 9;
            // 
            // GetAnswer
            // 
            this.GetAnswer.Location = new System.Drawing.Point(210, 159);
            this.GetAnswer.Name = "GetAnswer";
            this.GetAnswer.Size = new System.Drawing.Size(162, 20);
            this.GetAnswer.TabIndex = 10;
            this.GetAnswer.Text = "Получить ответ";
            this.GetAnswer.UseVisualStyleBackColor = true;
            this.GetAnswer.Click += new System.EventHandler(this.GetAnswer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Произведение элементов строки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Сумма элементов строки";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 271);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GetAnswer);
            this.Controls.Add(this.answerP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answerS);
            this.Controls.Add(this.setRowToAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countColumn);
            this.Controls.Add(this.countRow);
            this.Controls.Add(this.table);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 310);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 310);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическая №3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setRowToAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem GenerateTable;
        private System.Windows.Forms.ToolStripMenuItem ClearTable;
        private System.Windows.Forms.ToolStripMenuItem AboutUs;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.NumericUpDown countRow;
        private System.Windows.Forms.NumericUpDown countColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown setRowToAnswer;
        private System.Windows.Forms.TextBox answerS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox answerP;
        private System.Windows.Forms.Button GetAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

