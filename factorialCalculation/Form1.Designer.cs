namespace factorialCalculation
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblEnterInteger = new System.Windows.Forms.Label();
            this.lblResultPrompt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultNumeric1 = new System.Windows.Forms.Label();
            this.lblRunTimePrompt = new System.Windows.Forms.Label();
            this.lblIterationsPrompt = new System.Windows.Forms.Label();
            this.lblAlgo1 = new System.Windows.Forms.Label();
            this.lblAlgo2 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResultNumeric2 = new System.Windows.Forms.Label();
            this.lblRunTimeResultAlgo1 = new System.Windows.Forms.Label();
            this.lblIterationsResultAlgo1 = new System.Windows.Forms.Label();
            this.lblIterationsResultAlgo2 = new System.Windows.Forms.Label();
            this.lblRunTimeResultAlgo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Digital-7 Italic", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(65, 150);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(517, 61);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "0";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput.Click += new System.EventHandler(this.txtInput_Click);
            // 
            // lblEnterInteger
            // 
            this.lblEnterInteger.AutoSize = true;
            this.lblEnterInteger.Font = new System.Drawing.Font("Digital-7 Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterInteger.ForeColor = System.Drawing.Color.IndianRed;
            this.lblEnterInteger.Location = new System.Drawing.Point(45, 26);
            this.lblEnterInteger.Name = "lblEnterInteger";
            this.lblEnterInteger.Size = new System.Drawing.Size(769, 62);
            this.lblEnterInteger.TabIndex = 1;
            this.lblEnterInteger.Text = "Enter an Integer for Factorial";
            // 
            // lblResultPrompt
            // 
            this.lblResultPrompt.AutoSize = true;
            this.lblResultPrompt.Font = new System.Drawing.Font("Digital-7 Italic", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultPrompt.Location = new System.Drawing.Point(53, 640);
            this.lblResultPrompt.Name = "lblResultPrompt";
            this.lblResultPrompt.Size = new System.Drawing.Size(181, 55);
            this.lblResultPrompt.TabIndex = 2;
            this.lblResultPrompt.Text = "Result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 61);
            this.label1.TabIndex = 3;
            // 
            // lblResultNumeric1
            // 
            this.lblResultNumeric1.AutoSize = true;
            this.lblResultNumeric1.Font = new System.Drawing.Font("Digital-7 Italic", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultNumeric1.Location = new System.Drawing.Point(365, 640);
            this.lblResultNumeric1.MaximumSize = new System.Drawing.Size(293, 0);
            this.lblResultNumeric1.Name = "lblResultNumeric1";
            this.lblResultNumeric1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResultNumeric1.Size = new System.Drawing.Size(66, 55);
            this.lblResultNumeric1.TabIndex = 4;
            this.lblResultNumeric1.Text = "--";
            this.lblResultNumeric1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRunTimePrompt
            // 
            this.lblRunTimePrompt.AutoSize = true;
            this.lblRunTimePrompt.Font = new System.Drawing.Font("Digital-7 Italic", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunTimePrompt.Location = new System.Drawing.Point(45, 394);
            this.lblRunTimePrompt.Name = "lblRunTimePrompt";
            this.lblRunTimePrompt.Size = new System.Drawing.Size(181, 55);
            this.lblRunTimePrompt.TabIndex = 5;
            this.lblRunTimePrompt.Text = "RunTime";
            // 
            // lblIterationsPrompt
            // 
            this.lblIterationsPrompt.AutoSize = true;
            this.lblIterationsPrompt.Font = new System.Drawing.Font("Digital-7 Italic", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIterationsPrompt.Location = new System.Drawing.Point(45, 517);
            this.lblIterationsPrompt.Name = "lblIterationsPrompt";
            this.lblIterationsPrompt.Size = new System.Drawing.Size(240, 55);
            this.lblIterationsPrompt.TabIndex = 6;
            this.lblIterationsPrompt.Text = "Iterations";
            // 
            // lblAlgo1
            // 
            this.lblAlgo1.AutoSize = true;
            this.lblAlgo1.Font = new System.Drawing.Font("Digital-7 Italic", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgo1.Location = new System.Drawing.Point(363, 297);
            this.lblAlgo1.Name = "lblAlgo1";
            this.lblAlgo1.Size = new System.Drawing.Size(133, 55);
            this.lblAlgo1.TabIndex = 7;
            this.lblAlgo1.Text = "Algo1";
            // 
            // lblAlgo2
            // 
            this.lblAlgo2.AutoSize = true;
            this.lblAlgo2.Font = new System.Drawing.Font("Digital-7 Italic", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgo2.Location = new System.Drawing.Point(705, 297);
            this.lblAlgo2.Name = "lblAlgo2";
            this.lblAlgo2.Size = new System.Drawing.Size(149, 55);
            this.lblAlgo2.TabIndex = 8;
            this.lblAlgo2.Text = "Algo2";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.IndianRed;
            this.btnCheck.Font = new System.Drawing.Font("Digital-7 Italic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheck.Location = new System.Drawing.Point(610, 120);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(309, 99);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "CALCULATE FACTORIAL";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblResultNumeric2
            // 
            this.lblResultNumeric2.AutoSize = true;
            this.lblResultNumeric2.Font = new System.Drawing.Font("Digital-7 Italic", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultNumeric2.Location = new System.Drawing.Point(705, 640);
            this.lblResultNumeric2.MaximumSize = new System.Drawing.Size(293, 0);
            this.lblResultNumeric2.Name = "lblResultNumeric2";
            this.lblResultNumeric2.Size = new System.Drawing.Size(66, 55);
            this.lblResultNumeric2.TabIndex = 14;
            this.lblResultNumeric2.Text = "--";
            this.lblResultNumeric2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRunTimeResultAlgo1
            // 
            this.lblRunTimeResultAlgo1.AutoSize = true;
            this.lblRunTimeResultAlgo1.Font = new System.Drawing.Font("Digital-7 Italic", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunTimeResultAlgo1.Location = new System.Drawing.Point(365, 394);
            this.lblRunTimeResultAlgo1.MaximumSize = new System.Drawing.Size(293, 0);
            this.lblRunTimeResultAlgo1.Name = "lblRunTimeResultAlgo1";
            this.lblRunTimeResultAlgo1.Size = new System.Drawing.Size(49, 55);
            this.lblRunTimeResultAlgo1.TabIndex = 15;
            this.lblRunTimeResultAlgo1.Text = "0";
            this.lblRunTimeResultAlgo1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIterationsResultAlgo1
            // 
            this.lblIterationsResultAlgo1.AutoSize = true;
            this.lblIterationsResultAlgo1.Font = new System.Drawing.Font("Digital-7 Italic", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIterationsResultAlgo1.Location = new System.Drawing.Point(365, 517);
            this.lblIterationsResultAlgo1.MaximumSize = new System.Drawing.Size(293, 0);
            this.lblIterationsResultAlgo1.Name = "lblIterationsResultAlgo1";
            this.lblIterationsResultAlgo1.Size = new System.Drawing.Size(49, 55);
            this.lblIterationsResultAlgo1.TabIndex = 17;
            this.lblIterationsResultAlgo1.Text = "0";
            this.lblIterationsResultAlgo1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIterationsResultAlgo2
            // 
            this.lblIterationsResultAlgo2.AutoSize = true;
            this.lblIterationsResultAlgo2.Font = new System.Drawing.Font("Digital-7 Italic", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIterationsResultAlgo2.Location = new System.Drawing.Point(705, 517);
            this.lblIterationsResultAlgo2.MaximumSize = new System.Drawing.Size(293, 0);
            this.lblIterationsResultAlgo2.Name = "lblIterationsResultAlgo2";
            this.lblIterationsResultAlgo2.Size = new System.Drawing.Size(49, 55);
            this.lblIterationsResultAlgo2.TabIndex = 18;
            this.lblIterationsResultAlgo2.Text = "0";
            this.lblIterationsResultAlgo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRunTimeResultAlgo2
            // 
            this.lblRunTimeResultAlgo2.AutoSize = true;
            this.lblRunTimeResultAlgo2.Font = new System.Drawing.Font("Digital-7 Italic", 31.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunTimeResultAlgo2.Location = new System.Drawing.Point(705, 394);
            this.lblRunTimeResultAlgo2.MaximumSize = new System.Drawing.Size(293, 0);
            this.lblRunTimeResultAlgo2.Name = "lblRunTimeResultAlgo2";
            this.lblRunTimeResultAlgo2.Size = new System.Drawing.Size(49, 55);
            this.lblRunTimeResultAlgo2.TabIndex = 19;
            this.lblRunTimeResultAlgo2.Text = "0";
            this.lblRunTimeResultAlgo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1005, 937);
            this.Controls.Add(this.lblRunTimeResultAlgo2);
            this.Controls.Add(this.lblIterationsResultAlgo2);
            this.Controls.Add(this.lblIterationsResultAlgo1);
            this.Controls.Add(this.lblRunTimeResultAlgo1);
            this.Controls.Add(this.lblResultNumeric2);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblAlgo2);
            this.Controls.Add(this.lblAlgo1);
            this.Controls.Add(this.lblIterationsPrompt);
            this.Controls.Add(this.lblRunTimePrompt);
            this.Controls.Add(this.lblResultNumeric1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultPrompt);
            this.Controls.Add(this.lblEnterInteger);
            this.Controls.Add(this.txtInput);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Factorial using 2 Different Algorithms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblEnterInteger;
        private System.Windows.Forms.Label lblResultPrompt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultNumeric1;
        private System.Windows.Forms.Label lblRunTimePrompt;
        private System.Windows.Forms.Label lblIterationsPrompt;
        private System.Windows.Forms.Label lblAlgo1;
        private System.Windows.Forms.Label lblAlgo2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResultNumeric2;
        private System.Windows.Forms.Label lblRunTimeResultAlgo1;
        private System.Windows.Forms.Label lblIterationsResultAlgo1;
        private System.Windows.Forms.Label lblIterationsResultAlgo2;
        private System.Windows.Forms.Label lblRunTimeResultAlgo2;
    }
}

