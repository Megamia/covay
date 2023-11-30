namespace GO_Game
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelCurrentTurn = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btn_resetGame = new System.Windows.Forms.PictureBox();
            this.pictureBoxCurrentTurn = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Btn_volumn = new System.Windows.Forms.PictureBox();
            this.btn_goBack = new System.Windows.Forms.PictureBox();
            this.btn_setting = new System.Windows.Forms.PictureBox();
            this.Go_Home = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resetGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_volumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_goBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Go_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(666, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Player 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(773, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Player 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Current Turn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelCurrentTurn
            // 
            this.LabelCurrentTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentTurn.Location = new System.Drawing.Point(668, 512);
            this.LabelCurrentTurn.Name = "LabelCurrentTurn";
            this.LabelCurrentTurn.Size = new System.Drawing.Size(175, 45);
            this.LabelCurrentTurn.TabIndex = 16;
            this.LabelCurrentTurn.Text = "Player 1";
            this.LabelCurrentTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::GO_Game.Properties.Resources.humanavatar;
            this.pictureBox8.Location = new System.Drawing.Point(775, 240);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(68, 66);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // btn_resetGame
            // 
            this.btn_resetGame.Image = global::GO_Game.Properties.Resources.reset;
            this.btn_resetGame.Location = new System.Drawing.Point(669, 16);
            this.btn_resetGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_resetGame.Name = "btn_resetGame";
            this.btn_resetGame.Size = new System.Drawing.Size(172, 45);
            this.btn_resetGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_resetGame.TabIndex = 12;
            this.btn_resetGame.TabStop = false;
            this.btn_resetGame.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBoxCurrentTurn
            // 
            this.pictureBoxCurrentTurn.Image = global::GO_Game.Properties.Resources.whiterock;
            this.pictureBoxCurrentTurn.Location = new System.Drawing.Point(666, 360);
            this.pictureBoxCurrentTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCurrentTurn.Name = "pictureBoxCurrentTurn";
            this.pictureBoxCurrentTurn.Size = new System.Drawing.Size(178, 96);
            this.pictureBoxCurrentTurn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCurrentTurn.TabIndex = 9;
            this.pictureBoxCurrentTurn.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::GO_Game.Properties.Resources.humanavatar;
            this.pictureBox5.Location = new System.Drawing.Point(666, 240);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // Btn_volumn
            // 
            this.Btn_volumn.Image = global::GO_Game.Properties.Resources.skip;
            this.Btn_volumn.Location = new System.Drawing.Point(775, 160);
            this.Btn_volumn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_volumn.Name = "Btn_volumn";
            this.Btn_volumn.Size = new System.Drawing.Size(68, 58);
            this.Btn_volumn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_volumn.TabIndex = 7;
            this.Btn_volumn.TabStop = false;
            this.Btn_volumn.Click += new System.EventHandler(this.Btn_volumn_Click);
            // 
            // btn_goBack
            // 
            this.btn_goBack.Image = global::GO_Game.Properties.Resources._return;
            this.btn_goBack.Location = new System.Drawing.Point(668, 160);
            this.btn_goBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(68, 58);
            this.btn_goBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_goBack.TabIndex = 6;
            this.btn_goBack.TabStop = false;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_setting.Image = global::GO_Game.Properties.Resources.More;
            this.btn_setting.Location = new System.Drawing.Point(775, 78);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(68, 58);
            this.btn_setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_setting.TabIndex = 5;
            this.btn_setting.TabStop = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // Go_Home
            // 
            this.Go_Home.BackgroundImage = global::GO_Game.Properties.Resources.Home;
            this.Go_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Go_Home.Image = global::GO_Game.Properties.Resources.Home;
            this.Go_Home.Location = new System.Drawing.Point(668, 78);
            this.Go_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Go_Home.Name = "Go_Home";
            this.Go_Home.Size = new System.Drawing.Size(68, 58);
            this.Go_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Go_Home.TabIndex = 4;
            this.Go_Home.TabStop = false;
            this.Go_Home.Click += new System.EventHandler(this.Go_Home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GO_Game.Properties.Resources.boardChess;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 560);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 595);
            this.Controls.Add(this.LabelCurrentTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.btn_resetGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxCurrentTurn);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Btn_volumn);
            this.Controls.Add(this.btn_goBack);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.Go_Home);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_resetGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_volumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_goBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Go_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Go_Home;
        private System.Windows.Forms.PictureBox btn_setting;
        private System.Windows.Forms.PictureBox btn_goBack;
        private System.Windows.Forms.PictureBox Btn_volumn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBoxCurrentTurn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_resetGame;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCurrentTurn;
    }
}