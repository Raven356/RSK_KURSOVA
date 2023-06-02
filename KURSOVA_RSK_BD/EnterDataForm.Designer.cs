namespace KURSOVA_RSK_BD
{
    partial class EnterDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            tObText = new TextBox();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            GVMUpDown = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GVMUpDown).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(464, 381);
            dataGridView1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(209, 21);
            numericUpDown1.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(50, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 14, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(440, 21);
            numericUpDown2.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(50, 27);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.Value = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 23);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 3;
            label1.Text = "Кількість деталей";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 23);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 4;
            label2.Text = "Кількість ДО";
            // 
            // button1
            // 
            button1.Location = new Point(440, 512);
            button1.Name = "button1";
            button1.Size = new Size(146, 50);
            button1.TabIndex = 5;
            button1.Text = "Вставити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tObText
            // 
            tObText.Location = new Point(637, 20);
            tObText.Name = "tObText";
            tObText.Size = new Size(125, 27);
            tObText.TabIndex = 6;
            tObText.Text = "0,4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(540, 23);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 7;
            label3.Text = "Введіть tоб";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(578, 87);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(437, 381);
            dataGridView2.TabIndex = 8;
            // 
            // GVMUpDown
            // 
            GVMUpDown.Location = new Point(945, 21);
            GVMUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            GVMUpDown.Name = "GVMUpDown";
            GVMUpDown.Size = new Size(51, 27);
            GVMUpDown.TabIndex = 9;
            GVMUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            GVMUpDown.ValueChanged += GVMUpDown_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(816, 23);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 10;
            label4.Text = "Кількість ГВМ";
            // 
            // EnterDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 596);
            Controls.Add(label4);
            Controls.Add(GVMUpDown);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(tObText);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(dataGridView1);
            Name = "EnterDataForm";
            Text = "EnterDataForm";
            FormClosed += EnterDataForm_FormClosed;
            Load += EnterDataForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)GVMUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox tObText;
        private Label label3;
        private DataGridView dataGridView2;
        private NumericUpDown GVMUpDown;
        private Label label4;
    }
}