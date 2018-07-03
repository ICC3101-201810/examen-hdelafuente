namespace Pac_Man
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
            this.starting_panel = new System.Windows.Forms.Panel();
            this.start = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_name = new System.Windows.Forms.Label();
            this.TopScores = new System.Windows.Forms.Panel();
            this.label_scores = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Game_Over = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.esa_wea = new System.Windows.Forms.PictureBox();
            this.cherry = new System.Windows.Forms.PictureBox();
            this.pacman = new System.Windows.Forms.PictureBox();
            this.pink_ghost = new System.Windows.Forms.PictureBox();
            this.red_ghost = new System.Windows.Forms.PictureBox();
            this.starting_panel.SuspendLayout();
            this.TopScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esa_wea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink_ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_ghost)).BeginInit();
            this.SuspendLayout();
            // 
            // starting_panel
            // 
            this.starting_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.starting_panel.Controls.Add(this.start);
            this.starting_panel.Controls.Add(this.name_label);
            this.starting_panel.Controls.Add(this.name_textbox);
            this.starting_panel.Location = new System.Drawing.Point(786, 12);
            this.starting_panel.Name = "starting_panel";
            this.starting_panel.Size = new System.Drawing.Size(200, 152);
            this.starting_panel.TabIndex = 0;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(58, 84);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "Play";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(73, 42);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(44, 58);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 13);
            this.label_name.TabIndex = 2;
            // 
            // TopScores
            // 
            this.TopScores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopScores.Controls.Add(this.label_scores);
            this.TopScores.Location = new System.Drawing.Point(790, 170);
            this.TopScores.Name = "TopScores";
            this.TopScores.Size = new System.Drawing.Size(200, 100);
            this.TopScores.TabIndex = 11;
            // 
            // label_scores
            // 
            this.label_scores.AutoSize = true;
            this.label_scores.Location = new System.Drawing.Point(3, 10);
            this.label_scores.Name = "label_scores";
            this.label_scores.Size = new System.Drawing.Size(0, 13);
            this.label_scores.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(790, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Show High Scores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game_Over
            // 
            this.Game_Over.AutoSize = true;
            this.Game_Over.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_Over.Location = new System.Drawing.Point(324, 24);
            this.Game_Over.Name = "Game_Over";
            this.Game_Over.Size = new System.Drawing.Size(153, 31);
            this.Game_Over.TabIndex = 13;
            this.Game_Over.Text = "Game Over";
            this.Game_Over.Visible = false;
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(362, 67);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 14;
            this.restart.Text = "Play Again!";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox4.Image = global::Pac_Man.Properties.Resources.Yellow;
            this.pictureBox4.Location = new System.Drawing.Point(3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(781, 20);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox3.Image = global::Pac_Man.Properties.Resources.Yellow;
            this.pictureBox3.Location = new System.Drawing.Point(764, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 560);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox2.Image = global::Pac_Man.Properties.Resources.Yellow;
            this.pictureBox2.Location = new System.Drawing.Point(3, 582);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(781, 20);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Image = global::Pac_Man.Properties.Resources.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 560);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // esa_wea
            // 
            this.esa_wea.ErrorImage = global::Pac_Man.Properties.Resources.cherry;
            this.esa_wea.Image = global::Pac_Man.Properties.Resources.tile114;
            this.esa_wea.InitialImage = global::Pac_Man.Properties.Resources.cherry;
            this.esa_wea.Location = new System.Drawing.Point(646, 69);
            this.esa_wea.Name = "esa_wea";
            this.esa_wea.Size = new System.Drawing.Size(22, 21);
            this.esa_wea.TabIndex = 6;
            this.esa_wea.TabStop = false;
            this.esa_wea.Tag = "fruit";
            // 
            // cherry
            // 
            this.cherry.ErrorImage = global::Pac_Man.Properties.Resources.cherry;
            this.cherry.Image = global::Pac_Man.Properties.Resources.cherry;
            this.cherry.InitialImage = global::Pac_Man.Properties.Resources.cherry;
            this.cherry.Location = new System.Drawing.Point(618, 70);
            this.cherry.Name = "cherry";
            this.cherry.Size = new System.Drawing.Size(22, 21);
            this.cherry.TabIndex = 5;
            this.cherry.TabStop = false;
            this.cherry.Tag = "fruit";
            // 
            // pacman
            // 
            this.pacman.Image = global::Pac_Man.Properties.Resources.pacman_right;
            this.pacman.InitialImage = global::Pac_Man.Properties.Resources.pacman_right;
            this.pacman.Location = new System.Drawing.Point(374, 285);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(22, 21);
            this.pacman.TabIndex = 4;
            this.pacman.TabStop = false;
            // 
            // pink_ghost
            // 
            this.pink_ghost.Image = global::Pac_Man.Properties.Resources.pink_left1;
            this.pink_ghost.InitialImage = global::Pac_Man.Properties.Resources.red_left1;
            this.pink_ghost.Location = new System.Drawing.Point(618, 98);
            this.pink_ghost.Name = "pink_ghost";
            this.pink_ghost.Size = new System.Drawing.Size(22, 21);
            this.pink_ghost.TabIndex = 3;
            this.pink_ghost.TabStop = false;
            this.pink_ghost.Tag = "ghost";
            // 
            // red_ghost
            // 
            this.red_ghost.Image = global::Pac_Man.Properties.Resources.red_left1;
            this.red_ghost.InitialImage = global::Pac_Man.Properties.Resources.red_left1;
            this.red_ghost.Location = new System.Drawing.Point(646, 98);
            this.red_ghost.Name = "red_ghost";
            this.red_ghost.Size = new System.Drawing.Size(22, 21);
            this.red_ghost.TabIndex = 1;
            this.red_ghost.TabStop = false;
            this.red_ghost.Tag = "ghost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 625);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.Game_Over);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TopScores);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.esa_wea);
            this.Controls.Add(this.cherry);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.pink_ghost);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.red_ghost);
            this.Controls.Add(this.starting_panel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.key_up);
            this.starting_panel.ResumeLayout(false);
            this.starting_panel.PerformLayout();
            this.TopScores.ResumeLayout(false);
            this.TopScores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esa_wea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pink_ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red_ghost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel starting_panel;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox red_ghost;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.PictureBox pink_ghost;
        private System.Windows.Forms.PictureBox pacman;
        private System.Windows.Forms.PictureBox cherry;
        private System.Windows.Forms.PictureBox esa_wea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel TopScores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_scores;
        private System.Windows.Forms.Label Game_Over;
        private System.Windows.Forms.Button restart;
    }
}

