namespace WinFormsApp3
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
            label1 = new Label();
            label2 = new Label();
            labelOutcome = new Label();
            textBoxWord = new TextBox();
            buttonAdd = new Button();
            buttonConcatenate = new Button();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            radioButtonRemove1 = new RadioButton();
            radioButtonRemove2 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter a word:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 164);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 1;
            label2.Text = "OR";
            // 
            // labelOutcome
            // 
            labelOutcome.AutoSize = true;
            labelOutcome.BackColor = Color.White;
            labelOutcome.Location = new Point(241, 461);
            labelOutcome.Name = "labelOutcome";
            labelOutcome.Padding = new Padding(100, 50, 100, 50);
            labelOutcome.Size = new Size(259, 125);
            labelOutcome.TabIndex = 2;
            labelOutcome.Text = "label3";
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(295, 49);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(150, 31);
            textBoxWord.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(315, 106);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "button1";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonConcatenate
            // 
            buttonConcatenate.Location = new Point(315, 379);
            buttonConcatenate.Name = "buttonConcatenate";
            buttonConcatenate.Size = new Size(112, 34);
            buttonConcatenate.TabIndex = 5;
            buttonConcatenate.Text = "Concatenate";
            buttonConcatenate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 232);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 6;
            label4.Text = "Select a word:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(593, 232);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 7;
            label5.Text = "Select another word:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 270);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(585, 270);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 9;
            // 
            // radioButtonRemove1
            // 
            radioButtonRemove1.AutoSize = true;
            radioButtonRemove1.Location = new Point(19, 318);
            radioButtonRemove1.Name = "radioButtonRemove1";
            radioButtonRemove1.Size = new Size(101, 29);
            radioButtonRemove1.TabIndex = 10;
            radioButtonRemove1.TabStop = true;
            radioButtonRemove1.Text = "Remove";
            radioButtonRemove1.UseVisualStyleBackColor = true;
            // 
            // radioButtonRemove2
            // 
            radioButtonRemove2.AutoSize = true;
            radioButtonRemove2.Location = new Point(585, 338);
            radioButtonRemove2.Name = "radioButtonRemove2";
            radioButtonRemove2.Size = new Size(101, 29);
            radioButtonRemove2.TabIndex = 11;
            radioButtonRemove2.TabStop = true;
            radioButtonRemove2.Text = "Remove";
            radioButtonRemove2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 641);
            Controls.Add(radioButtonRemove2);
            Controls.Add(radioButtonRemove1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonConcatenate);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxWord);
            Controls.Add(labelOutcome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelOutcome;
        private TextBox textBoxWord;
        private Button buttonAdd;
        private Button buttonConcatenate;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton radioButtonRemove1;
        private RadioButton radioButtonRemove2;
    }
}