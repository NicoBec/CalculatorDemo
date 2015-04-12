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
            this.btnClearDisplay = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMemClear = new System.Windows.Forms.Button();
            this.btnMemRecall = new System.Windows.Forms.Button();
            this.btnMemSub = new System.Windows.Forms.Button();
            this.btmMemAdd = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNumPad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(25, 13);
            this.txtDisplay.MaxLength = 20;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDisplay.Size = new System.Drawing.Size(263, 32);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisplay_KeyPress);
            this.txtDisplay.Leave += new System.EventHandler(this.txtDisplay_Leave);
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
            this.panel1.Controls.Add(this.btnClearDisplay);
            this.panel1.Controls.Add(this.btnClearAll);
            this.panel1.Location = new System.Drawing.Point(25, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 38);
            this.panel1.TabIndex = 2;
            // 
            // btnClearDisplay
            // 
            this.btnClearDisplay.Location = new System.Drawing.Point(54, 8);
            this.btnClearDisplay.Name = "btnClearDisplay";
            this.btnClearDisplay.Size = new System.Drawing.Size(42, 27);
            this.btnClearDisplay.TabIndex = 5;
            this.btnClearDisplay.Text = "C";
            this.btnClearDisplay.UseVisualStyleBackColor = true;
            this.btnClearDisplay.Click += new System.EventHandler(this.btnClearDisplay_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(6, 8);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(42, 27);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "CE";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMemClear);
            this.panel2.Controls.Add(this.btnMemRecall);
            this.panel2.Controls.Add(this.btnMemSub);
            this.panel2.Controls.Add(this.btmMemAdd);
            this.panel2.Controls.Add(this.btnEqual);
            this.panel2.Controls.Add(this.btnMulti);
            this.panel2.Controls.Add(this.btnDiv);
            this.panel2.Controls.Add(this.btnSub);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(183, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 178);
            this.panel2.TabIndex = 3;
            // 
            // btnMemClear
            // 
            this.btnMemClear.Location = new System.Drawing.Point(51, 110);
            this.btnMemClear.Name = "btnMemClear";
            this.btnMemClear.Size = new System.Drawing.Size(42, 27);
            this.btnMemClear.TabIndex = 14;
            this.btnMemClear.Text = "MC";
            this.btnMemClear.UseVisualStyleBackColor = true;
            this.btnMemClear.Click += new System.EventHandler(this.btnMemClear_Click);
            // 
            // btnMemRecall
            // 
            this.btnMemRecall.Location = new System.Drawing.Point(51, 77);
            this.btnMemRecall.Name = "btnMemRecall";
            this.btnMemRecall.Size = new System.Drawing.Size(42, 27);
            this.btnMemRecall.TabIndex = 13;
            this.btnMemRecall.Text = "MR";
            this.btnMemRecall.UseVisualStyleBackColor = true;
            this.btnMemRecall.Click += new System.EventHandler(this.btnMemRecall_Click);
            // 
            // btnMemSub
            // 
            this.btnMemSub.Location = new System.Drawing.Point(51, 44);
            this.btnMemSub.Name = "btnMemSub";
            this.btnMemSub.Size = new System.Drawing.Size(42, 27);
            this.btnMemSub.TabIndex = 12;
            this.btnMemSub.Text = "M-";
            this.btnMemSub.UseVisualStyleBackColor = true;
            this.btnMemSub.Click += new System.EventHandler(this.btnMemSub_Click);
            // 
            // btmMemAdd
            // 
            this.btmMemAdd.Location = new System.Drawing.Point(51, 8);
            this.btmMemAdd.Name = "btmMemAdd";
            this.btmMemAdd.Size = new System.Drawing.Size(42, 27);
            this.btmMemAdd.TabIndex = 11;
            this.btmMemAdd.Text = "M+";
            this.btmMemAdd.UseVisualStyleBackColor = true;
            this.btmMemAdd.Click += new System.EventHandler(this.btmMemAdd_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(3, 143);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(42, 27);
            this.btnEqual.TabIndex = 10;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(3, 110);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(42, 27);
            this.btnMulti.TabIndex = 9;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(3, 77);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(42, 27);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(3, 44);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(42, 27);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 27);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Try The Numpad";
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNumPad);
            this.Controls.Add(this.txtDisplay);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.pnlNumPad.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnClearDisplay;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnMemClear;
        private System.Windows.Forms.Button btnMemRecall;
        private System.Windows.Forms.Button btnMemSub;
        private System.Windows.Forms.Button btmMemAdd;
        private System.Windows.Forms.Label label1;
    }
}

