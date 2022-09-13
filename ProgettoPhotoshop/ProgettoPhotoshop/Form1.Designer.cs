namespace ProgettoPhotoshop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAnotherWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.specificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastoTxt = new System.Windows.Forms.ToolStripTextBox();
            this.applyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invertedColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxSogliatura = new System.Windows.Forms.ToolStripTextBox();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aumentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diminuisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxAddendo = new System.Windows.Forms.ToolStripTextBox();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianSmoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplancianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.reverseBtn = new System.Windows.Forms.ToolStripButton();
            this.closeTabBtn = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveBtn,
            this.toolStripSplitButton2,
            this.toolStripSplitButton1,
            this.toolStripButton1,
            this.reverseBtn,
            this.closeTabBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(2136, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(68, 44);
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openAnotherWindowToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(100, 36);
            this.toolStripSplitButton2.Text = "Open";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(385, 44);
            this.openToolStripMenuItem.Text = "New Image";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openAnotherWindowToolStripMenuItem
            // 
            this.openAnotherWindowToolStripMenuItem.Name = "openAnotherWindowToolStripMenuItem";
            this.openAnotherWindowToolStripMenuItem.Size = new System.Drawing.Size(385, 44);
            this.openAnotherWindowToolStripMenuItem.Text = "Open another window";
            this.openAnotherWindowToolStripMenuItem.Click += new System.EventHandler(this.openAnotherWindowToolStripMenuItem_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specificToolStripMenuItem,
            this.convolutionToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(104, 36);
            this.toolStripSplitButton1.Text = "Filters";
            // 
            // specificToolStripMenuItem
            // 
            this.specificToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrastToolStripMenuItem,
            this.invertedColorsToolStripMenuItem,
            this.greyscaleToolStripMenuItem,
            this.thresholdingToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.sepiaToolStripMenuItem});
            this.specificToolStripMenuItem.Name = "specificToolStripMenuItem";
            this.specificToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.specificToolStripMenuItem.Text = "Specific";
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrastoTxt,
            this.applyToolStripMenuItem1});
            this.contrastToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.ToolTipText = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // contrastoTxt
            // 
            this.contrastoTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contrastoTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.contrastoTxt.Name = "contrastoTxt";
            this.contrastoTxt.Size = new System.Drawing.Size(160, 39);
            this.contrastoTxt.Text = "Positive value";
            // 
            // applyToolStripMenuItem1
            // 
            this.applyToolStripMenuItem1.Name = "applyToolStripMenuItem1";
            this.applyToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.applyToolStripMenuItem1.Text = "Apply";
            this.applyToolStripMenuItem1.Click += new System.EventHandler(this.applyToolStripMenuItem1_Click);
            // 
            // invertedColorsToolStripMenuItem
            // 
            this.invertedColorsToolStripMenuItem.Name = "invertedColorsToolStripMenuItem";
            this.invertedColorsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.invertedColorsToolStripMenuItem.Text = "Inverted Colors";
            this.invertedColorsToolStripMenuItem.Click += new System.EventHandler(this.invertedColorsToolStripMenuItem_Click);
            // 
            // greyscaleToolStripMenuItem
            // 
            this.greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            this.greyscaleToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.greyscaleToolStripMenuItem.Text = "Greyscale";
            this.greyscaleToolStripMenuItem.Click += new System.EventHandler(this.greyscaleToolStripMenuItem_Click);
            // 
            // thresholdingToolStripMenuItem
            // 
            this.thresholdingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtBoxSogliatura,
            this.applyToolStripMenuItem});
            this.thresholdingToolStripMenuItem.Name = "thresholdingToolStripMenuItem";
            this.thresholdingToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.thresholdingToolStripMenuItem.Text = "Thresholding";
            this.thresholdingToolStripMenuItem.Click += new System.EventHandler(this.thresholdingToolStripMenuItem_Click);
            // 
            // txtBoxSogliatura
            // 
            this.txtBoxSogliatura.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxSogliatura.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxSogliatura.Name = "txtBoxSogliatura";
            this.txtBoxSogliatura.Size = new System.Drawing.Size(160, 39);
            this.txtBoxSogliatura.Text = "1-255";
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
            this.applyToolStripMenuItem.Text = "Apply";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aumentaToolStripMenuItem,
            this.diminuisciToolStripMenuItem,
            this.txtBoxAddendo});
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            // 
            // aumentaToolStripMenuItem
            // 
            this.aumentaToolStripMenuItem.Name = "aumentaToolStripMenuItem";
            this.aumentaToolStripMenuItem.Size = new System.Drawing.Size(244, 44);
            this.aumentaToolStripMenuItem.Text = "Increase";
            this.aumentaToolStripMenuItem.Click += new System.EventHandler(this.aumentaToolStripMenuItem_Click);
            // 
            // diminuisciToolStripMenuItem
            // 
            this.diminuisciToolStripMenuItem.Name = "diminuisciToolStripMenuItem";
            this.diminuisciToolStripMenuItem.Size = new System.Drawing.Size(244, 44);
            this.diminuisciToolStripMenuItem.Text = "Decrease";
            this.diminuisciToolStripMenuItem.Click += new System.EventHandler(this.diminuisciToolStripMenuItem_Click);
            // 
            // txtBoxAddendo
            // 
            this.txtBoxAddendo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxAddendo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxAddendo.Name = "txtBoxAddendo";
            this.txtBoxAddendo.Size = new System.Drawing.Size(100, 39);
            this.txtBoxAddendo.Text = "1-255";
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // convolutionToolStripMenuItem
            // 
            this.convolutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.softenToolStripMenuItem,
            this.sharpnerToolStripMenuItem,
            this.medianSmoothingToolStripMenuItem,
            this.laplancianToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.prewittToolStripMenuItem});
            this.convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            this.convolutionToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.convolutionToolStripMenuItem.Text = "Convolution";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(353, 44);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // softenToolStripMenuItem
            // 
            this.softenToolStripMenuItem.Name = "softenToolStripMenuItem";
            this.softenToolStripMenuItem.Size = new System.Drawing.Size(353, 44);
            this.softenToolStripMenuItem.Text = "Soften";
            this.softenToolStripMenuItem.Click += new System.EventHandler(this.softenToolStripMenuItem_Click);
            // 
            // sharpnerToolStripMenuItem
            // 
            this.sharpnerToolStripMenuItem.Name = "sharpnerToolStripMenuItem";
            this.sharpnerToolStripMenuItem.Size = new System.Drawing.Size(353, 44);
            this.sharpnerToolStripMenuItem.Text = "Sharpner";
            this.sharpnerToolStripMenuItem.Click += new System.EventHandler(this.sharpnerToolStripMenuItem_Click);
            // 
            // medianSmoothingToolStripMenuItem
            // 
            this.medianSmoothingToolStripMenuItem.Name = "medianSmoothingToolStripMenuItem";
            this.medianSmoothingToolStripMenuItem.Size = new System.Drawing.Size(353, 44);
            this.medianSmoothingToolStripMenuItem.Text = "Median Smoothing";
            this.medianSmoothingToolStripMenuItem.Click += new System.EventHandler(this.medianSmoothingToolStripMenuItem_Click);
            // 
            // laplancianToolStripMenuItem
            // 
            this.laplancianToolStripMenuItem.Name = "laplancianToolStripMenuItem";
            this.laplancianToolStripMenuItem.Size = new System.Drawing.Size(353, 44);
            this.laplancianToolStripMenuItem.Text = "Laplancian ";
            this.laplancianToolStripMenuItem.Click += new System.EventHandler(this.laplancianToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem});
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(353, 44);
            this.sobelToolStripMenuItem.Text = "Sobel";
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(203, 44);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(203, 44);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // prewittToolStripMenuItem
            // 
            this.prewittToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem1,
            this.rightToolStripMenuItem1});
            this.prewittToolStripMenuItem.Name = "prewittToolStripMenuItem";
            this.prewittToolStripMenuItem.Size = new System.Drawing.Size(353, 44);
            this.prewittToolStripMenuItem.Text = "Prewitt";
            // 
            // leftToolStripMenuItem1
            // 
            this.leftToolStripMenuItem1.Name = "leftToolStripMenuItem1";
            this.leftToolStripMenuItem1.Size = new System.Drawing.Size(203, 44);
            this.leftToolStripMenuItem1.Text = "Left";
            this.leftToolStripMenuItem1.Click += new System.EventHandler(this.leftToolStripMenuItem1_Click);
            // 
            // rightToolStripMenuItem1
            // 
            this.rightToolStripMenuItem1.Name = "rightToolStripMenuItem1";
            this.rightToolStripMenuItem1.Size = new System.Drawing.Size(203, 44);
            this.rightToolStripMenuItem1.Text = "Right";
            this.rightToolStripMenuItem1.Click += new System.EventHandler(this.rightToolStripMenuItem1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 36);
            this.toolStripButton1.Text = "Undo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // reverseBtn
            // 
            this.reverseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reverseBtn.Image = ((System.Drawing.Image)(resources.GetObject("reverseBtn.Image")));
            this.reverseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reverseBtn.Name = "reverseBtn";
            this.reverseBtn.Size = new System.Drawing.Size(100, 36);
            this.reverseBtn.Text = "Reverse";
            this.reverseBtn.Click += new System.EventHandler(this.reverseBtn_Click);
            // 
            // closeTabBtn
            // 
            this.closeTabBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closeTabBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeTabBtn.Image")));
            this.closeTabBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeTabBtn.Name = "closeTabBtn";
            this.closeTabBtn.Size = new System.Drawing.Size(165, 36);
            this.closeTabBtn.Text = "Close window";
            this.closeTabBtn.Click += new System.EventHandler(this.closeTabBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2126, 1176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2136, 1185);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(2120, 1138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image_1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2136, 1235);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem specificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertedColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aumentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diminuisciToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtBoxAddendo;
        private System.Windows.Forms.ToolStripTextBox txtBoxSogliatura;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton reverseBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem medianSmoothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplancianToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton closeTabBtn;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewittToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAnotherWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox contrastoTxt;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
    }
}

