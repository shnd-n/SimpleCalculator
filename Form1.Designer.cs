namespace SimpleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            oper = new TextBox();
            result = new TextBox();
            numSeven = new Button();
            numEight = new Button();
            numNine = new Button();
            numFour = new Button();
            numFive = new Button();
            numSix = new Button();
            numOne = new Button();
            numTwo = new Button();
            numThree = new Button();
            equl = new Button();
            plus = new Button();
            numZero = new Button();
            operMultiply = new Button();
            operMinus = new Button();
            operDivide = new Button();
            btnDelete = new Button();
            btnC = new Button();
            btnCe = new Button();
            btnPM = new Button();
            btnDot = new Button();
            operLog = new ListBox();
            deleteLog = new Button();
            sqr = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(94, 9);
            label1.Name = "label1";
            label1.Size = new Size(577, 86);
            label1.TabIndex = 0;
            label1.Text = "Simple_Calculator";
            // 
            // oper
            // 
            oper.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            oper.Location = new Point(94, 112);
            oper.Name = "oper";
            oper.Size = new Size(474, 39);
            oper.TabIndex = 1;
            // 
            // result
            // 
            result.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            result.Location = new Point(94, 167);
            result.Name = "result";
            result.Size = new Size(474, 39);
            result.TabIndex = 2;
            // 
            // numSeven
            // 
            numSeven.BackColor = Color.Transparent;
            numSeven.BackgroundImage = (Image)resources.GetObject("numSeven.BackgroundImage");
            numSeven.BackgroundImageLayout = ImageLayout.Stretch;
            numSeven.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numSeven.ForeColor = Color.Blue;
            numSeven.Location = new Point(94, 287);
            numSeven.Name = "numSeven";
            numSeven.Size = new Size(90, 41);
            numSeven.TabIndex = 3;
            numSeven.Text = "7";
            numSeven.UseVisualStyleBackColor = false;
            numSeven.Click += numBtn_Click;
            // 
            // numEight
            // 
            numEight.BackColor = Color.Transparent;
            numEight.BackgroundImage = (Image)resources.GetObject("numEight.BackgroundImage");
            numEight.BackgroundImageLayout = ImageLayout.Stretch;
            numEight.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numEight.ForeColor = Color.Blue;
            numEight.Location = new Point(201, 287);
            numEight.Name = "numEight";
            numEight.Size = new Size(90, 41);
            numEight.TabIndex = 4;
            numEight.Text = "8";
            numEight.UseVisualStyleBackColor = false;
            numEight.Click += numBtn_Click;
            // 
            // numNine
            // 
            numNine.BackColor = Color.Transparent;
            numNine.BackgroundImage = (Image)resources.GetObject("numNine.BackgroundImage");
            numNine.BackgroundImageLayout = ImageLayout.Stretch;
            numNine.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numNine.ForeColor = Color.Blue;
            numNine.Location = new Point(309, 287);
            numNine.Name = "numNine";
            numNine.Size = new Size(90, 41);
            numNine.TabIndex = 5;
            numNine.Text = "9";
            numNine.UseVisualStyleBackColor = false;
            numNine.Click += numBtn_Click;
            // 
            // numFour
            // 
            numFour.BackColor = Color.Transparent;
            numFour.BackgroundImage = (Image)resources.GetObject("numFour.BackgroundImage");
            numFour.BackgroundImageLayout = ImageLayout.Stretch;
            numFour.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numFour.ForeColor = Color.Blue;
            numFour.Location = new Point(94, 351);
            numFour.Name = "numFour";
            numFour.Size = new Size(90, 41);
            numFour.TabIndex = 6;
            numFour.Text = "4";
            numFour.UseVisualStyleBackColor = false;
            numFour.Click += numBtn_Click;
            // 
            // numFive
            // 
            numFive.BackColor = Color.Transparent;
            numFive.BackgroundImage = (Image)resources.GetObject("numFive.BackgroundImage");
            numFive.BackgroundImageLayout = ImageLayout.Stretch;
            numFive.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numFive.ForeColor = Color.Blue;
            numFive.Location = new Point(201, 351);
            numFive.Name = "numFive";
            numFive.Size = new Size(90, 41);
            numFive.TabIndex = 7;
            numFive.Text = "5";
            numFive.UseVisualStyleBackColor = false;
            numFive.Click += numBtn_Click;
            // 
            // numSix
            // 
            numSix.BackColor = Color.Transparent;
            numSix.BackgroundImage = (Image)resources.GetObject("numSix.BackgroundImage");
            numSix.BackgroundImageLayout = ImageLayout.Stretch;
            numSix.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numSix.ForeColor = Color.Blue;
            numSix.Location = new Point(309, 351);
            numSix.Name = "numSix";
            numSix.Size = new Size(90, 41);
            numSix.TabIndex = 8;
            numSix.Text = "6";
            numSix.UseVisualStyleBackColor = false;
            numSix.Click += numBtn_Click;
            // 
            // numOne
            // 
            numOne.BackColor = Color.Transparent;
            numOne.BackgroundImage = (Image)resources.GetObject("numOne.BackgroundImage");
            numOne.BackgroundImageLayout = ImageLayout.Stretch;
            numOne.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numOne.ForeColor = Color.Blue;
            numOne.Location = new Point(94, 411);
            numOne.Name = "numOne";
            numOne.Size = new Size(90, 41);
            numOne.TabIndex = 9;
            numOne.Text = "1";
            numOne.UseVisualStyleBackColor = false;
            numOne.Click += numBtn_Click;
            // 
            // numTwo
            // 
            numTwo.BackColor = Color.Transparent;
            numTwo.BackgroundImage = (Image)resources.GetObject("numTwo.BackgroundImage");
            numTwo.BackgroundImageLayout = ImageLayout.Stretch;
            numTwo.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numTwo.ForeColor = Color.Blue;
            numTwo.Location = new Point(201, 411);
            numTwo.Name = "numTwo";
            numTwo.Size = new Size(90, 41);
            numTwo.TabIndex = 10;
            numTwo.Text = "2";
            numTwo.UseVisualStyleBackColor = false;
            numTwo.Click += numBtn_Click;
            // 
            // numThree
            // 
            numThree.BackColor = Color.Transparent;
            numThree.BackgroundImage = (Image)resources.GetObject("numThree.BackgroundImage");
            numThree.BackgroundImageLayout = ImageLayout.Stretch;
            numThree.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numThree.ForeColor = Color.Blue;
            numThree.Location = new Point(309, 411);
            numThree.Name = "numThree";
            numThree.Size = new Size(90, 41);
            numThree.TabIndex = 11;
            numThree.Text = "3";
            numThree.UseVisualStyleBackColor = false;
            numThree.Click += numBtn_Click;
            // 
            // equl
            // 
            equl.BackColor = Color.Transparent;
            equl.FlatStyle = FlatStyle.System;
            equl.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            equl.Location = new Point(430, 469);
            equl.Name = "equl";
            equl.Size = new Size(90, 41);
            equl.TabIndex = 13;
            equl.Text = "=";
            equl.UseVisualStyleBackColor = false;
            equl.Click += equl_Click;
            // 
            // plus
            // 
            plus.BackColor = Color.Transparent;
            plus.FlatStyle = FlatStyle.System;
            plus.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            plus.ForeColor = Color.FromArgb(255, 128, 128);
            plus.Location = new Point(430, 411);
            plus.Name = "plus";
            plus.Size = new Size(90, 41);
            plus.TabIndex = 14;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += operBtn_Click;
            // 
            // numZero
            // 
            numZero.BackColor = Color.Transparent;
            numZero.BackgroundImage = (Image)resources.GetObject("numZero.BackgroundImage");
            numZero.BackgroundImageLayout = ImageLayout.Stretch;
            numZero.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numZero.ForeColor = Color.Blue;
            numZero.Location = new Point(201, 469);
            numZero.Name = "numZero";
            numZero.Size = new Size(90, 41);
            numZero.TabIndex = 15;
            numZero.Text = "0";
            numZero.UseVisualStyleBackColor = false;
            numZero.Click += numBtn_Click;
            // 
            // operMultiply
            // 
            operMultiply.BackColor = Color.Transparent;
            operMultiply.FlatStyle = FlatStyle.System;
            operMultiply.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            operMultiply.ForeColor = Color.FromArgb(255, 128, 128);
            operMultiply.Location = new Point(430, 287);
            operMultiply.Name = "operMultiply";
            operMultiply.Size = new Size(90, 41);
            operMultiply.TabIndex = 16;
            operMultiply.Text = "X";
            operMultiply.UseVisualStyleBackColor = false;
            operMultiply.Click += operBtn_Click;
            // 
            // operMinus
            // 
            operMinus.BackColor = Color.Transparent;
            operMinus.FlatStyle = FlatStyle.System;
            operMinus.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            operMinus.ForeColor = Color.FromArgb(255, 128, 128);
            operMinus.Location = new Point(430, 351);
            operMinus.Name = "operMinus";
            operMinus.Size = new Size(90, 41);
            operMinus.TabIndex = 17;
            operMinus.Text = "-";
            operMinus.UseVisualStyleBackColor = false;
            operMinus.Click += operBtn_Click;
            // 
            // operDivide
            // 
            operDivide.BackColor = Color.Transparent;
            operDivide.FlatStyle = FlatStyle.System;
            operDivide.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            operDivide.ForeColor = Color.FromArgb(255, 128, 128);
            operDivide.Location = new Point(430, 225);
            operDivide.Name = "operDivide";
            operDivide.Size = new Size(90, 41);
            operDivide.TabIndex = 18;
            operDivide.Text = "÷";
            operDivide.UseVisualStyleBackColor = false;
            operDivide.Click += operBtn_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            btnDelete.Location = new Point(309, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 41);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "del";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Transparent;
            btnC.FlatStyle = FlatStyle.System;
            btnC.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            btnC.Location = new Point(201, 225);
            btnC.Name = "btnC";
            btnC.Size = new Size(90, 41);
            btnC.TabIndex = 20;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnCe
            // 
            btnCe.BackColor = Color.Transparent;
            btnCe.BackgroundImageLayout = ImageLayout.Stretch;
            btnCe.FlatStyle = FlatStyle.System;
            btnCe.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            btnCe.ForeColor = SystemColors.ControlText;
            btnCe.Location = new Point(94, 225);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(90, 41);
            btnCe.TabIndex = 21;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = false;
            btnCe.Click += btnCe_Click;
            // 
            // btnPM
            // 
            btnPM.BackColor = Color.Transparent;
            btnPM.FlatStyle = FlatStyle.System;
            btnPM.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            btnPM.Location = new Point(94, 469);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(90, 41);
            btnPM.TabIndex = 22;
            btnPM.Text = "+/-";
            btnPM.UseVisualStyleBackColor = false;
            btnPM.Click += btnPM_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.Transparent;
            btnDot.FlatStyle = FlatStyle.System;
            btnDot.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            btnDot.Location = new Point(309, 469);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(90, 41);
            btnDot.TabIndex = 23;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // operLog
            // 
            operLog.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            operLog.FormattingEnabled = true;
            operLog.Location = new Point(551, 225);
            operLog.Name = "operLog";
            operLog.Size = new Size(207, 130);
            operLog.TabIndex = 24;
            // 
            // deleteLog
            // 
            deleteLog.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            deleteLog.ForeColor = Color.Red;
            deleteLog.Location = new Point(683, 369);
            deleteLog.Name = "deleteLog";
            deleteLog.Size = new Size(75, 23);
            deleteLog.TabIndex = 25;
            deleteLog.Text = "삭제";
            deleteLog.UseVisualStyleBackColor = true;
            deleteLog.Click += deleteLog_Click;
            // 
            // sqr
            // 
            sqr.BackColor = Color.Transparent;
            sqr.FlatStyle = FlatStyle.System;
            sqr.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            sqr.Location = new Point(12, 287);
            sqr.Name = "sqr";
            sqr.Size = new Size(76, 41);
            sqr.TabIndex = 26;
            sqr.Text = "x^2";
            sqr.UseVisualStyleBackColor = false;
            sqr.Click += sqr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(770, 638);
            Controls.Add(sqr);
            Controls.Add(deleteLog);
            Controls.Add(operLog);
            Controls.Add(btnDot);
            Controls.Add(btnPM);
            Controls.Add(btnCe);
            Controls.Add(btnC);
            Controls.Add(btnDelete);
            Controls.Add(operDivide);
            Controls.Add(operMinus);
            Controls.Add(operMultiply);
            Controls.Add(numZero);
            Controls.Add(plus);
            Controls.Add(equl);
            Controls.Add(numThree);
            Controls.Add(numTwo);
            Controls.Add(numOne);
            Controls.Add(numSix);
            Controls.Add(numFive);
            Controls.Add(numFour);
            Controls.Add(numNine);
            Controls.Add(numEight);
            Controls.Add(numSeven);
            Controls.Add(result);
            Controls.Add(oper);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox oper;
        private TextBox result;
        private Button numSeven;
        private Button numEight;
        private Button numNine;
        private Button numFour;
        private Button numFive;
        private Button numSix;
        private Button numOne;
        private Button numTwo;
        private Button numThree;
        private Button button10;
        private Button equl;
        private Button plus;
        private Button numZero;
        private Button operMultiply;
        private Button operMinus;
        private Button operDivide;
        private Button btnDelete;
        private Button btnC;
        private Button btnCe;
        private Button btnPM;
        private Button btnDot;
        private ListBox operLog;
        private Button deleteLog;
        private Button sqr;
    }
}
