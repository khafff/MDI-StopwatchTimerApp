namespace MDI_StopwatchTimerApp
{
    partial class FormStopWatch1
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
            this.buttonBerhenti = new System.Windows.Forms.Button();
            this.buttonMulai = new System.Windows.Forms.Button();
            this.labelStopWatch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDetik = new System.Windows.Forms.Label();
            this.labelMenit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonBerhenti
            // 
            this.buttonBerhenti.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBerhenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBerhenti.Location = new System.Drawing.Point(470, 287);
            this.buttonBerhenti.Name = "buttonBerhenti";
            this.buttonBerhenti.Size = new System.Drawing.Size(135, 47);
            this.buttonBerhenti.TabIndex = 11;
            this.buttonBerhenti.Text = "Berhenti";
            this.buttonBerhenti.UseVisualStyleBackColor = false;
            // 
            // buttonMulai
            // 
            this.buttonMulai.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMulai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMulai.Location = new System.Drawing.Point(137, 287);
            this.buttonMulai.Name = "buttonMulai";
            this.buttonMulai.Size = new System.Drawing.Size(135, 47);
            this.buttonMulai.TabIndex = 10;
            this.buttonMulai.Text = "Mulai";
            this.buttonMulai.UseVisualStyleBackColor = false;
            // 
            // labelStopWatch
            // 
            this.labelStopWatch.AutoSize = true;
            this.labelStopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopWatch.Location = new System.Drawing.Point(11, 13);
            this.labelStopWatch.Name = "labelStopWatch";
            this.labelStopWatch.Size = new System.Drawing.Size(200, 33);
            this.labelStopWatch.TabIndex = 9;
            this.labelStopWatch.Text = "STOPWATCH";
            this.labelStopWatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDetik
            // 
            this.labelDetik.AutoSize = true;
            this.labelDetik.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetik.Location = new System.Drawing.Point(425, 125);
            this.labelDetik.Name = "labelDetik";
            this.labelDetik.Size = new System.Drawing.Size(52, 55);
            this.labelDetik.TabIndex = 7;
            this.labelDetik.Text = "0";
            this.labelDetik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMenit
            // 
            this.labelMenit.AutoSize = true;
            this.labelMenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenit.Location = new System.Drawing.Point(279, 124);
            this.labelMenit.Name = "labelMenit";
            this.labelMenit.Size = new System.Drawing.Size(52, 55);
            this.labelMenit.TabIndex = 6;
            this.labelMenit.Text = "0";
            this.labelMenit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMenit.Click += new System.EventHandler(this.labelMenit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // FormStopWatch1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBerhenti);
            this.Controls.Add(this.buttonMulai);
            this.Controls.Add(this.labelStopWatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDetik);
            this.Controls.Add(this.labelMenit);
            this.Name = "FormStopWatch1";
            this.Text = "FormStopWatch1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBerhenti;
        private System.Windows.Forms.Button buttonMulai;
        public System.Windows.Forms.Label labelStopWatch;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelDetik;
        public System.Windows.Forms.Label labelMenit;
        private System.Windows.Forms.Timer timer1;
    }
}