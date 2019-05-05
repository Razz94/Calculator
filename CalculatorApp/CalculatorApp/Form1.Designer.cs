namespace CalculatorApp
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
            System.Windows.Forms.Button btnOne;
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.secondaryDisplay = new System.Windows.Forms.TextBox();
            this.mainDisplay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            btnOne = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            btnOne.BackColor = System.Drawing.Color.SteelBlue;
            btnOne.FlatAppearance.BorderSize = 0;
            btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnOne.ForeColor = System.Drawing.SystemColors.MenuBar;
            btnOne.Location = new System.Drawing.Point(7, 237);
            btnOne.Name = "btnOne";
            btnOne.Size = new System.Drawing.Size(59, 40);
            btnOne.TabIndex = 12;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += new System.EventHandler(this.clickAll);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCE.Location = new System.Drawing.Point(7, 99);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(59, 40);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.clickAll);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnC.Location = new System.Drawing.Point(72, 99);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(59, 40);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.clickAll);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnDiv.Location = new System.Drawing.Point(202, 99);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(59, 40);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.ClickOperation);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnDel.Location = new System.Drawing.Point(137, 99);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(59, 40);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.clickAll);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnMult.Location = new System.Drawing.Point(202, 145);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(59, 40);
            this.btnMult.TabIndex = 7;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.ClickOperation);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnNine.Location = new System.Drawing.Point(137, 145);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(59, 40);
            this.btnNine.TabIndex = 6;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.clickAll);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnEight.Location = new System.Drawing.Point(72, 145);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(59, 40);
            this.btnEight.TabIndex = 5;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.clickAll);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnSeven.Location = new System.Drawing.Point(7, 145);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(59, 40);
            this.btnSeven.TabIndex = 4;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.clickAll);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnAdd.Location = new System.Drawing.Point(202, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 40);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.ClickOperation);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnThree.Location = new System.Drawing.Point(137, 237);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(59, 40);
            this.btnThree.TabIndex = 14;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.clickAll);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnTwo.Location = new System.Drawing.Point(72, 237);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(59, 40);
            this.btnTwo.TabIndex = 13;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.clickAll);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSub.FlatAppearance.BorderSize = 0;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnSub.Location = new System.Drawing.Point(202, 191);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(59, 40);
            this.btnSub.TabIndex = 11;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.ClickOperation);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnSix.Location = new System.Drawing.Point(137, 191);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(59, 40);
            this.btnSix.TabIndex = 10;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.clickAll);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnFive.Location = new System.Drawing.Point(72, 191);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(59, 40);
            this.btnFive.TabIndex = 9;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.clickAll);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnFour.Location = new System.Drawing.Point(7, 191);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(59, 40);
            this.btnFour.TabIndex = 8;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.clickAll);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnEquals.Location = new System.Drawing.Point(202, 283);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(59, 40);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.ClickOperation);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.Color.SteelBlue;
            this.btnComma.FlatAppearance.BorderSize = 0;
            this.btnComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnComma.Location = new System.Drawing.Point(137, 283);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(59, 40);
            this.btnComma.TabIndex = 18;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.clickAll);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.SteelBlue;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnZero.Location = new System.Drawing.Point(72, 283);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(59, 40);
            this.btnZero.TabIndex = 17;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.clickAll);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPlusMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnPlusMinus.Location = new System.Drawing.Point(7, 283);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(59, 40);
            this.btnPlusMinus.TabIndex = 16;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.clickAll);
            // 
            // secondaryDisplay
            // 
            this.secondaryDisplay.BackColor = System.Drawing.Color.SteelBlue;
            this.secondaryDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondaryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryDisplay.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.secondaryDisplay.Location = new System.Drawing.Point(7, 9);
            this.secondaryDisplay.Multiline = true;
            this.secondaryDisplay.Name = "secondaryDisplay";
            this.secondaryDisplay.Size = new System.Drawing.Size(254, 29);
            this.secondaryDisplay.TabIndex = 20;
            this.secondaryDisplay.Text = " ";
            this.secondaryDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mainDisplay
            // 
            this.mainDisplay.BackColor = System.Drawing.Color.SteelBlue;
            this.mainDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDisplay.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.mainDisplay.Location = new System.Drawing.Point(7, 44);
            this.mainDisplay.Multiline = true;
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.Size = new System.Drawing.Size(254, 46);
            this.mainDisplay.TabIndex = 21;
            this.mainDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.secondaryDisplay);
            this.panel1.Controls.Add(this.mainDisplay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 93);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(270, 332);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(btnOne);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.clickAll);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.TextBox secondaryDisplay;
        private System.Windows.Forms.TextBox mainDisplay;
        private System.Windows.Forms.Panel panel1;
    }
}

