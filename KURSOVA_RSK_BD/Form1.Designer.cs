namespace KURSOVA_RSK_BD
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
            dataSourceText = new TextBox();
            dataBaseText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // dataSourceText
            // 
            dataSourceText.Location = new Point(145, 68);
            dataSourceText.Name = "dataSourceText";
            dataSourceText.Size = new Size(125, 27);
            dataSourceText.TabIndex = 0;
            // 
            // dataBaseText
            // 
            dataBaseText.Location = new Point(145, 130);
            dataBaseText.Name = "dataBaseText";
            dataBaseText.Size = new Size(125, 27);
            dataBaseText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "Data source";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 3;
            label2.Text = "Database name";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(69, 204);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(177, 43);
            confirmButton.TabIndex = 4;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 271);
            Controls.Add(confirmButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataBaseText);
            Controls.Add(dataSourceText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dataSourceText;
        private TextBox dataBaseText;
        private Label label1;
        private Label label2;
        private Button confirmButton;
    }
}