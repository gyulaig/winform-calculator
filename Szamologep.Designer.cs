namespace szamologep
{
    partial class MainForm
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
            this.btnDigit0 = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDigit1 = new System.Windows.Forms.Button();
            this.btnDigit2 = new System.Windows.Forms.Button();
            this.btnDigit3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDigit4 = new System.Windows.Forms.Button();
            this.btnDigit5 = new System.Windows.Forms.Button();
            this.btnDigit6 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDigit7 = new System.Windows.Forms.Button();
            this.btnDigit8 = new System.Windows.Forms.Button();
            this.btnDigit9 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.ResultScreen = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDigit0
            // 
            this.btnDigit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDigit0.Location = new System.Drawing.Point(93, 290);
            this.btnDigit0.Name = "btnDigit0";
            this.btnDigit0.Size = new System.Drawing.Size(75, 55);
            this.btnDigit0.TabIndex = 1;
            this.btnDigit0.Text = "0";
            this.btnDigit0.UseVisualStyleBackColor = true;
            this.btnDigit0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.Enabled = false;
            this.btnNegate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNegate.Location = new System.Drawing.Point(12, 290);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(75, 55);
            this.btnNegate.TabIndex = 2;
            this.btnNegate.Text = "⁺∕₋";
            this.btnNegate.UseVisualStyleBackColor = true;
            // 
            // btnDecimal
            // 
            this.btnDecimal.Enabled = false;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDecimal.Location = new System.Drawing.Point(175, 290);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 55);
            this.btnDecimal.TabIndex = 3;
            this.btnDecimal.Text = ",";
            this.btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEquals.Location = new System.Drawing.Point(256, 290);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 55);
            this.btnEquals.TabIndex = 4;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // btnDigit1
            // 
            this.btnDigit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDigit1.Location = new System.Drawing.Point(12, 229);
            this.btnDigit1.Name = "btnDigit1";
            this.btnDigit1.Size = new System.Drawing.Size(75, 55);
            this.btnDigit1.TabIndex = 5;
            this.btnDigit1.Text = "1";
            this.btnDigit1.UseVisualStyleBackColor = true;
            this.btnDigit1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnDigit2
            // 
            this.btnDigit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDigit2.Location = new System.Drawing.Point(93, 229);
            this.btnDigit2.Name = "btnDigit2";
            this.btnDigit2.Size = new System.Drawing.Size(75, 55);
            this.btnDigit2.TabIndex = 6;
            this.btnDigit2.Text = "2";
            this.btnDigit2.UseVisualStyleBackColor = true;
            this.btnDigit2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnDigit3
            // 
            this.btnDigit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDigit3.Location = new System.Drawing.Point(175, 229);
            this.btnDigit3.Name = "btnDigit3";
            this.btnDigit3.Size = new System.Drawing.Size(75, 55);
            this.btnDigit3.TabIndex = 7;
            this.btnDigit3.Text = "3";
            this.btnDigit3.UseVisualStyleBackColor = true;
            this.btnDigit3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAdd.Location = new System.Drawing.Point(256, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 55);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btnDigit4
            // 
            this.btnDigit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDigit4.Location = new System.Drawing.Point(12, 168);
            this.btnDigit4.Name = "btnDigit4";
            this.btnDigit4.Size = new System.Drawing.Size(75, 55);
            this.btnDigit4.TabIndex = 9;
            this.btnDigit4.Text = "4";
            this.btnDigit4.UseVisualStyleBackColor = true;
            this.btnDigit4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnDigit5
            // 
            this.btnDigit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDigit5.Location = new System.Drawing.Point(93, 168);
            this.btnDigit5.Name = "btnDigit5";
            this.btnDigit5.Size = new System.Drawing.Size(75, 55);
            this.btnDigit5.TabIndex = 10;
            this.btnDigit5.Text = "5";
            this.btnDigit5.UseVisualStyleBackColor = true;
            this.btnDigit5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnDigit6
            // 
            this.btnDigit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDigit6.Location = new System.Drawing.Point(174, 168);
            this.btnDigit6.Name = "btnDigit6";
            this.btnDigit6.Size = new System.Drawing.Size(75, 55);
            this.btnDigit6.TabIndex = 11;
            this.btnDigit6.Text = "6";
            this.btnDigit6.UseVisualStyleBackColor = true;
            this.btnDigit6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSubtract.Location = new System.Drawing.Point(255, 168);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 55);
            this.btnSubtract.TabIndex = 12;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btnDigit7
            // 
            this.btnDigit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDigit7.Location = new System.Drawing.Point(12, 107);
            this.btnDigit7.Name = "btnDigit7";
            this.btnDigit7.Size = new System.Drawing.Size(75, 55);
            this.btnDigit7.TabIndex = 13;
            this.btnDigit7.Text = "7";
            this.btnDigit7.UseVisualStyleBackColor = true;
            this.btnDigit7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnDigit8
            // 
            this.btnDigit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDigit8.Location = new System.Drawing.Point(93, 107);
            this.btnDigit8.Name = "btnDigit8";
            this.btnDigit8.Size = new System.Drawing.Size(75, 55);
            this.btnDigit8.TabIndex = 14;
            this.btnDigit8.Text = "8";
            this.btnDigit8.UseVisualStyleBackColor = true;
            this.btnDigit8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnDigit9
            // 
            this.btnDigit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDigit9.Location = new System.Drawing.Point(175, 107);
            this.btnDigit9.Name = "btnDigit9";
            this.btnDigit9.Size = new System.Drawing.Size(75, 55);
            this.btnDigit9.TabIndex = 15;
            this.btnDigit9.Text = "9";
            this.btnDigit9.UseVisualStyleBackColor = true;
            this.btnDigit9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMultiply.Location = new System.Drawing.Point(255, 107);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 55);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClearEntry.Location = new System.Drawing.Point(13, 46);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(75, 55);
            this.btnClearEntry.TabIndex = 17;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClear.Location = new System.Drawing.Point(95, 46);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 55);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBackspace.Location = new System.Drawing.Point(175, 46);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(75, 55);
            this.btnBackspace.TabIndex = 19;
            this.btnBackspace.Text = "⌫ ";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // ResultScreen
            // 
            this.ResultScreen.Location = new System.Drawing.Point(13, 12);
            this.ResultScreen.Name = "ResultScreen";
            this.ResultScreen.Size = new System.Drawing.Size(317, 22);
            this.ResultScreen.TabIndex = 20;
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDivide.Location = new System.Drawing.Point(255, 46);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 55);
            this.btnDivide.TabIndex = 21;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(345, 357);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.ResultScreen);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDigit9);
            this.Controls.Add(this.btnDigit8);
            this.Controls.Add(this.btnDigit7);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnDigit6);
            this.Controls.Add(this.btnDigit5);
            this.Controls.Add(this.btnDigit4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDigit3);
            this.Controls.Add(this.btnDigit2);
            this.Controls.Add(this.btnDigit1);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnNegate);
            this.Controls.Add(this.btnDigit0);
            this.MaximumSize = new System.Drawing.Size(363, 404);
            this.MinimumSize = new System.Drawing.Size(363, 404);
            this.Name = "MainForm";
            this.Text = "Szamologep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDigit0;
        private System.Windows.Forms.Button btnNegate;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDigit1;
        private System.Windows.Forms.Button btnDigit2;
        private System.Windows.Forms.Button btnDigit3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDigit4;
        private System.Windows.Forms.Button btnDigit5;
        private System.Windows.Forms.Button btnDigit6;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnDigit7;
        private System.Windows.Forms.Button btnDigit8;
        private System.Windows.Forms.Button btnDigit9;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.TextBox ResultScreen;
        private System.Windows.Forms.Button btnDivide;
    }
}

