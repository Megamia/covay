namespace GO_Game
{
    partial class Ranking
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbName1 = new System.Windows.Forms.Label();
            this.lbStar1 = new System.Windows.Forms.Label();
            this.lbStar2 = new System.Windows.Forms.Label();
            this.lbName2 = new System.Windows.Forms.Label();
            this.lbStar3 = new System.Windows.Forms.Label();
            this.lbName3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::GO_Game.Properties.Resources.leaderboard;
            this.pictureBox1.Location = new System.Drawing.Point(76, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GO_Game.Properties.Resources.buttonGoBack;
            this.pictureBox2.Location = new System.Drawing.Point(148, 426);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbName1
            // 
            this.lbName1.BackColor = System.Drawing.Color.Transparent;
            this.lbName1.Location = new System.Drawing.Point(199, 178);
            this.lbName1.Name = "lbName1";
            this.lbName1.Size = new System.Drawing.Size(142, 54);
            this.lbName1.TabIndex = 2;
            this.lbName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbStar1
            // 
            this.lbStar1.BackColor = System.Drawing.Color.Transparent;
            this.lbStar1.Location = new System.Drawing.Point(340, 178);
            this.lbStar1.Name = "lbStar1";
            this.lbStar1.Size = new System.Drawing.Size(79, 54);
            this.lbStar1.TabIndex = 3;
            this.lbStar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStar1.Click += new System.EventHandler(this.lbStar1_Click);
            // 
            // lbStar2
            // 
            this.lbStar2.Location = new System.Drawing.Point(340, 256);
            this.lbStar2.Name = "lbStar2";
            this.lbStar2.Size = new System.Drawing.Size(79, 54);
            this.lbStar2.TabIndex = 5;
            this.lbStar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStar2.Click += new System.EventHandler(this.lbStar2_Click);
            // 
            // lbName2
            // 
            this.lbName2.Location = new System.Drawing.Point(201, 256);
            this.lbName2.Name = "lbName2";
            this.lbName2.Size = new System.Drawing.Size(140, 54);
            this.lbName2.TabIndex = 4;
            this.lbName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName2.Click += new System.EventHandler(this.lbName2_Click);
            // 
            // lbStar3
            // 
            this.lbStar3.Location = new System.Drawing.Point(340, 333);
            this.lbStar3.Name = "lbStar3";
            this.lbStar3.Size = new System.Drawing.Size(79, 54);
            this.lbStar3.TabIndex = 7;
            this.lbStar3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStar3.Click += new System.EventHandler(this.lbStar3_Click);
            // 
            // lbName3
            // 
            this.lbName3.Location = new System.Drawing.Point(201, 333);
            this.lbName3.Name = "lbName3";
            this.lbName3.Size = new System.Drawing.Size(140, 54);
            this.lbName3.TabIndex = 6;
            this.lbName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName3.Click += new System.EventHandler(this.lbName3_Click);
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(536, 558);
            this.Controls.Add(this.lbStar3);
            this.Controls.Add(this.lbName3);
            this.Controls.Add(this.lbStar2);
            this.Controls.Add(this.lbName2);
            this.Controls.Add(this.lbStar1);
            this.Controls.Add(this.lbName1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ranking";
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.Ranking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbName1;
        private System.Windows.Forms.Label lbStar1;
        private System.Windows.Forms.Label lbStar2;
        private System.Windows.Forms.Label lbName2;
        private System.Windows.Forms.Label lbStar3;
        private System.Windows.Forms.Label lbName3;
    }
}