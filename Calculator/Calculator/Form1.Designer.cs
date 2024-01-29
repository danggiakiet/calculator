namespace Calculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttEqual = new System.Windows.Forms.Button();
            this.iconImgList = new System.Windows.Forms.ImageList(this.components);
            this.bttPoint = new System.Windows.Forms.Button();
            this.bttNumber0 = new System.Windows.Forms.Button();
            this.bttConvert = new System.Windows.Forms.Button();
            this.bttPlus = new System.Windows.Forms.Button();
            this.bttNumber3 = new System.Windows.Forms.Button();
            this.bttNumber2 = new System.Windows.Forms.Button();
            this.bttNumber1 = new System.Windows.Forms.Button();
            this.bttMinus = new System.Windows.Forms.Button();
            this.bttNumber6 = new System.Windows.Forms.Button();
            this.bttNumber5 = new System.Windows.Forms.Button();
            this.bttNumber4 = new System.Windows.Forms.Button();
            this.bttMultip = new System.Windows.Forms.Button();
            this.bttNumber9 = new System.Windows.Forms.Button();
            this.bttNumber8 = new System.Windows.Forms.Button();
            this.bttNumber7 = new System.Windows.Forms.Button();
            this.bttDivide = new System.Windows.Forms.Button();
            this.bttSquareRoot = new System.Windows.Forms.Button();
            this.bttSquare = new System.Windows.Forms.Button();
            this.bttFraction = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttClear = new System.Windows.Forms.Button();
            this.bttClearEntry = new System.Windows.Forms.Button();
            this.bttPercent = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bttEqual);
            this.panel1.Controls.Add(this.bttPoint);
            this.panel1.Controls.Add(this.bttNumber0);
            this.panel1.Controls.Add(this.bttConvert);
            this.panel1.Controls.Add(this.bttPlus);
            this.panel1.Controls.Add(this.bttNumber3);
            this.panel1.Controls.Add(this.bttNumber2);
            this.panel1.Controls.Add(this.bttNumber1);
            this.panel1.Controls.Add(this.bttMinus);
            this.panel1.Controls.Add(this.bttNumber6);
            this.panel1.Controls.Add(this.bttNumber5);
            this.panel1.Controls.Add(this.bttNumber4);
            this.panel1.Controls.Add(this.bttMultip);
            this.panel1.Controls.Add(this.bttNumber9);
            this.panel1.Controls.Add(this.bttNumber8);
            this.panel1.Controls.Add(this.bttNumber7);
            this.panel1.Controls.Add(this.bttDivide);
            this.panel1.Controls.Add(this.bttSquareRoot);
            this.panel1.Controls.Add(this.bttSquare);
            this.panel1.Controls.Add(this.bttFraction);
            this.panel1.Controls.Add(this.bttDelete);
            this.panel1.Controls.Add(this.bttClear);
            this.panel1.Controls.Add(this.bttClearEntry);
            this.panel1.Controls.Add(this.bttPercent);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.txtAns);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 573);
            this.panel1.TabIndex = 0;
            // 
            // bttEqual
            // 
            this.bttEqual.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEqual.ImageKey = "equals-solid.png";
            this.bttEqual.ImageList = this.iconImgList;
            this.bttEqual.Location = new System.Drawing.Point(340, 488);
            this.bttEqual.Name = "bttEqual";
            this.bttEqual.Size = new System.Drawing.Size(100, 60);
            this.bttEqual.TabIndex = 25;
            this.bttEqual.UseVisualStyleBackColor = true;
            // 
            // iconImgList
            // 
            this.iconImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImgList.ImageStream")));
            this.iconImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconImgList.Images.SetKeyName(0, "delete-left-solid.png");
            this.iconImgList.Images.SetKeyName(1, "trash-solid.png");
            this.iconImgList.Images.SetKeyName(2, "divide-solid.png");
            this.iconImgList.Images.SetKeyName(3, "equals-solid.png");
            this.iconImgList.Images.SetKeyName(4, "minus-solid.png");
            this.iconImgList.Images.SetKeyName(5, "plus-solid.png");
            this.iconImgList.Images.SetKeyName(6, "square-root-variable-solid.png");
            this.iconImgList.Images.SetKeyName(7, "xmark-solid.png");
            // 
            // bttPoint
            // 
            this.bttPoint.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPoint.Location = new System.Drawing.Point(234, 488);
            this.bttPoint.Name = "bttPoint";
            this.bttPoint.Size = new System.Drawing.Size(100, 60);
            this.bttPoint.TabIndex = 24;
            this.bttPoint.Text = ".";
            this.bttPoint.UseVisualStyleBackColor = true;
            // 
            // bttNumber0
            // 
            this.bttNumber0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNumber0.Location = new System.Drawing.Point(128, 488);
            this.bttNumber0.Name = "bttNumber0";
            this.bttNumber0.Size = new System.Drawing.Size(100, 60);
            this.bttNumber0.TabIndex = 23;
            this.bttNumber0.Text = "0";
            this.bttNumber0.UseVisualStyleBackColor = true;
            // 
            // bttConvert
            // 
            this.bttConvert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttConvert.Location = new System.Drawing.Point(22, 488);
            this.bttConvert.Name = "bttConvert";
            this.bttConvert.Size = new System.Drawing.Size(100, 60);
            this.bttConvert.TabIndex = 22;
            this.bttConvert.Text = "+/-";
            this.bttConvert.UseVisualStyleBackColor = true;
            // 
            // bttPlus
            // 
            this.bttPlus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPlus.ImageKey = "plus-solid.png";
            this.bttPlus.ImageList = this.iconImgList;
            this.bttPlus.Location = new System.Drawing.Point(340, 418);
            this.bttPlus.Name = "bttPlus";
            this.bttPlus.Size = new System.Drawing.Size(100, 60);
            this.bttPlus.TabIndex = 21;
            this.bttPlus.UseVisualStyleBackColor = true;
            this.bttPlus.Click += new System.EventHandler(this.bttPlus_Click);
            // 
            // bttNumber3
            // 
            this.bttNumber3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNumber3.Location = new System.Drawing.Point(234, 418);
            this.bttNumber3.Name = "bttNumber3";
            this.bttNumber3.Size = new System.Drawing.Size(100, 60);
            this.bttNumber3.TabIndex = 20;
            this.bttNumber3.Text = "3";
            this.bttNumber3.UseVisualStyleBackColor = true;
            this.bttNumber3.Click += new System.EventHandler(this.bttNumber3_Click);
            // 
            // bttNumber2
            // 
            this.bttNumber2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNumber2.Location = new System.Drawing.Point(128, 418);
            this.bttNumber2.Name = "bttNumber2";
            this.bttNumber2.Size = new System.Drawing.Size(100, 60);
            this.bttNumber2.TabIndex = 19;
            this.bttNumber2.Text = "2";
            this.bttNumber2.UseVisualStyleBackColor = true;
            this.bttNumber2.Click += new System.EventHandler(this.bttNumber2_Click);
            // 
            // bttNumber1
            // 
            this.bttNumber1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNumber1.Location = new System.Drawing.Point(22, 418);
            this.bttNumber1.Name = "bttNumber1";
            this.bttNumber1.Size = new System.Drawing.Size(100, 60);
            this.bttNumber1.TabIndex = 18;
            this.bttNumber1.Text = "1";
            this.bttNumber1.UseVisualStyleBackColor = true;
            this.bttNumber1.Click += new System.EventHandler(this.bttNumber1_Click);
            // 
            // bttMinus
            // 
            this.bttMinus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMinus.ImageKey = "minus-solid.png";
            this.bttMinus.ImageList = this.iconImgList;
            this.bttMinus.Location = new System.Drawing.Point(340, 348);
            this.bttMinus.Name = "bttMinus";
            this.bttMinus.Size = new System.Drawing.Size(100, 60);
            this.bttMinus.TabIndex = 17;
            this.bttMinus.UseVisualStyleBackColor = true;
            this.bttMinus.Click += new System.EventHandler(this.bttMinus_Click);
            // 
            // bttNumber6
            // 
            this.bttNumber6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNumber6.Location = new System.Drawing.Point(234, 348);
            this.bttNumber6.Name = "bttNumber6";
            this.bttNumber6.Size = new System.Drawing.Size(100, 60);
            this.bttNumber6.TabIndex = 16;
            this.bttNumber6.Text = "6";
            this.bttNumber6.UseVisualStyleBackColor = true;
            this.bttNumber6.Click += new System.EventHandler(this.bttNumber6_Click);
            // 
            // bttNumber5
            // 
            this.bttNumber5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNumber5.Location = new System.Drawing.Point(128, 348);
            this.bttNumber5.Name = "bttNumber5";
            this.bttNumber5.Size = new System.Drawing.Size(100, 60);
            this.bttNumber5.TabIndex = 15;
            this.bttNumber5.Text = "5";
            this.bttNumber5.UseVisualStyleBackColor = true;
            this.bttNumber5.Click += new System.EventHandler(this.bttNumber5_Click);
            // 
            // bttNumber4
            // 
            this.bttNumber4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNumber4.Location = new System.Drawing.Point(22, 348);
            this.bttNumber4.Name = "bttNumber4";
            this.bttNumber4.Size = new System.Drawing.Size(100, 60);
            this.bttNumber4.TabIndex = 14;
            this.bttNumber4.Text = "4";
            this.bttNumber4.UseVisualStyleBackColor = true;
            this.bttNumber4.Click += new System.EventHandler(this.bttNumber4_Click);
            // 
            // bttMultip
            // 
            this.bttMultip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMultip.ImageKey = "xmark-solid.png";
            this.bttMultip.ImageList = this.iconImgList;
            this.bttMultip.Location = new System.Drawing.Point(340, 278);
            this.bttMultip.Name = "bttMultip";
            this.bttMultip.Size = new System.Drawing.Size(100, 60);
            this.bttMultip.TabIndex = 13;
            this.bttMultip.UseVisualStyleBackColor = true;
            this.bttMultip.Click += new System.EventHandler(this.bttMultip_Click);
            // 
            // bttNumber9
            // 
            this.bttNumber9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNumber9.Location = new System.Drawing.Point(234, 278);
            this.bttNumber9.Name = "bttNumber9";
            this.bttNumber9.Size = new System.Drawing.Size(100, 60);
            this.bttNumber9.TabIndex = 12;
            this.bttNumber9.Text = "9";
            this.bttNumber9.UseVisualStyleBackColor = true;
            this.bttNumber9.Click += new System.EventHandler(this.bttNumber9_Click);
            // 
            // bttNumber8
            // 
            this.bttNumber8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNumber8.Location = new System.Drawing.Point(128, 278);
            this.bttNumber8.Name = "bttNumber8";
            this.bttNumber8.Size = new System.Drawing.Size(100, 60);
            this.bttNumber8.TabIndex = 11;
            this.bttNumber8.Text = "8";
            this.bttNumber8.UseVisualStyleBackColor = true;
            this.bttNumber8.Click += new System.EventHandler(this.bttNumber8_Click);
            // 
            // bttNumber7
            // 
            this.bttNumber7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNumber7.Location = new System.Drawing.Point(22, 278);
            this.bttNumber7.Name = "bttNumber7";
            this.bttNumber7.Size = new System.Drawing.Size(100, 60);
            this.bttNumber7.TabIndex = 10;
            this.bttNumber7.Text = "7";
            this.bttNumber7.UseVisualStyleBackColor = true;
            this.bttNumber7.Click += new System.EventHandler(this.bttNumber7_Click);
            // 
            // bttDivide
            // 
            this.bttDivide.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDivide.ImageKey = "divide-solid.png";
            this.bttDivide.ImageList = this.iconImgList;
            this.bttDivide.Location = new System.Drawing.Point(340, 208);
            this.bttDivide.Name = "bttDivide";
            this.bttDivide.Size = new System.Drawing.Size(100, 60);
            this.bttDivide.TabIndex = 9;
            this.bttDivide.UseVisualStyleBackColor = true;
            this.bttDivide.Click += new System.EventHandler(this.bttDivide_Click);
            // 
            // bttSquareRoot
            // 
            this.bttSquareRoot.ImageKey = "square-root-variable-solid.png";
            this.bttSquareRoot.ImageList = this.iconImgList;
            this.bttSquareRoot.Location = new System.Drawing.Point(234, 208);
            this.bttSquareRoot.Name = "bttSquareRoot";
            this.bttSquareRoot.Size = new System.Drawing.Size(100, 60);
            this.bttSquareRoot.TabIndex = 8;
            this.bttSquareRoot.UseVisualStyleBackColor = true;
            // 
            // bttSquare
            // 
            this.bttSquare.Location = new System.Drawing.Point(128, 208);
            this.bttSquare.Name = "bttSquare";
            this.bttSquare.Size = new System.Drawing.Size(100, 60);
            this.bttSquare.TabIndex = 7;
            this.bttSquare.Text = "x²";
            this.bttSquare.UseVisualStyleBackColor = true;
            // 
            // bttFraction
            // 
            this.bttFraction.Location = new System.Drawing.Point(22, 208);
            this.bttFraction.Name = "bttFraction";
            this.bttFraction.Size = new System.Drawing.Size(100, 60);
            this.bttFraction.TabIndex = 6;
            this.bttFraction.Text = "1/x";
            this.bttFraction.UseVisualStyleBackColor = true;
            // 
            // bttDelete
            // 
            this.bttDelete.ImageKey = "delete-left-solid.png";
            this.bttDelete.ImageList = this.iconImgList;
            this.bttDelete.Location = new System.Drawing.Point(340, 138);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(100, 60);
            this.bttDelete.TabIndex = 5;
            this.bttDelete.UseVisualStyleBackColor = true;
            // 
            // bttClear
            // 
            this.bttClear.Location = new System.Drawing.Point(234, 138);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(100, 60);
            this.bttClear.TabIndex = 4;
            this.bttClear.Text = "C";
            this.bttClear.UseVisualStyleBackColor = true;
            // 
            // bttClearEntry
            // 
            this.bttClearEntry.Location = new System.Drawing.Point(128, 138);
            this.bttClearEntry.Name = "bttClearEntry";
            this.bttClearEntry.Size = new System.Drawing.Size(100, 60);
            this.bttClearEntry.TabIndex = 3;
            this.bttClearEntry.Text = "CE";
            this.bttClearEntry.UseVisualStyleBackColor = true;
            // 
            // bttPercent
            // 
            this.bttPercent.Location = new System.Drawing.Point(22, 138);
            this.bttPercent.Name = "bttPercent";
            this.bttPercent.Size = new System.Drawing.Size(100, 60);
            this.bttPercent.TabIndex = 2;
            this.bttPercent.Text = "%";
            this.bttPercent.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(50, 58);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResult.Size = new System.Drawing.Size(390, 39);
            this.txtResult.TabIndex = 1;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(228, 23);
            this.txtAns.Name = "txtAns";
            this.txtAns.ReadOnly = true;
            this.txtAns.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAns.Size = new System.Drawing.Size(212, 29);
            this.txtAns.TabIndex = 0;
            this.txtAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(482, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(251, 573);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(243, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 597);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Button bttPercent;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.Button bttClearEntry;
        private System.Windows.Forms.Button bttEqual;
        private System.Windows.Forms.Button bttPoint;
        private System.Windows.Forms.Button bttNumber0;
        private System.Windows.Forms.Button bttConvert;
        private System.Windows.Forms.Button bttPlus;
        private System.Windows.Forms.Button bttNumber3;
        private System.Windows.Forms.Button bttNumber2;
        private System.Windows.Forms.Button bttNumber1;
        private System.Windows.Forms.Button bttMinus;
        private System.Windows.Forms.Button bttNumber6;
        private System.Windows.Forms.Button bttNumber5;
        private System.Windows.Forms.Button bttNumber4;
        private System.Windows.Forms.Button bttMultip;
        private System.Windows.Forms.Button bttNumber9;
        private System.Windows.Forms.Button bttNumber8;
        private System.Windows.Forms.Button bttNumber7;
        private System.Windows.Forms.Button bttDivide;
        private System.Windows.Forms.Button bttSquareRoot;
        private System.Windows.Forms.Button bttSquare;
        private System.Windows.Forms.Button bttFraction;
        private System.Windows.Forms.ImageList iconImgList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

