namespace hafsa
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
            this.Crp = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Crp
            // 
            this.Crp.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Crp.AnimationSpeed = 500;
            this.Crp.BackColor = System.Drawing.Color.Transparent;
            this.Crp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Crp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Crp.InnerColor = System.Drawing.Color.White;
            this.Crp.InnerMargin = 2;
            this.Crp.InnerWidth = -1;
            this.Crp.Location = new System.Drawing.Point(73, 102);
            this.Crp.MarqueeAnimationSpeed = 2000;
            this.Crp.Name = "Crp";
            this.Crp.OuterColor = System.Drawing.Color.Blue;
            this.Crp.OuterMargin = -25;
            this.Crp.OuterWidth = 26;
            this.Crp.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Crp.ProgressWidth = 25;
            this.Crp.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Crp.Size = new System.Drawing.Size(320, 320);
            this.Crp.StartAngle = 270;
            this.Crp.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Crp.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Crp.SubscriptText = "";
            this.Crp.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Crp.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Crp.SuperscriptText = "";
            this.Crp.TabIndex = 0;
            this.Crp.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Crp.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "University System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prepared By Hafsa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Crp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar Crp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

