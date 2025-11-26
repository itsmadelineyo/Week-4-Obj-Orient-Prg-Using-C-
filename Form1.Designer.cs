namespace Module4Project
{
    partial class frmOfDataTypes
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
            lblDisplay = new Label();
            btnByte = new Button();
            btnShort = new Button();
            btnInt = new Button();
            btnLong = new Button();
            btnFloat = new Button();
            btnDouble = new Button();
            btnDecimal = new Button();
            btnPow = new Button();
            btnRound = new Button();
            btnSqrt = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblDisplay
            // 
            lblDisplay.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplay.Location = new Point(292, 69);
            lblDisplay.Margin = new Padding(2, 0, 2, 0);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(541, 43);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "Click a button!";
            lblDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnByte
            // 
            btnByte.BackColor = Color.Purple;
            btnByte.ForeColor = Color.White;
            btnByte.Location = new Point(292, 181);
            btnByte.Name = "btnByte";
            btnByte.Size = new Size(112, 34);
            btnByte.TabIndex = 1;
            btnByte.Text = "&Byte (+)";
            btnByte.UseVisualStyleBackColor = false;
            // 
            // btnShort
            // 
            btnShort.BackColor = Color.Purple;
            btnShort.ForeColor = Color.White;
            btnShort.Location = new Point(433, 181);
            btnShort.Name = "btnShort";
            btnShort.Size = new Size(112, 34);
            btnShort.TabIndex = 2;
            btnShort.Text = "&Short (-)";
            btnShort.UseVisualStyleBackColor = false;
            // 
            // btnInt
            // 
            btnInt.BackColor = Color.Purple;
            btnInt.ForeColor = Color.White;
            btnInt.Location = new Point(579, 181);
            btnInt.Name = "btnInt";
            btnInt.Size = new Size(112, 34);
            btnInt.TabIndex = 3;
            btnInt.Text = "&Int (/)";
            btnInt.UseVisualStyleBackColor = false;
            // 
            // btnLong
            // 
            btnLong.BackColor = Color.Purple;
            btnLong.ForeColor = Color.White;
            btnLong.Location = new Point(721, 181);
            btnLong.Name = "btnLong";
            btnLong.Size = new Size(112, 34);
            btnLong.TabIndex = 4;
            btnLong.Text = "&Long (%)";
            btnLong.UseVisualStyleBackColor = false;
            // 
            // btnFloat
            // 
            btnFloat.BackColor = Color.DarkViolet;
            btnFloat.ForeColor = Color.White;
            btnFloat.Location = new Point(362, 265);
            btnFloat.Name = "btnFloat";
            btnFloat.Size = new Size(112, 34);
            btnFloat.TabIndex = 5;
            btnFloat.Text = "&Float (%)";
            btnFloat.UseVisualStyleBackColor = false;
            // 
            // btnDouble
            // 
            btnDouble.BackColor = Color.DarkViolet;
            btnDouble.ForeColor = Color.White;
            btnDouble.Location = new Point(510, 265);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(112, 34);
            btnDouble.TabIndex = 6;
            btnDouble.Text = "&Double (/)";
            btnDouble.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.DarkViolet;
            btnDecimal.ForeColor = Color.White;
            btnDecimal.Location = new Point(655, 266);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(122, 34);
            btnDecimal.TabIndex = 7;
            btnDecimal.Text = "&Decimal (*)";
            btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.Indigo;
            btnPow.ForeColor = Color.White;
            btnPow.Location = new Point(362, 343);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(112, 34);
            btnPow.TabIndex = 8;
            btnPow.Text = "&Power";
            btnPow.UseVisualStyleBackColor = false;
            // 
            // btnRound
            // 
            btnRound.BackColor = Color.Indigo;
            btnRound.ForeColor = Color.White;
            btnRound.Location = new Point(510, 343);
            btnRound.Name = "btnRound";
            btnRound.Size = new Size(112, 34);
            btnRound.TabIndex = 9;
            btnRound.Text = "&Round";
            btnRound.UseVisualStyleBackColor = false;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.Indigo;
            btnSqrt.ForeColor = Color.White;
            btnSqrt.Location = new Point(654, 343);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(122, 34);
            btnSqrt.TabIndex = 10;
            btnSqrt.Text = "&Square Root";
            btnSqrt.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(922, 613);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1060, 613);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 12;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmOfDataTypes
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(1245, 715);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSqrt);
            Controls.Add(btnRound);
            Controls.Add(btnPow);
            Controls.Add(btnDecimal);
            Controls.Add(btnDouble);
            Controls.Add(btnFloat);
            Controls.Add(btnLong);
            Controls.Add(btnInt);
            Controls.Add(btnShort);
            Controls.Add(btnByte);
            Controls.Add(lblDisplay);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmOfDataTypes";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Label lblDisplay;
        private Button btnByte;
        private Button btnShort;
        private Button btnInt;
        private Button btnLong;
        private Button btnFloat;
        private Button btnDouble;
        private Button btnDecimal;
        private Button btnPow;
        private Button btnRound;
        private Button btnSqrt;
        private Button btnClear;
        private Button btnExit;
    }
}
