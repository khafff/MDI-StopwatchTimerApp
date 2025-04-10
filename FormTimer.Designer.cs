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
            this.components = new System.ComponentModel.Container();
            this.labelTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDetik = new System.Windows.Forms.Label();
            this.labelMenit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonMulaiPause = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.button5menit = new System.Windows.Forms.Button();
            this.button10menit = new System.Windows.Forms.Button();
            this.button30menit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(12, 9);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(105, 33);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "TIMER";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDetik
            // 
            this.labelDetik.AutoSize = true;
            this.labelDetik.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetik.Location = new System.Drawing.Point(410, 116);
            this.labelDetik.Name = "labelDetik";
            this.labelDetik.Size = new System.Drawing.Size(52, 55);
            this.labelDetik.TabIndex = 6;
            this.labelDetik.Text = "0";
            this.labelDetik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMenit
            // 
            this.labelMenit.AutoSize = true;
            this.labelMenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenit.Location = new System.Drawing.Point(264, 115);
            this.labelMenit.Name = "labelMenit";
            this.labelMenit.Size = new System.Drawing.Size(52, 55);
            this.labelMenit.TabIndex = 5;
            this.labelMenit.Text = "0";
            this.labelMenit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // buttonMulaiPause
            // 
            this.buttonMulaiPause.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMulaiPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMulaiPause.Location = new System.Drawing.Point(128, 295);
            this.buttonMulaiPause.Name = "buttonMulaiPause";
            this.buttonMulaiPause.Size = new System.Drawing.Size(135, 47);
            this.buttonMulaiPause.TabIndex = 8;
            this.buttonMulaiPause.Text = "Mulai";
            this.buttonMulaiPause.UseVisualStyleBackColor = false;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.Control;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(458, 295);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(135, 47);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // button5menit
            // 
            this.button5menit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5menit.Location = new System.Drawing.Point(202, 201);
            this.button5menit.Name = "button5menit";
            this.button5menit.Size = new System.Drawing.Size(70, 27);
            this.button5menit.TabIndex = 11;
            this.button5menit.Text = "+5:00";
            this.button5menit.UseVisualStyleBackColor = true;
            // 
            // button10menit
            // 
            this.button10menit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10menit.Location = new System.Drawing.Point(327, 201);
            this.button10menit.Name = "button10menit";
            this.button10menit.Size = new System.Drawing.Size(70, 27);
            this.button10menit.TabIndex = 12;
            this.button10menit.Text = "+10:00";
            this.button10menit.UseVisualStyleBackColor = true;
            // 
            // button30menit
            // 
            this.button30menit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30menit.Location = new System.Drawing.Point(448, 201);
            this.button30menit.Name = "button30menit";
            this.button30menit.Size = new System.Drawing.Size(70, 27);
            this.button30menit.TabIndex = 13;
            this.button30menit.Text = "+30:00";
            this.button30menit.UseVisualStyleBackColor = true;
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button30menit);
            this.Controls.Add(this.button10menit);
            this.Controls.Add(this.button5menit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonMulaiPause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDetik);
            this.Controls.Add(this.labelMenit);
            this.Controls.Add(this.labelTimer);
            this.Name = "FormTimer";
            this.Text = "FormTimer";
            this.Load += new System.EventHandler(this.FormTimer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelTimer;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelDetik;
        public System.Windows.Forms.Label labelMenit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonMulaiPause;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button button5menit;
        private System.Windows.Forms.Button button10menit;
        private System.Windows.Forms.Button button30menit;
    }
}