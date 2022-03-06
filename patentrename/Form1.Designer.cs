namespace patentrename
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
            this.runBt = new System.Windows.Forms.Button();
            this.sourcePathTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sourcePathBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.destinationPathTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.desBrowseBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.processingStatusLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // runBt
            // 
            this.runBt.Location = new System.Drawing.Point(465, 278);
            this.runBt.Name = "runBt";
            this.runBt.Size = new System.Drawing.Size(75, 23);
            this.runBt.TabIndex = 0;
            this.runBt.Text = "Run";
            this.runBt.UseVisualStyleBackColor = true;
            this.runBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // sourcePathTb
            // 
            this.sourcePathTb.Location = new System.Drawing.Point(60, 93);
            this.sourcePathTb.Name = "sourcePathTb";
            this.sourcePathTb.Size = new System.Drawing.Size(399, 20);
            this.sourcePathTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sourcePathBt
            // 
            this.sourcePathBt.Location = new System.Drawing.Point(465, 90);
            this.sourcePathBt.Name = "sourcePathBt";
            this.sourcePathBt.Size = new System.Drawing.Size(75, 23);
            this.sourcePathBt.TabIndex = 3;
            this.sourcePathBt.Text = "browse";
            this.sourcePathBt.UseVisualStyleBackColor = true;
            this.sourcePathBt.Click += new System.EventHandler(this.directoryPathBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // destinationPathTb
            // 
            this.destinationPathTb.Location = new System.Drawing.Point(60, 153);
            this.destinationPathTb.Name = "destinationPathTb";
            this.destinationPathTb.Size = new System.Drawing.Size(399, 20);
            this.destinationPathTb.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "destination";
            // 
            // desBrowseBtn
            // 
            this.desBrowseBtn.Location = new System.Drawing.Point(465, 151);
            this.desBrowseBtn.Name = "desBrowseBtn";
            this.desBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.desBrowseBtn.TabIndex = 54;
            this.desBrowseBtn.Text = "browse";
            this.desBrowseBtn.UseVisualStyleBackColor = true;
            this.desBrowseBtn.Click += new System.EventHandler(this.desBrowseBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Processing status: ";
            // 
            // processingStatusLb
            // 
            this.processingStatusLb.AutoSize = true;
            this.processingStatusLb.Location = new System.Drawing.Point(163, 196);
            this.processingStatusLb.Name = "processingStatusLb";
            this.processingStatusLb.Size = new System.Drawing.Size(0, 13);
            this.processingStatusLb.TabIndex = 56;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 313);
            this.Controls.Add(this.processingStatusLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desBrowseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.destinationPathTb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sourcePathBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourcePathTb);
            this.Controls.Add(this.runBt);
            this.Name = "Form1";
            this.Text = "Patent Rename Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runBt;
        private System.Windows.Forms.TextBox sourcePathTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sourcePathBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox destinationPathTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button desBrowseBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label processingStatusLb;
    }
}

