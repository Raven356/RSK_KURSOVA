namespace KURSOVA_RSK_BD
{
    partial class EnterModulesAndTime
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tzTextBox = new TextBox();
            tpTextBox = new TextBox();
            lcpTextBox = new TextBox();
            VcpTextBox = new TextBox();
            tvzTextBox = new TextBox();
            amountOfModulesUpDown = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            amountOfDetailsUpDown = new NumericUpDown();
            insertButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountOfModulesUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountOfDetailsUpDown).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(410, 361);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(566, 159);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 1;
            label1.Text = "tз";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(566, 211);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 2;
            label2.Text = "tр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(566, 260);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 3;
            label3.Text = "lcр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(566, 308);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 4;
            label4.Text = "Vcр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(566, 360);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 5;
            label5.Text = "tвз/tпост";
            // 
            // tzTextBox
            // 
            tzTextBox.Location = new Point(657, 156);
            tzTextBox.Name = "tzTextBox";
            tzTextBox.Size = new Size(125, 27);
            tzTextBox.TabIndex = 6;
            tzTextBox.Text = "6";
            // 
            // tpTextBox
            // 
            tpTextBox.Location = new Point(657, 208);
            tpTextBox.Name = "tpTextBox";
            tpTextBox.Size = new Size(125, 27);
            tpTextBox.TabIndex = 7;
            tpTextBox.Text = "4";
            // 
            // lcpTextBox
            // 
            lcpTextBox.Location = new Point(657, 257);
            lcpTextBox.Name = "lcpTextBox";
            lcpTextBox.Size = new Size(125, 27);
            lcpTextBox.TabIndex = 8;
            lcpTextBox.Text = "35";
            // 
            // VcpTextBox
            // 
            VcpTextBox.Location = new Point(657, 305);
            VcpTextBox.Name = "VcpTextBox";
            VcpTextBox.Size = new Size(125, 27);
            VcpTextBox.TabIndex = 9;
            VcpTextBox.Text = "30";
            // 
            // tvzTextBox
            // 
            tvzTextBox.Location = new Point(657, 357);
            tvzTextBox.Name = "tvzTextBox";
            tvzTextBox.Size = new Size(125, 27);
            tvzTextBox.TabIndex = 10;
            tvzTextBox.Text = "0,25";
            // 
            // amountOfModulesUpDown
            // 
            amountOfModulesUpDown.Location = new Point(234, 34);
            amountOfModulesUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amountOfModulesUpDown.Name = "amountOfModulesUpDown";
            amountOfModulesUpDown.Size = new Size(54, 27);
            amountOfModulesUpDown.TabIndex = 11;
            amountOfModulesUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            amountOfModulesUpDown.ValueChanged += amountOfModulesUpDown_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 36);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 12;
            label6.Text = "Кількість модулів";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 40);
            label7.Name = "label7";
            label7.Size = new Size(289, 20);
            label7.TabIndex = 13;
            label7.Text = "Максимальна кількість деталей у модулі";
            // 
            // amountOfDetailsUpDown
            // 
            amountOfDetailsUpDown.Location = new Point(673, 38);
            amountOfDetailsUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            amountOfDetailsUpDown.Name = "amountOfDetailsUpDown";
            amountOfDetailsUpDown.Size = new Size(55, 27);
            amountOfDetailsUpDown.TabIndex = 14;
            amountOfDetailsUpDown.Value = new decimal(new int[] { 9, 0, 0, 0 });
            amountOfDetailsUpDown.ValueChanged += amountOfDetailsUpDown_ValueChanged;
            // 
            // insertButton
            // 
            insertButton.Location = new Point(613, 410);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(156, 70);
            insertButton.TabIndex = 15;
            insertButton.Text = "Вставити дані";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click;
            // 
            // EnterModulesAndTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(963, 518);
            Controls.Add(insertButton);
            Controls.Add(amountOfDetailsUpDown);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(amountOfModulesUpDown);
            Controls.Add(tvzTextBox);
            Controls.Add(VcpTextBox);
            Controls.Add(lcpTextBox);
            Controls.Add(tpTextBox);
            Controls.Add(tzTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "EnterModulesAndTime";
            Text = "EnterModulesAndTime";
            Load += EnterModulesAndTime_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountOfModulesUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountOfDetailsUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tzTextBox;
        private TextBox tpTextBox;
        private TextBox lcpTextBox;
        private TextBox VcpTextBox;
        private TextBox tvzTextBox;
        private NumericUpDown amountOfModulesUpDown;
        private Label label6;
        private Label label7;
        private NumericUpDown amountOfDetailsUpDown;
        private Button insertButton;
    }
}