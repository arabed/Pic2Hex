namespace Pic2Hex
{
    partial class MainForm
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textHexCodeOutputBox = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelRightBottom = new System.Windows.Forms.Panel();
            this.buttonGenerateHexCode = new System.Windows.Forms.Button();
            this.panelRightTop = new System.Windows.Forms.Panel();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownContrast = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panelImageTop = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelRightBottom.SuspendLayout();
            this.panelRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContrast)).BeginInit();
            this.panelImageTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(3, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "picture filename";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 154);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(712, 172);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            // 
            // textHexCodeOutputBox
            // 
            this.textHexCodeOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHexCodeOutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textHexCodeOutputBox.Location = new System.Drawing.Point(5, 5);
            this.textHexCodeOutputBox.Multiline = true;
            this.textHexCodeOutputBox.Name = "textHexCodeOutputBox";
            this.textHexCodeOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textHexCodeOutputBox.Size = new System.Drawing.Size(714, 164);
            this.textHexCodeOutputBox.TabIndex = 4;
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.buttonLoad);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(840, 32);
            this.panelTop.TabIndex = 7;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.textHexCodeOutputBox);
            this.panelBottom.Controls.Add(this.panelRightBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 376);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(5);
            this.panelBottom.Size = new System.Drawing.Size(840, 174);
            this.panelBottom.TabIndex = 8;
            // 
            // panelRightBottom
            // 
            this.panelRightBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRightBottom.Controls.Add(this.buttonGenerateHexCode);
            this.panelRightBottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightBottom.Location = new System.Drawing.Point(719, 5);
            this.panelRightBottom.Name = "panelRightBottom";
            this.panelRightBottom.Padding = new System.Windows.Forms.Padding(5);
            this.panelRightBottom.Size = new System.Drawing.Size(116, 164);
            this.panelRightBottom.TabIndex = 13;
            // 
            // buttonGenerateHexCode
            // 
            this.buttonGenerateHexCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonGenerateHexCode.Location = new System.Drawing.Point(5, 98);
            this.buttonGenerateHexCode.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGenerateHexCode.Name = "buttonGenerateHexCode";
            this.buttonGenerateHexCode.Padding = new System.Windows.Forms.Padding(5);
            this.buttonGenerateHexCode.Size = new System.Drawing.Size(102, 57);
            this.buttonGenerateHexCode.TabIndex = 7;
            this.buttonGenerateHexCode.Text = "generate the C code";
            this.buttonGenerateHexCode.UseVisualStyleBackColor = true;
            this.buttonGenerateHexCode.Click += new System.EventHandler(this.buttonGenerateHexCode_Click);
            // 
            // panelRightTop
            // 
            this.panelRightTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRightTop.Controls.Add(this.numericUpDownY);
            this.panelRightTop.Controls.Add(this.label4);
            this.panelRightTop.Controls.Add(this.numericUpDownX);
            this.panelRightTop.Controls.Add(this.label3);
            this.panelRightTop.Controls.Add(this.numericUpDownContrast);
            this.panelRightTop.Controls.Add(this.label2);
            this.panelRightTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightTop.Location = new System.Drawing.Point(717, 5);
            this.panelRightTop.Name = "panelRightTop";
            this.panelRightTop.Padding = new System.Windows.Forms.Padding(5);
            this.panelRightTop.Size = new System.Drawing.Size(114, 330);
            this.panelRightTop.TabIndex = 12;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownY.Location = new System.Drawing.Point(5, 84);
            this.numericUpDownY.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownY.TabIndex = 17;
            this.numericUpDownY.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownY_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(5, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Size: Y";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownX.Location = new System.Drawing.Point(5, 51);
            this.numericUpDownX.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownX.TabIndex = 13;
            this.numericUpDownX.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownX_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(5, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Size: X";
            // 
            // numericUpDownContrast
            // 
            this.numericUpDownContrast.DecimalPlaces = 3;
            this.numericUpDownContrast.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownContrast.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownContrast.Location = new System.Drawing.Point(5, 18);
            this.numericUpDownContrast.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownContrast.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownContrast.Name = "numericUpDownContrast";
            this.numericUpDownContrast.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownContrast.TabIndex = 12;
            this.numericUpDownContrast.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownContrast.ValueChanged += new System.EventHandler(this.numericUpDownContrast_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contrast";
            // 
            // panelImageTop
            // 
            this.panelImageTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelImageTop.Controls.Add(this.splitContainer);
            this.panelImageTop.Controls.Add(this.panelRightTop);
            this.panelImageTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageTop.Location = new System.Drawing.Point(0, 32);
            this.panelImageTop.Name = "panelImageTop";
            this.panelImageTop.Padding = new System.Windows.Forms.Padding(5);
            this.panelImageTop.Size = new System.Drawing.Size(840, 344);
            this.panelImageTop.TabIndex = 10;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(5, 5);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer.Size = new System.Drawing.Size(712, 330);
            this.splitContainer.SplitterDistance = 154;
            this.splitContainer.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.panelImageTop);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "MainForm";
            this.Text = "Pic2Hex ver.0.1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelRightBottom.ResumeLayout(false);
            this.panelRightTop.ResumeLayout(false);
            this.panelRightTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContrast)).EndInit();
            this.panelImageTop.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.TextBox textHexCodeOutputBox;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelImageTop;
        private System.Windows.Forms.Panel panelRightBottom;
        private System.Windows.Forms.Button buttonGenerateHexCode;
        private System.Windows.Forms.Panel panelRightTop;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownContrast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}

