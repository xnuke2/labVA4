namespace labVA4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDownRows = new NumericUpDown();
            numericUpDownColumns = new NumericUpDown();
            label2 = new Label();
            radioButtonUser = new RadioButton();
            radioButtonRandom = new RadioButton();
            groupBox1 = new GroupBox();
            buttonFind = new Button();
            buttonShowSLAY = new Button();
            groupBox3 = new GroupBox();
            label3 = new Label();
            numericUpDownrandomMax = new NumericUpDown();
            numericUpDownRandomMin = new NumericUpDown();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridViewSLAYpreview = new DataGridView();
            dataGridViewRezult = new DataGridView();
            listBoxRezult = new ListBox();
            groupBox4 = new GroupBox();
            label4 = new Label();
            groupBoxPrew = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownColumns).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownrandomMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRandomMin).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSLAYpreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRezult).BeginInit();
            groupBox4.SuspendLayout();
            groupBoxPrew.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDownRows
            // 
            numericUpDownRows.Location = new Point(8, 22);
            numericUpDownRows.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownRows.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownRows.Name = "numericUpDownRows";
            numericUpDownRows.Size = new Size(52, 23);
            numericUpDownRows.TabIndex = 1;
            numericUpDownRows.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDownColumns
            // 
            numericUpDownColumns.Location = new Point(82, 22);
            numericUpDownColumns.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownColumns.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownColumns.Name = "numericUpDownColumns";
            numericUpDownColumns.Size = new Size(52, 23);
            numericUpDownColumns.TabIndex = 2;
            numericUpDownColumns.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 27);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 3;
            label2.Text = "х";
            // 
            // radioButtonUser
            // 
            radioButtonUser.AutoSize = true;
            radioButtonUser.Location = new Point(4, 22);
            radioButtonUser.Name = "radioButtonUser";
            radioButtonUser.Size = new Size(160, 19);
            radioButtonUser.TabIndex = 4;
            radioButtonUser.Text = "Задаётся пользователем";
            radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonRandom
            // 
            radioButtonRandom.AutoSize = true;
            radioButtonRandom.Checked = true;
            radioButtonRandom.Location = new Point(170, 22);
            radioButtonRandom.Name = "radioButtonRandom";
            radioButtonRandom.Size = new Size(169, 19);
            radioButtonRandom.TabIndex = 5;
            radioButtonRandom.TabStop = true;
            radioButtonRandom.Text = "Случайно сгенерированы";
            radioButtonRandom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(buttonFind);
            groupBox1.Controls.Add(buttonShowSLAY);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(771, 97);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройка СЛАУ";
            // 
            // buttonFind
            // 
            buttonFind.Enabled = false;
            buttonFind.Location = new Point(530, 57);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(235, 31);
            buttonFind.TabIndex = 9;
            buttonFind.Text = "Решить";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // buttonShowSLAY
            // 
            buttonShowSLAY.Location = new Point(530, 20);
            buttonShowSLAY.Name = "buttonShowSLAY";
            buttonShowSLAY.Size = new Size(235, 31);
            buttonShowSLAY.TabIndex = 8;
            buttonShowSLAY.Text = "Отобразить СЛАУ";
            buttonShowSLAY.UseVisualStyleBackColor = true;
            buttonShowSLAY.Click += buttonShowSLAY_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(numericUpDownrandomMax);
            groupBox3.Controls.Add(numericUpDownRandomMin);
            groupBox3.Controls.Add(radioButtonRandom);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(radioButtonUser);
            groupBox3.Location = new Point(165, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(359, 71);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Коэфициенты и свободные члены";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 45);
            label3.Name = "label3";
            label3.Size = new Size(179, 15);
            label3.TabIndex = 7;
            label3.Text = "Интервал случайных значений";
            // 
            // numericUpDownrandomMax
            // 
            numericUpDownrandomMax.Location = new Point(287, 43);
            numericUpDownrandomMax.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownrandomMax.Name = "numericUpDownrandomMax";
            numericUpDownrandomMax.Size = new Size(52, 23);
            numericUpDownrandomMax.TabIndex = 5;
            numericUpDownrandomMax.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericUpDownRandomMin
            // 
            numericUpDownRandomMin.Location = new Point(213, 43);
            numericUpDownRandomMin.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownRandomMin.Name = "numericUpDownRandomMin";
            numericUpDownRandomMin.Size = new Size(52, 23);
            numericUpDownRandomMin.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 48);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 6;
            label1.Text = "до";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(numericUpDownColumns);
            groupBox2.Controls.Add(numericUpDownRows);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(6, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(153, 71);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Порядок СЛАУ";
            // 
            // dataGridViewSLAYpreview
            // 
            dataGridViewSLAYpreview.AllowUserToAddRows = false;
            dataGridViewSLAYpreview.AllowUserToDeleteRows = false;
            dataGridViewSLAYpreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSLAYpreview.Location = new Point(14, 22);
            dataGridViewSLAYpreview.Name = "dataGridViewSLAYpreview";
            dataGridViewSLAYpreview.RowHeadersVisible = false;
            dataGridViewSLAYpreview.Size = new Size(508, 394);
            dataGridViewSLAYpreview.TabIndex = 7;
            // 
            // dataGridViewRezult
            // 
            dataGridViewRezult.AllowUserToAddRows = false;
            dataGridViewRezult.AllowUserToDeleteRows = false;
            dataGridViewRezult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRezult.Location = new Point(171, 22);
            dataGridViewRezult.Name = "dataGridViewRezult";
            dataGridViewRezult.ReadOnly = true;
            dataGridViewRezult.Size = new Size(508, 394);
            dataGridViewRezult.TabIndex = 9;
            // 
            // listBoxRezult
            // 
            listBoxRezult.FormattingEnabled = true;
            listBoxRezult.ItemHeight = 15;
            listBoxRezult.Location = new Point(6, 52);
            listBoxRezult.Name = "listBoxRezult";
            listBoxRezult.Size = new Size(159, 199);
            listBoxRezult.TabIndex = 10;
            listBoxRezult.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(listBoxRezult);
            groupBox4.Controls.Add(dataGridViewRezult);
            groupBox4.Location = new Point(12, 111);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(771, 426);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Результат";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 34);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 11;
            label4.Text = "Выбор итерации";
            // 
            // groupBoxPrew
            // 
            groupBoxPrew.Controls.Add(dataGridViewSLAYpreview);
            groupBoxPrew.Location = new Point(12, 111);
            groupBoxPrew.Name = "groupBoxPrew";
            groupBoxPrew.Size = new Size(771, 426);
            groupBoxPrew.TabIndex = 12;
            groupBoxPrew.TabStop = false;
            groupBoxPrew.Text = "Предпросмотр/редактирование СЛАУ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 542);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxPrew);
            Controls.Add(groupBox4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownColumns).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownrandomMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRandomMin).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSLAYpreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRezult).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBoxPrew.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown numericUpDownRows;
        private NumericUpDown numericUpDownColumns;
        private Label label2;
        private RadioButton radioButtonUser;
        private RadioButton radioButtonRandom;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView dataGridViewSLAYpreview;
        private DataGridView dataGridViewRezult;
        private Button buttonFind;
        private Button buttonShowSLAY;
        private Label label3;
        private NumericUpDown numericUpDownrandomMax;
        private NumericUpDown numericUpDownRandomMin;
        private Label label1;
        private ListBox listBoxRezult;
        private GroupBox groupBox4;
        private Label label4;
        private GroupBox groupBoxPrew;
    }
}
