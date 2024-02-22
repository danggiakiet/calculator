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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bttEqual = new System.Windows.Forms.Button();
            this.iconImgList = new System.Windows.Forms.ImageList(this.components);
            this.bttPoint = new System.Windows.Forms.Button();
            this.bttConvert = new System.Windows.Forms.Button();
            this.bttPlus = new System.Windows.Forms.Button();
            this.bttMinus = new System.Windows.Forms.Button();
            this.bttMultip = new System.Windows.Forms.Button();
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
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.panelMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.bttEqual);
            this.panelMenu.Controls.Add(this.bttPoint);
            this.panelMenu.Controls.Add(this.bttConvert);
            this.panelMenu.Controls.Add(this.bttPlus);
            this.panelMenu.Controls.Add(this.bttMinus);
            this.panelMenu.Controls.Add(this.bttMultip);
            this.panelMenu.Controls.Add(this.bttDivide);
            this.panelMenu.Controls.Add(this.bttSquareRoot);
            this.panelMenu.Controls.Add(this.bttSquare);
            this.panelMenu.Controls.Add(this.bttFraction);
            this.panelMenu.Controls.Add(this.bttDelete);
            this.panelMenu.Controls.Add(this.bttClear);
            this.panelMenu.Controls.Add(this.bttClearEntry);
            this.panelMenu.Controls.Add(this.bttPercent);
            this.panelMenu.Controls.Add(this.txtResult);
            this.panelMenu.Controls.Add(this.txtAns);
            this.panelMenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(464, 573);
            this.panelMenu.TabIndex = 0;
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
            this.bttEqual.Click += new System.EventHandler(this.bttEqual_Click);
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
            this.bttPoint.Location = new System.Drawing.Point(128, 488);
            this.bttPoint.Name = "bttPoint";
            this.bttPoint.Size = new System.Drawing.Size(100, 60);
            this.bttPoint.TabIndex = 24;
            this.bttPoint.Text = ".";
            this.bttPoint.UseVisualStyleBackColor = true;
            this.bttPoint.Click += new System.EventHandler(this.bttPoint_Click);
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
            this.bttConvert.Click += new System.EventHandler(this.bttConvert_Click);
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
            this.bttSquareRoot.Click += new System.EventHandler(this.bttSquareRoot_Click);
            // 
            // bttSquare
            // 
            this.bttSquare.Location = new System.Drawing.Point(128, 208);
            this.bttSquare.Name = "bttSquare";
            this.bttSquare.Size = new System.Drawing.Size(100, 60);
            this.bttSquare.TabIndex = 7;
            this.bttSquare.Text = "x²";
            this.bttSquare.UseVisualStyleBackColor = true;
            this.bttSquare.Click += new System.EventHandler(this.bttSquare_Click);
            // 
            // bttFraction
            // 
            this.bttFraction.Location = new System.Drawing.Point(22, 208);
            this.bttFraction.Name = "bttFraction";
            this.bttFraction.Size = new System.Drawing.Size(100, 60);
            this.bttFraction.TabIndex = 6;
            this.bttFraction.Text = "1/x";
            this.bttFraction.UseVisualStyleBackColor = true;
            this.bttFraction.Click += new System.EventHandler(this.bttFraction_Click);
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
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttClear
            // 
            this.bttClear.Location = new System.Drawing.Point(234, 138);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(100, 60);
            this.bttClear.TabIndex = 4;
            this.bttClear.Text = "C";
            this.bttClear.UseVisualStyleBackColor = true;
            this.bttClear.Click += new System.EventHandler(this.bttClear_Click);
            // 
            // bttClearEntry
            // 
            this.bttClearEntry.Location = new System.Drawing.Point(128, 138);
            this.bttClearEntry.Name = "bttClearEntry";
            this.bttClearEntry.Size = new System.Drawing.Size(100, 60);
            this.bttClearEntry.TabIndex = 3;
            this.bttClearEntry.Text = "CE";
            this.bttClearEntry.UseVisualStyleBackColor = true;
            this.bttClearEntry.Click += new System.EventHandler(this.bttClearEntry_Click);
            // 
            // bttPercent
            // 
            this.bttPercent.Location = new System.Drawing.Point(22, 138);
            this.bttPercent.Name = "bttPercent";
            this.bttPercent.Size = new System.Drawing.Size(100, 60);
            this.bttPercent.TabIndex = 2;
            this.bttPercent.Text = "%";
            this.bttPercent.UseVisualStyleBackColor = true;
            this.bttPercent.Click += new System.EventHandler(this.bttPercent_Click);
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
            this.tabControl1.Controls.Add(this.tabHistory);
            this.tabControl1.Location = new System.Drawing.Point(482, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(251, 573);
            this.tabControl1.TabIndex = 1;
            // 
            // tabHistory
            // 
            this.tabHistory.AutoScroll = true;
            this.tabHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHistory.Location = new System.Drawing.Point(4, 31);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(243, 538);
            this.tabHistory.TabIndex = 0;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 597);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button bttPercent;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.Button bttClearEntry;
        private System.Windows.Forms.Button bttEqual;
        private System.Windows.Forms.Button bttPoint;
        private System.Windows.Forms.Button bttConvert;
        private System.Windows.Forms.Button bttPlus;
        private System.Windows.Forms.Button bttMinus;
        private System.Windows.Forms.Button bttMultip;
        private System.Windows.Forms.Button bttDivide;
        private System.Windows.Forms.Button bttSquareRoot;
        private System.Windows.Forms.Button bttSquare;
        private System.Windows.Forms.Button bttFraction;
        private System.Windows.Forms.ImageList iconImgList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TextBox txtAns;
    }
}

