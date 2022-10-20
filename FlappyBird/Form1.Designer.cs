namespace FlappyBird
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblScoreWriting = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrIlerle = new System.Windows.Forms.Timer(this.components);
            this.pbCim = new System.Windows.Forms.PictureBox();
            this.pbUstEngel = new System.Windows.Forms.PictureBox();
            this.pbAltEngel = new System.Windows.Forms.PictureBox();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUstEngel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAltEngel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(13, 527);
            this.btnBasla.Margin = new System.Windows.Forms.Padding(4);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(155, 45);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Start";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblScoreWriting
            // 
            this.lblScoreWriting.AutoSize = true;
            this.lblScoreWriting.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreWriting.ForeColor = System.Drawing.SystemColors.Info;
            this.lblScoreWriting.Location = new System.Drawing.Point(13, 9);
            this.lblScoreWriting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreWriting.Name = "lblScoreWriting";
            this.lblScoreWriting.Size = new System.Drawing.Size(64, 20);
            this.lblScoreWriting.TabIndex = 0;
            this.lblScoreWriting.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.ForeColor = System.Drawing.SystemColors.Info;
            this.lblScore.Location = new System.Drawing.Point(84, 9);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(19, 20);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "0";
            // 
            // tmrIlerle
            // 
            this.tmrIlerle.Interval = 20;
            this.tmrIlerle.Tick += new System.EventHandler(this.tmrIlerle_Tick);
            // 
            // pbCim
            // 
            this.pbCim.Image = global::FlappyBird.Properties.Resources.flappyBirdFloor;
            this.pbCim.Location = new System.Drawing.Point(1, 579);
            this.pbCim.Name = "pbCim";
            this.pbCim.Size = new System.Drawing.Size(1186, 75);
            this.pbCim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCim.TabIndex = 6;
            this.pbCim.TabStop = false;
            // 
            // pbUstEngel
            // 
            this.pbUstEngel.Image = global::FlappyBird.Properties.Resources.boru2;
            this.pbUstEngel.Location = new System.Drawing.Point(1049, -2);
            this.pbUstEngel.Margin = new System.Windows.Forms.Padding(4);
            this.pbUstEngel.Name = "pbUstEngel";
            this.pbUstEngel.Size = new System.Drawing.Size(138, 135);
            this.pbUstEngel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUstEngel.TabIndex = 2;
            this.pbUstEngel.TabStop = false;
            // 
            // pbAltEngel
            // 
            this.pbAltEngel.Image = global::FlappyBird.Properties.Resources.boru1;
            this.pbAltEngel.Location = new System.Drawing.Point(668, 359);
            this.pbAltEngel.Margin = new System.Windows.Forms.Padding(4);
            this.pbAltEngel.Name = "pbAltEngel";
            this.pbAltEngel.Size = new System.Drawing.Size(138, 295);
            this.pbAltEngel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAltEngel.TabIndex = 1;
            this.pbAltEngel.TabStop = false;
            // 
            // pbBird
            // 
            this.pbBird.Image = global::FlappyBird.Properties.Resources.top_flying_bird_stickers_for_android_ios_gfycat;
            this.pbBird.Location = new System.Drawing.Point(88, 209);
            this.pbBird.Margin = new System.Windows.Forms.Padding(4);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(80, 70);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1187, 654);
            this.Controls.Add(this.pbBird);
            this.Controls.Add(this.pbCim);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreWriting);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pbUstEngel);
            this.Controls.Add(this.pbAltEngel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUstEngel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAltEngel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbAltEngel;
        private System.Windows.Forms.PictureBox pbUstEngel;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblScoreWriting;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrIlerle;
        private System.Windows.Forms.PictureBox pbCim;
        private System.Windows.Forms.Timer timer1;
    }
}

