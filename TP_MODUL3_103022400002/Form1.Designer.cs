namespace TP_MODUL3_103022400002
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
            lblOutput = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnPlus = new Button();
            btn0 = new Button();
            btnMin = new Button();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 20F);
            lblOutput.Location = new Point(292, 25);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 54);
            lblOutput.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 10F);
            btn1.Location = new Point(251, 128);
            btn1.Name = "btn1";
            btn1.Size = new Size(57, 55);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 10F);
            btn2.Location = new Point(314, 128);
            btn2.Name = "btn2";
            btn2.Size = new Size(57, 55);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 10F);
            btn3.Location = new Point(377, 128);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 55);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 10F);
            btn4.Location = new Point(251, 189);
            btn4.Name = "btn4";
            btn4.Size = new Size(57, 57);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 10F);
            btn5.Location = new Point(314, 189);
            btn5.Name = "btn5";
            btn5.Size = new Size(57, 57);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 10F);
            btn6.Location = new Point(377, 189);
            btn6.Name = "btn6";
            btn6.Size = new Size(57, 57);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 10F);
            btn7.Location = new Point(251, 252);
            btn7.Name = "btn7";
            btn7.Size = new Size(57, 57);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 10F);
            btn8.Location = new Point(314, 252);
            btn8.Name = "btn8";
            btn8.Size = new Size(57, 57);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 10F);
            btn9.Location = new Point(377, 252);
            btn9.Name = "btn9";
            btn9.Size = new Size(57, 57);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 10F);
            btnPlus.Location = new Point(251, 315);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(57, 57);
            btnPlus.TabIndex = 10;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += button3_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 10F);
            btn0.Location = new Point(314, 315);
            btn0.Name = "btn0";
            btn0.Size = new Size(57, 57);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnMin
            // 
            btnMin.Font = new Font("Segoe UI", 10F);
            btnMin.Location = new Point(377, 315);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(57, 57);
            btnMin.TabIndex = 12;
            btnMin.Text = "=";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMin);
            Controls.Add(btn0);
            Controls.Add(btnPlus);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnPlus;
        private Button btn0;
        private Button btnMin;
        int angka1 = 0;
        int angka2 = 0;
        string operasi = "";
    }
}
