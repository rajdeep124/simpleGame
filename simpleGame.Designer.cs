namespace simpleGame
{
    partial class simpleGame
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
            this.pic_show = new System.Windows.Forms.PictureBox();
            this.load_btn = new System.Windows.Forms.Button();
            this.spin_btn = new System.Windows.Forms.Button();
            this.shootonhead_btn = new System.Windows.Forms.Button();
            this.shootaway_btn = new System.Windows.Forms.Button();
            this.restart_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_show)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_show
            // 
            this.pic_show.Location = new System.Drawing.Point(33, 98);
            this.pic_show.Name = "pic_show";
            this.pic_show.Size = new System.Drawing.Size(450, 267);
            this.pic_show.TabIndex = 0;
            this.pic_show.TabStop = false;
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(608, 117);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 1;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // spin_btn
            // 
            this.spin_btn.Location = new System.Drawing.Point(608, 189);
            this.spin_btn.Name = "spin_btn";
            this.spin_btn.Size = new System.Drawing.Size(75, 23);
            this.spin_btn.TabIndex = 2;
            this.spin_btn.Text = "Spin";
            this.spin_btn.UseVisualStyleBackColor = true;
            this.spin_btn.Click += new System.EventHandler(this.spin_btn_Click);
            // 
            // shootonhead_btn
            // 
            this.shootonhead_btn.Location = new System.Drawing.Point(608, 247);
            this.shootonhead_btn.Name = "shootonhead_btn";
            this.shootonhead_btn.Size = new System.Drawing.Size(88, 23);
            this.shootonhead_btn.TabIndex = 3;
            this.shootonhead_btn.Text = "Shoot on Head";
            this.shootonhead_btn.UseVisualStyleBackColor = true;
            this.shootonhead_btn.Click += new System.EventHandler(this.shootonhead_btn_Click);
            // 
            // shootaway_btn
            // 
            this.shootaway_btn.Location = new System.Drawing.Point(608, 310);
            this.shootaway_btn.Name = "shootaway_btn";
            this.shootaway_btn.Size = new System.Drawing.Size(75, 23);
            this.shootaway_btn.TabIndex = 4;
            this.shootaway_btn.Text = "Shoot Away";
            this.shootaway_btn.UseVisualStyleBackColor = true;
            this.shootaway_btn.Click += new System.EventHandler(this.shootaway_btn_Click);
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(474, 402);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(75, 23);
            this.restart_btn.TabIndex = 5;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(160, 402);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(206, 21);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(406, 55);
            this.title_lbl.TabIndex = 7;
            this.title_lbl.Text = "Russian Roulette";
            // 
            // simpleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::simpleGame.Properties.Resources.gamewal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.shootaway_btn);
            this.Controls.Add(this.shootonhead_btn);
            this.Controls.Add(this.spin_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.pic_show);
            this.Name = "simpleGame";
            this.Text = "simpleGame";
            ((System.ComponentModel.ISupportInitialize)(this.pic_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_show;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button spin_btn;
        private System.Windows.Forms.Button shootonhead_btn;
        private System.Windows.Forms.Button shootaway_btn;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label title_lbl;
    }
}