namespace CalculatorDemo
{
    partial class frmCalculator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.pnlNumPad = new System.Windows.Forms.Panel();
            this.btnBsp = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlNumPad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(13, 13);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDisplay.Size = new System.Drawing.Size(370, 32);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlNumPad
            // 
            this.pnlNumPad.Controls.Add(this.btnBsp);
            this.pnlNumPad.Controls.Add(this.btn3);
            this.pnlNumPad.Controls.Add(this.button9);
            this.pnlNumPad.Controls.Add(this.btn9);
            this.pnlNumPad.Controls.Add(this.btnDot);
            this.pnlNumPad.Controls.Add(this.btn2);
            this.pnlNumPad.Controls.Add(this.btn5);
            this.pnlNumPad.Controls.Add(this.btn8);
            this.pnlNumPad.Controls.Add(this.btn7);
            this.pnlNumPad.Controls.Add(this.btn4);
            this.pnlNumPad.Controls.Add(this.btn0);
            this.pnlNumPad.Controls.Add(this.btn1);
            this.pnlNumPad.Location = new System.Drawing.Point(25, 102);
            this.pnlNumPad.Name = "pnlNumPad";
            this.pnlNumPad.Size = new System.Drawing.Size(151, 137);
            this.pnlNumPad.TabIndex = 1;
            // 
            // btnBsp
            // 
            this.btnBsp.Location = new System.Drawing.Point(102, 102);
            this.btnBsp.Name = "btnBsp";
            this.btnBsp.Size = new System.Drawing.Size(42, 27);
            this.btnBsp.TabIndex = 11;
            this.btnBsp.Text = "<-";
            this.btnBsp.UseVisualStyleBackColor = true;
            this.btnBsp.Click += new System.EventHandler(this.btnBsp_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(102, 69);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 27);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(102, 36);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 27);
            this.button9.TabIndex = 9;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(102, 3);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(42, 27);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(6, 102);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(42, 27);
            this.btnDot.TabIndex = 7;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(54, 69);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 27);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(54, 36);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 27);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(54, 3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(42, 27);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(42, 27);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 36);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(42, 27);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(54, 102);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(42, 27);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 69);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 27);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(25, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 38);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 284);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNumPad);
            this.Controls.Add(this.txtDisplay);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.pnlNumPad.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Panel pnlNumPad;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnBsp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

