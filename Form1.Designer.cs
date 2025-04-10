namespace MDI_StopwatchTimerApp
{
    partial class FormTimer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stopwatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWatchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopwatchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stopwatchToolStripMenuItem
            // 
            this.stopwatchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopWatchToolStripMenuItem1,
            this.timerToolStripMenuItem});
            this.stopwatchToolStripMenuItem.Name = "stopwatchToolStripMenuItem";
            this.stopwatchToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.stopwatchToolStripMenuItem.Text = "Pilih Menu";
            this.stopwatchToolStripMenuItem.Click += new System.EventHandler(this.stopwatchToolStripMenuItem_Click);
            // 
            // stopWatchToolStripMenuItem1
            // 
            this.stopWatchToolStripMenuItem1.Name = "stopWatchToolStripMenuItem1";
            this.stopWatchToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.stopWatchToolStripMenuItem1.Text = "Stop Watch";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timerToolStripMenuItem.Text = "Timer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stopwatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopWatchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
    }
}

