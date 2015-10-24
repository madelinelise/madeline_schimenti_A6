namespace madeline_schimenti_A6
{
    partial class Form1
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
            this.labelInstruction = new System.Windows.Forms.Label();
            this.textBoxInputSentence = new System.Windows.Forms.TextBox();
            this.buttonAllWord = new System.Windows.Forms.Button();
            this.buttonDuplicateWords = new System.Windows.Forms.Button();
            this.textBoxAllWords = new System.Windows.Forms.TextBox();
            this.textBoxDistinctWords = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(32, 23);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(114, 13);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Type a sentence here:\r\n";
            // 
            // textBoxInputSentence
            // 
            this.textBoxInputSentence.Location = new System.Drawing.Point(35, 51);
            this.textBoxInputSentence.Name = "textBoxInputSentence";
            this.textBoxInputSentence.Size = new System.Drawing.Size(527, 20);
            this.textBoxInputSentence.TabIndex = 1;
            // 
            // buttonAllWord
            // 
            this.buttonAllWord.Location = new System.Drawing.Point(35, 121);
            this.buttonAllWord.Name = "buttonAllWord";
            this.buttonAllWord.Size = new System.Drawing.Size(75, 23);
            this.buttonAllWord.TabIndex = 2;
            this.buttonAllWord.Text = "All Words";
            this.buttonAllWord.UseVisualStyleBackColor = true;
            this.buttonAllWord.Click += new System.EventHandler(this.buttonAllWord_Click);
            // 
            // buttonDuplicateWords
            // 
            this.buttonDuplicateWords.Location = new System.Drawing.Point(329, 121);
            this.buttonDuplicateWords.Name = "buttonDuplicateWords";
            this.buttonDuplicateWords.Size = new System.Drawing.Size(96, 29);
            this.buttonDuplicateWords.TabIndex = 4;
            this.buttonDuplicateWords.Text = "Distinct Words";
            this.buttonDuplicateWords.UseVisualStyleBackColor = true;
            this.buttonDuplicateWords.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAllWords
            // 
            this.textBoxAllWords.Location = new System.Drawing.Point(116, 121);
            this.textBoxAllWords.Multiline = true;
            this.textBoxAllWords.Name = "textBoxAllWords";
            this.textBoxAllWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAllWords.Size = new System.Drawing.Size(168, 133);
            this.textBoxAllWords.TabIndex = 6;
            // 
            // textBoxDistinctWords
            // 
            this.textBoxDistinctWords.Location = new System.Drawing.Point(437, 121);
            this.textBoxDistinctWords.Multiline = true;
            this.textBoxDistinctWords.Name = "textBoxDistinctWords";
            this.textBoxDistinctWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDistinctWords.Size = new System.Drawing.Size(168, 133);
            this.textBoxDistinctWords.TabIndex = 7;
            this.textBoxDistinctWords.TextChanged += new System.EventHandler(this.textBoxDistinctWords_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 318);
            this.Controls.Add(this.textBoxDistinctWords);
            this.Controls.Add(this.textBoxAllWords);
            this.Controls.Add(this.buttonDuplicateWords);
            this.Controls.Add(this.buttonAllWord);
            this.Controls.Add(this.textBoxInputSentence);
            this.Controls.Add(this.labelInstruction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.TextBox textBoxInputSentence;
        private System.Windows.Forms.Button buttonAllWord;
        private System.Windows.Forms.Button buttonDuplicateWords;
        private System.Windows.Forms.TextBox textBoxAllWords;
        private System.Windows.Forms.TextBox textBoxDistinctWords;
    }
}

