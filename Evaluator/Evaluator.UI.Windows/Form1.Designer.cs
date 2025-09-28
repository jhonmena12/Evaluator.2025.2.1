namespace Evaluator.UI.Windows
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn8 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btn5 = new Button();
            btnMinus = new Button();
            btnResult = new Button();
            btnPow = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnCloseParethesis = new Button();
            btnMultiply = new Button();
            btnOpenParenthesis = new Button();
            btnPlus = new Button();
            btnDivide = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.OrangeRed;
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.Window;
            txtDisplay.Location = new Point(22, 13);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(486, 47);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(25, 82);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 51);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(25, 139);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 51);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(25, 196);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 51);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(99, 196);
            btn2.Name = "btn2";
            btn2.Size = new Size(68, 51);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn8
            // 
            btn8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(99, 82);
            btn8.Name = "btn8";
            btn8.Size = new Size(68, 51);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(173, 196);
            btn3.Name = "btn3";
            btn3.Size = new Size(68, 51);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(173, 139);
            btn6.Name = "btn6";
            btn6.Size = new Size(68, 51);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn9
            // 
            btn9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(173, 82);
            btn9.Name = "btn9";
            btn9.Size = new Size(68, 51);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnDot
            // 
            btnDot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(173, 253);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(68, 51);
            btnDot.TabIndex = 12;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(25, 253);
            btn0.Name = "btn0";
            btn0.Size = new Size(142, 51);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn5
            // 
            btn5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(99, 139);
            btn5.Name = "btn5";
            btn5.Size = new Size(68, 51);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btnMinus
            // 
            btnMinus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(323, 139);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(68, 51);
            btnMinus.TabIndex = 24;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnResult
            // 
            btnResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnResult.BackColor = Color.FromArgb(255, 128, 0);
            btnResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResult.Location = new Point(249, 253);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(262, 51);
            btnResult.TabIndex = 22;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnPow
            // 
            btnPow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPow.Location = new Point(397, 196);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(114, 51);
            btnPow.TabIndex = 21;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(397, 139);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 51);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(397, 82);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 51);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCloseParethesis
            // 
            btnCloseParethesis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCloseParethesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParethesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseParethesis.Location = new Point(323, 196);
            btnCloseParethesis.Name = "btnCloseParethesis";
            btnCloseParethesis.Size = new Size(68, 51);
            btnCloseParethesis.TabIndex = 18;
            btnCloseParethesis.Text = ")";
            btnCloseParethesis.UseVisualStyleBackColor = false;
            btnCloseParethesis.Click += btnCloseParethesis_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(323, 82);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(68, 51);
            btnMultiply.TabIndex = 17;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenParenthesis.Location = new Point(249, 196);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(68, 51);
            btnOpenParenthesis.TabIndex = 16;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnPlus
            // 
            btnPlus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(249, 139);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(68, 51);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDivide
            // 
            btnDivide.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(249, 82);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(68, 51);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(520, 360);
            Controls.Add(btnMinus);
            Controls.Add(btnResult);
            Controls.Add(btnPow);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnCloseParethesis);
            Controls.Add(btnMultiply);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnPlus);
            Controls.Add(btnDivide);
            Controls.Add(btn5);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn8);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Functions Evaluator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btn2;
        private Button btn8;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnDot;
        private Button btn0;
        private Button btn5;
        private Button btnMinus;
        private Button btnResult;
        private Button btnPow;
        private Button btnClear;
        private Button btnDelete;
        private Button btnCloseParethesis;
        private Button btnMultiply;
        private Button btnOpenParenthesis;
        private Button btnPlus;
        private Button btnDivide;
    }
}
