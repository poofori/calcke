namespace calck
{
    partial class Calculater
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
            butDelet = new Button();
            butRideBok = new Button();
            butLeftBok = new Button();
            butSmolDelet = new Button();
            butSeven = new Button();
            butEight = new Button();
            butNine = new Button();
            butFor = new Button();
            butFive = new Button();
            butSix = new Button();
            butMinus = new Button();
            butOne = new Button();
            butTwo = new Button();
            butThree = new Button();
            butX = new Button();
            butComma = new Button();
            butZero = new Button();
            butEqually = new Button();
            butPlus = new Button();
            butDivide = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.Black;
            txtDisplay.ForeColor = SystemColors.Control;
            txtDisplay.Location = new Point(15, 15);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(485, 70);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "Введите число:";
            // 
            // butDelet
            // 
            butDelet.BackColor = Color.White;
            butDelet.FlatStyle = FlatStyle.Flat;
            butDelet.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butDelet.ForeColor = SystemColors.ActiveCaptionText;
            butDelet.Location = new Point(15, 100);
            butDelet.Name = "butDelet";
            butDelet.Size = new Size(110, 90);
            butDelet.TabIndex = 1;
            butDelet.Text = "C";
            butDelet.UseVisualStyleBackColor = false;
            // 
            // butRideBok
            // 
            butRideBok.BackColor = Color.White;
            butRideBok.FlatStyle = FlatStyle.Flat;
            butRideBok.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butRideBok.ForeColor = SystemColors.ActiveCaptionText;
            butRideBok.Location = new Point(140, 100);
            butRideBok.Name = "butRideBok";
            butRideBok.Size = new Size(110, 90);
            butRideBok.TabIndex = 2;
            butRideBok.Text = "(";
            butRideBok.UseVisualStyleBackColor = false;
            butRideBok.Click += button2_Click;
            // 
            // butLeftBok
            // 
            butLeftBok.BackColor = Color.White;
            butLeftBok.FlatStyle = FlatStyle.Flat;
            butLeftBok.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butLeftBok.ForeColor = SystemColors.ActiveCaptionText;
            butLeftBok.Location = new Point(265, 100);
            butLeftBok.Name = "butLeftBok";
            butLeftBok.Size = new Size(110, 90);
            butLeftBok.TabIndex = 3;
            butLeftBok.Text = ")";
            butLeftBok.UseVisualStyleBackColor = false;
            // 
            // butSmolDelet
            // 
            butSmolDelet.BackColor = Color.White;
            butSmolDelet.FlatStyle = FlatStyle.Flat;
            butSmolDelet.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butSmolDelet.ForeColor = SystemColors.ActiveCaptionText;
            butSmolDelet.Location = new Point(390, 100);
            butSmolDelet.Name = "butSmolDelet";
            butSmolDelet.Size = new Size(110, 90);
            butSmolDelet.TabIndex = 4;
            butSmolDelet.Text = "⌫";
            butSmolDelet.UseVisualStyleBackColor = false;
            // 
            // butSeven
            // 
            butSeven.BackColor = Color.White;
            butSeven.FlatStyle = FlatStyle.Flat;
            butSeven.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butSeven.ForeColor = SystemColors.ActiveCaptionText;
            butSeven.Location = new Point(15, 200);
            butSeven.Name = "butSeven";
            butSeven.Size = new Size(110, 90);
            butSeven.TabIndex = 5;
            butSeven.Text = "7";
            butSeven.UseVisualStyleBackColor = false;
            // 
            // butEight
            // 
            butEight.BackColor = Color.White;
            butEight.FlatStyle = FlatStyle.Flat;
            butEight.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butEight.ForeColor = SystemColors.ActiveCaptionText;
            butEight.Location = new Point(140, 200);
            butEight.Name = "butEight";
            butEight.Size = new Size(110, 90);
            butEight.TabIndex = 6;
            butEight.Text = "8";
            butEight.UseVisualStyleBackColor = false;
            // 
            // butNine
            // 
            butNine.BackColor = Color.White;
            butNine.FlatStyle = FlatStyle.Flat;
            butNine.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butNine.ForeColor = SystemColors.ActiveCaptionText;
            butNine.Location = new Point(265, 200);
            butNine.Name = "butNine";
            butNine.Size = new Size(110, 90);
            butNine.TabIndex = 7;
            butNine.Text = "9";
            butNine.UseVisualStyleBackColor = false;
            // 
            // butFor
            // 
            butFor.BackColor = Color.White;
            butFor.FlatStyle = FlatStyle.Flat;
            butFor.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butFor.ForeColor = SystemColors.ActiveCaptionText;
            butFor.Location = new Point(15, 300);
            butFor.Name = "butFor";
            butFor.Size = new Size(110, 90);
            butFor.TabIndex = 8;
            butFor.Text = "4";
            butFor.UseVisualStyleBackColor = false;
            // 
            // butFive
            // 
            butFive.BackColor = Color.White;
            butFive.FlatStyle = FlatStyle.Flat;
            butFive.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butFive.ForeColor = SystemColors.ActiveCaptionText;
            butFive.Location = new Point(140, 300);
            butFive.Name = "butFive";
            butFive.Size = new Size(110, 90);
            butFive.TabIndex = 9;
            butFive.Text = "5";
            butFive.UseVisualStyleBackColor = false;
            // 
            // butSix
            // 
            butSix.BackColor = Color.White;
            butSix.FlatStyle = FlatStyle.Flat;
            butSix.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butSix.ForeColor = SystemColors.ActiveCaptionText;
            butSix.Location = new Point(265, 300);
            butSix.Name = "butSix";
            butSix.Size = new Size(110, 90);
            butSix.TabIndex = 10;
            butSix.Text = "6";
            butSix.UseVisualStyleBackColor = false;
            // 
            // butMinus
            // 
            butMinus.BackColor = Color.White;
            butMinus.FlatStyle = FlatStyle.Flat;
            butMinus.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butMinus.ForeColor = SystemColors.ActiveCaptionText;
            butMinus.Location = new Point(390, 300);
            butMinus.Name = "butMinus";
            butMinus.Size = new Size(110, 90);
            butMinus.TabIndex = 11;
            butMinus.Text = "-";
            butMinus.UseVisualStyleBackColor = false;
            // 
            // butOne
            // 
            butOne.BackColor = Color.White;
            butOne.FlatStyle = FlatStyle.Flat;
            butOne.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butOne.ForeColor = SystemColors.ActiveCaptionText;
            butOne.Location = new Point(15, 400);
            butOne.Name = "butOne";
            butOne.Size = new Size(110, 90);
            butOne.TabIndex = 12;
            butOne.Text = "1";
            butOne.UseVisualStyleBackColor = false;
            // 
            // butTwo
            // 
            butTwo.BackColor = Color.White;
            butTwo.FlatStyle = FlatStyle.Flat;
            butTwo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butTwo.ForeColor = SystemColors.ActiveCaptionText;
            butTwo.Location = new Point(140, 400);
            butTwo.Name = "butTwo";
            butTwo.Size = new Size(110, 90);
            butTwo.TabIndex = 13;
            butTwo.Text = "2";
            butTwo.UseVisualStyleBackColor = false;
            // 
            // butThree
            // 
            butThree.BackColor = Color.White;
            butThree.FlatStyle = FlatStyle.Flat;
            butThree.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butThree.ForeColor = SystemColors.ActiveCaptionText;
            butThree.Location = new Point(265, 400);
            butThree.Name = "butThree";
            butThree.Size = new Size(110, 90);
            butThree.TabIndex = 14;
            butThree.Text = "3";
            butThree.UseVisualStyleBackColor = false;
            // 
            // butX
            // 
            butX.BackColor = Color.White;
            butX.FlatStyle = FlatStyle.Flat;
            butX.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butX.ForeColor = SystemColors.ActiveCaptionText;
            butX.Location = new Point(390, 400);
            butX.Name = "butX";
            butX.Size = new Size(110, 90);
            butX.TabIndex = 15;
            butX.Text = "×";
            butX.UseVisualStyleBackColor = false;
            // 
            // butComma
            // 
            butComma.BackColor = Color.White;
            butComma.FlatStyle = FlatStyle.Flat;
            butComma.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butComma.ForeColor = SystemColors.ActiveCaptionText;
            butComma.Location = new Point(15, 500);
            butComma.Name = "butComma";
            butComma.Size = new Size(110, 90);
            butComma.TabIndex = 16;
            butComma.Text = ",";
            butComma.UseVisualStyleBackColor = false;
            // 
            // butZero
            // 
            butZero.BackColor = Color.White;
            butZero.FlatStyle = FlatStyle.Flat;
            butZero.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butZero.ForeColor = SystemColors.ActiveCaptionText;
            butZero.Location = new Point(140, 500);
            butZero.Name = "butZero";
            butZero.Size = new Size(110, 90);
            butZero.TabIndex = 17;
            butZero.Text = "0";
            butZero.UseVisualStyleBackColor = false;
            // 
            // butEqually
            // 
            butEqually.BackColor = Color.White;
            butEqually.FlatStyle = FlatStyle.Flat;
            butEqually.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butEqually.ForeColor = SystemColors.ActiveCaptionText;
            butEqually.Location = new Point(265, 500);
            butEqually.Name = "butEqually";
            butEqually.Size = new Size(110, 90);
            butEqually.TabIndex = 18;
            butEqually.Text = "=";
            butEqually.UseVisualStyleBackColor = false;
            // 
            // butPlus
            // 
            butPlus.BackColor = Color.White;
            butPlus.FlatStyle = FlatStyle.Flat;
            butPlus.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butPlus.ForeColor = SystemColors.ActiveCaptionText;
            butPlus.Location = new Point(390, 200);
            butPlus.Name = "butPlus";
            butPlus.Size = new Size(110, 90);
            butPlus.TabIndex = 19;
            butPlus.Text = "+";
            butPlus.UseVisualStyleBackColor = false;
            // 
            // butDivide
            // 
            butDivide.BackColor = Color.White;
            butDivide.FlatStyle = FlatStyle.Flat;
            butDivide.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butDivide.ForeColor = SystemColors.ActiveCaptionText;
            butDivide.Location = new Point(390, 500);
            butDivide.Name = "butDivide";
            butDivide.Size = new Size(110, 90);
            butDivide.TabIndex = 20;
            butDivide.Text = "÷";
            butDivide.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(511, 600);
            Controls.Add(butDivide);
            Controls.Add(butPlus);
            Controls.Add(butEqually);
            Controls.Add(butZero);
            Controls.Add(butComma);
            Controls.Add(butX);
            Controls.Add(butThree);
            Controls.Add(butTwo);
            Controls.Add(butOne);
            Controls.Add(butMinus);
            Controls.Add(butSix);
            Controls.Add(butFive);
            Controls.Add(butFor);
            Controls.Add(butNine);
            Controls.Add(butEight);
            Controls.Add(butSeven);
            Controls.Add(butSmolDelet);
            Controls.Add(butLeftBok);
            Controls.Add(butRideBok);
            Controls.Add(butDelet);
            Controls.Add(txtDisplay);
            ForeColor = SystemColors.Control;
            MaximumSize = new Size(527, 639);
            MinimumSize = new Size(527, 639);
            Name = "Form1";
            Text = "calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button butDelet;
        private Button butRideBok;
        private Button butLeftBok;
        private Button butSmolDelet;
        private Button butSeven;
        private Button butEight;
        private Button butNine;
        private Button butFor;
        private Button butFive;
        private Button butSix;
        private Button butMinus;
        private Button butOne;
        private Button butTwo;
        private Button butThree;
        private Button butX;
        private Button butComma;
        private Button butZero;
        private Button butEqually;
        private Button butPlus;
        private Button butDivide;
    }
}
