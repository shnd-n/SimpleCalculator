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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
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
            oper.Location = new Point(94, 125);
            oper.Name = "oper";
            oper.Size = new Size(474, 39);
            oper.TabIndex = 1;
            // 
            // result
            // 
            result.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            result.Location = new Point(94, 180);
            result.Name = "result";
            result.Size = new Size(474, 39);
            result.TabIndex = 2;
            // 
            // numSeven
            // 
            numSeven.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numSeven.Location = new Point(94, 268);
            numSeven.Name = "numSeven";
            numSeven.Size = new Size(90, 41);
            numSeven.TabIndex = 3;
            numSeven.Text = "7";
            numSeven.UseVisualStyleBackColor = true;
            numSeven.Click += numBtn_Click;
            // 
            // numEight
            // 
            numEight.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numEight.Location = new Point(201, 268);
            numEight.Name = "numEight";
            numEight.Size = new Size(90, 41);
            numEight.TabIndex = 4;
            numEight.Text = "8";
            numEight.UseVisualStyleBackColor = true;
            numEight.Click += numBtn_Click;
            // 
            // numNine
            // 
            numNine.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numNine.Location = new Point(309, 268);
            numNine.Name = "numNine";
            numNine.Size = new Size(90, 41);
            numNine.TabIndex = 5;
            numNine.Text = "9";
            numNine.UseVisualStyleBackColor = true;
            numNine.Click += numBtn_Click;
            // 
            // numFour
            // 
            numFour.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numFour.Location = new Point(94, 336);
            numFour.Name = "numFour";
            numFour.Size = new Size(90, 41);
            numFour.TabIndex = 6;
            numFour.Text = "4";
            numFour.UseVisualStyleBackColor = true;
            numFour.Click += numBtn_Click;
            // 
            // numFive
            // 
            numFive.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numFive.Location = new Point(201, 335);
            numFive.Name = "numFive";
            numFive.Size = new Size(90, 41);
            numFive.TabIndex = 7;
            numFive.Text = "5";
            numFive.UseVisualStyleBackColor = true;
            numFive.Click += numBtn_Click;
            // 
            // numSix
            // 
            numSix.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numSix.Location = new Point(309, 336);
            numSix.Name = "numSix";
            numSix.Size = new Size(90, 41);
            numSix.TabIndex = 8;
            numSix.Text = "6";
            numSix.UseVisualStyleBackColor = true;
            numSix.Click += numBtn_Click;
            // 
            // numOne
            // 
            numOne.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numOne.Location = new Point(94, 397);
            numOne.Name = "numOne";
            numOne.Size = new Size(90, 41);
            numOne.TabIndex = 9;
            numOne.Text = "1";
            numOne.UseVisualStyleBackColor = true;
            numOne.Click += numBtn_Click;
            // 
            // numTwo
            // 
            numTwo.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numTwo.Location = new Point(201, 397);
            numTwo.Name = "numTwo";
            numTwo.Size = new Size(90, 41);
            numTwo.TabIndex = 10;
            numTwo.Text = "2";
            numTwo.UseVisualStyleBackColor = true;
            numTwo.Click += numBtn_Click;
            // 
            // numThree
            // 
            numThree.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            numThree.Location = new Point(309, 397);
            numThree.Name = "numThree";
            numThree.Size = new Size(90, 41);
            numThree.TabIndex = 11;
            numThree.Text = "3";
            numThree.UseVisualStyleBackColor = true;
            numThree.Click += numBtn_Click;
            // 
            // equl
            // 
            equl.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            equl.Location = new Point(430, 335);
            equl.Name = "equl";
            equl.Size = new Size(90, 41);
            equl.TabIndex = 13;
            equl.Text = "=";
            equl.UseVisualStyleBackColor = true;
            equl.Click += equl_Click;
            // 
            // plus
            // 
            plus.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold);
            plus.Location = new Point(430, 268);
            plus.Name = "plus";
            plus.Size = new Size(90, 41);
            plus.TabIndex = 14;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += operBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 522);
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
    }
}
