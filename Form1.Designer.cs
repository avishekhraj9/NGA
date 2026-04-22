namespace StopWatch
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
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnlap = new System.Windows.Forms.Button();
            this.lblhr = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblsec = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lstlap = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.ForeColor = System.Drawing.Color.Lime;
            this.btnstart.Location = new System.Drawing.Point(170, 218);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(107, 37);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.ForeColor = System.Drawing.Color.Red;
            this.btnstop.Location = new System.Drawing.Point(326, 218);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(92, 37);
            this.btnstop.TabIndex = 1;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnreset
            // 
            this.btnreset.ForeColor = System.Drawing.Color.Blue;
            this.btnreset.Location = new System.Drawing.Point(486, 218);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(92, 37);
            this.btnreset.TabIndex = 2;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnlap
            // 
            this.btnlap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnlap.Location = new System.Drawing.Point(636, 218);
            this.btnlap.Name = "btnlap";
            this.btnlap.Size = new System.Drawing.Size(107, 37);
            this.btnlap.TabIndex = 3;
            this.btnlap.Text = "Lap";
            this.btnlap.UseVisualStyleBackColor = true;
            this.btnlap.Click += new System.EventHandler(this.btnlap_Click);
            // 
            // lblhr
            // 
            this.lblhr.AutoSize = true;
            this.lblhr.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhr.Location = new System.Drawing.Point(260, 88);
            this.lblhr.Name = "lblhr";
            this.lblhr.Size = new System.Drawing.Size(82, 52);
            this.lblhr.TabIndex = 4;
            this.lblhr.Text = "00:";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.Location = new System.Drawing.Point(383, 88);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(82, 52);
            this.lblmin.TabIndex = 5;
            this.lblmin.Text = "00:";
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.Location = new System.Drawing.Point(499, 88);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(70, 52);
            this.lblsec.TabIndex = 6;
            this.lblsec.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lstlap
            // 
            this.lstlap.FormattingEnabled = true;
            this.lstlap.ItemHeight = 20;
            this.lstlap.Location = new System.Drawing.Point(241, 143);
            this.lstlap.Name = "lstlap";
            this.lstlap.Size = new System.Drawing.Size(370, 64);
            this.lstlap.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 337);
            this.Controls.Add(this.lstlap);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.lblhr);
            this.Controls.Add(this.btnlap);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnlap;
        private System.Windows.Forms.Label lblhr;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lstlap;
    }
}

