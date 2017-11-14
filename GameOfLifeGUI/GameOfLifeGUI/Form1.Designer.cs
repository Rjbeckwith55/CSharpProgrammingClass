namespace GameOfLifeGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steadyStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalOscillationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rPentominoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testCasesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // testCasesToolStripMenuItem
            // 
            this.testCasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steadyStateToolStripMenuItem,
            this.verticalOscillationToolStripMenuItem,
            this.rPentominoToolStripMenuItem});
            this.testCasesToolStripMenuItem.Name = "testCasesToolStripMenuItem";
            this.testCasesToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.testCasesToolStripMenuItem.Text = "Test Cases";
            // 
            // steadyStateToolStripMenuItem
            // 
            this.steadyStateToolStripMenuItem.Name = "steadyStateToolStripMenuItem";
            this.steadyStateToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.steadyStateToolStripMenuItem.Text = "Steady State";
            this.steadyStateToolStripMenuItem.Click += new System.EventHandler(this.steadyStateToolStripMenuItem_Click);
            // 
            // verticalOscillationToolStripMenuItem
            // 
            this.verticalOscillationToolStripMenuItem.Name = "verticalOscillationToolStripMenuItem";
            this.verticalOscillationToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.verticalOscillationToolStripMenuItem.Text = "Vertical Oscillation";
            this.verticalOscillationToolStripMenuItem.Click += new System.EventHandler(this.verticalOscillationToolStripMenuItem_Click);
            // 
            // rPentominoToolStripMenuItem
            // 
            this.rPentominoToolStripMenuItem.Name = "rPentominoToolStripMenuItem";
            this.rPentominoToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.rPentominoToolStripMenuItem.Text = "R-Pentomino";
            this.rPentominoToolStripMenuItem.Click += new System.EventHandler(this.rPentominoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 800);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 853);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Game of Life";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testCasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steadyStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalOscillationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rPentominoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

