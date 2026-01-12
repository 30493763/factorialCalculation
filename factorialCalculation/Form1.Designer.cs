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
            this.lblResultNumeric = new System.Windows.Forms.Label();
            this.lblRunTimePrompt = new System.Windows.Forms.Label();
            this.lblIterationsPrompt = new System.Windows.Forms.Label();
            this.lblAlgo1 = new System.Windows.Forms.Label();
            this.lblAlgo2 = new System.Windows.Forms.Label();
            this.txtRunTimeResultAlgo1 = new System.Windows.Forms.TextBox();
            this.txtRunTimeResultAlgo2 = new System.Windows.Forms.TextBox();
            this.txtIterationsResultAlgo1 = new System.Windows.Forms.TextBox();
            this.txtIterationsResultAlgo2 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(793, 26);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(184, 53);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "0";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput.Click += new System.EventHandler(this.txtInput_Click);
            // 
            // lblEnterInteger
            // 
            this.lblEnterInteger.AutoSize = true;
            this.lblEnterInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterInteger.Location = new System.Drawing.Point(46, 26);
            this.lblEnterInteger.Name = "lblEnterInteger";
            this.lblEnterInteger.Size = new System.Drawing.Size(698, 61);
            this.lblEnterInteger.TabIndex = 1;
            this.lblEnterInteger.Text = "Enter an Integer for Factorial";
            // 
            // lblResultPrompt
            // 
            this.lblResultPrompt.AutoSize = true;
            this.lblResultPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultPrompt.Location = new System.Drawing.Point(46, 109);
            this.lblResultPrompt.Name = "lblResultPrompt";
            this.lblResultPrompt.Size = new System.Drawing.Size(193, 61);
            this.lblResultPrompt.TabIndex = 2;
            this.lblResultPrompt.Text = "Result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 61);
            this.label1.TabIndex = 3;
            // 
            // lblResultNumeric
            // 
            this.lblResultNumeric.AutoSize = true;
            this.lblResultNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultNumeric.Location = new System.Drawing.Point(248, 109);
            this.lblResultNumeric.Name = "lblResultNumeric";
            this.lblResultNumeric.Size = new System.Drawing.Size(14, 16);
            this.lblResultNumeric.TabIndex = 4;
            this.lblResultNumeric.Text = "1";
            // 
            // lblRunTimePrompt
            // 
            this.lblRunTimePrompt.AutoSize = true;
            this.lblRunTimePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunTimePrompt.Location = new System.Drawing.Point(46, 382);
            this.lblRunTimePrompt.Name = "lblRunTimePrompt";
            this.lblRunTimePrompt.Size = new System.Drawing.Size(241, 61);
            this.lblRunTimePrompt.TabIndex = 5;
            this.lblRunTimePrompt.Text = "RunTime";
            // 
            // lblIterationsPrompt
            // 
            this.lblIterationsPrompt.AutoSize = true;
            this.lblIterationsPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIterationsPrompt.Location = new System.Drawing.Point(46, 495);
            this.lblIterationsPrompt.Name = "lblIterationsPrompt";
            this.lblIterationsPrompt.Size = new System.Drawing.Size(246, 61);
            this.lblIterationsPrompt.TabIndex = 6;
            this.lblIterationsPrompt.Text = "Iterations";
            // 
            // lblAlgo1
            // 
            this.lblAlgo1.AutoSize = true;
            this.lblAlgo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgo1.Location = new System.Drawing.Point(416, 266);
            this.lblAlgo1.Name = "lblAlgo1";
            this.lblAlgo1.Size = new System.Drawing.Size(162, 61);
            this.lblAlgo1.TabIndex = 7;
            this.lblAlgo1.Text = "Algo1";
            // 
            // lblAlgo2
            // 
            this.lblAlgo2.AutoSize = true;
            this.lblAlgo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgo2.Location = new System.Drawing.Point(763, 266);
            this.lblAlgo2.Name = "lblAlgo2";
            this.lblAlgo2.Size = new System.Drawing.Size(162, 61);
            this.lblAlgo2.TabIndex = 8;
            this.lblAlgo2.Text = "Algo2";
            // 
            // txtRunTimeResultAlgo1
            // 
            this.txtRunTimeResultAlgo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunTimeResultAlgo1.Location = new System.Drawing.Point(326, 382);
            this.txtRunTimeResultAlgo1.Name = "txtRunTimeResultAlgo1";
            this.txtRunTimeResultAlgo1.Size = new System.Drawing.Size(250, 53);
            this.txtRunTimeResultAlgo1.TabIndex = 9;
            // 
            // txtRunTimeResultAlgo2
            // 
            this.txtRunTimeResultAlgo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunTimeResultAlgo2.Location = new System.Drawing.Point(675, 382);
            this.txtRunTimeResultAlgo2.Name = "txtRunTimeResultAlgo2";
            this.txtRunTimeResultAlgo2.Size = new System.Drawing.Size(250, 53);
            this.txtRunTimeResultAlgo2.TabIndex = 10;
            // 
            // txtIterationsResultAlgo1
            // 
            this.txtIterationsResultAlgo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIterationsResultAlgo1.Location = new System.Drawing.Point(326, 495);
            this.txtIterationsResultAlgo1.Name = "txtIterationsResultAlgo1";
            this.txtIterationsResultAlgo1.Size = new System.Drawing.Size(250, 53);
            this.txtIterationsResultAlgo1.TabIndex = 11;
            this.txtIterationsResultAlgo1.TextChanged += new System.EventHandler(this.txtIterationsResultAlgo1_TextChanged);
            // 
            // txtIterationsResultAlgo2
            // 
            this.txtIterationsResultAlgo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIterationsResultAlgo2.Location = new System.Drawing.Point(675, 495);
            this.txtIterationsResultAlgo2.Name = "txtIterationsResultAlgo2";
            this.txtIterationsResultAlgo2.Size = new System.Drawing.Size(250, 53);
            this.txtIterationsResultAlgo2.TabIndex = 12;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(829, 118);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(148, 54);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtIterationsResultAlgo2);
            this.Controls.Add(this.txtIterationsResultAlgo1);
            this.Controls.Add(this.txtRunTimeResultAlgo2);
            this.Controls.Add(this.txtRunTimeResultAlgo1);
            this.Controls.Add(this.lblAlgo2);
            this.Controls.Add(this.lblAlgo1);
            this.Controls.Add(this.lblIterationsPrompt);
            this.Controls.Add(this.lblRunTimePrompt);
            this.Controls.Add(this.lblResultNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultPrompt);
            this.Controls.Add(this.lblEnterInteger);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblEnterInteger;
        private System.Windows.Forms.Label lblResultPrompt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultNumeric;
        private System.Windows.Forms.Label lblRunTimePrompt;
        private System.Windows.Forms.Label lblIterationsPrompt;
        private System.Windows.Forms.Label lblAlgo1;
        private System.Windows.Forms.Label lblAlgo2;
        private System.Windows.Forms.TextBox txtRunTimeResultAlgo1;
        private System.Windows.Forms.TextBox txtRunTimeResultAlgo2;
        private System.Windows.Forms.TextBox txtIterationsResultAlgo1;
        private System.Windows.Forms.TextBox txtIterationsResultAlgo2;
        private System.Windows.Forms.Button btnCheck;
    }
}

