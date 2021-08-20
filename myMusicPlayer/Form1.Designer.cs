
namespace myMusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstAhang = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAddSound = new System.Windows.Forms.Button();
            this.btnAddDirectory = new System.Windows.Forms.Button();
            this.lblMini = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 57);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 60);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(387, 322);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // lstAhang
            // 
            this.lstAhang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstAhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAhang.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAhang.FormattingEnabled = true;
            this.lstAhang.ItemHeight = 16;
            this.lstAhang.Location = new System.Drawing.Point(393, 60);
            this.lstAhang.Name = "lstAhang";
            this.lstAhang.Size = new System.Drawing.Size(286, 322);
            this.lstAhang.TabIndex = 2;
            this.lstAhang.SelectedIndexChanged += new System.EventHandler(this.lstAhang_SelectedIndexChanged);
            this.lstAhang.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAhang_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnplay
            // 
            this.btnplay.BackgroundImage = global::myMusicPlayer.Properties.Resources.play_button__1_;
            this.btnplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnplay.Location = new System.Drawing.Point(11, 406);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(68, 59);
            this.btnplay.TabIndex = 4;
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnControler);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Location = new System.Drawing.Point(85, 406);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 59);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnControler);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStop.Location = new System.Drawing.Point(159, 406);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(68, 59);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnControler);
            // 
            // btnAddSound
            // 
            this.btnAddSound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSound.BackgroundImage")));
            this.btnAddSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddSound.Location = new System.Drawing.Point(498, 406);
            this.btnAddSound.Name = "btnAddSound";
            this.btnAddSound.Size = new System.Drawing.Size(83, 59);
            this.btnAddSound.TabIndex = 4;
            this.btnAddSound.UseVisualStyleBackColor = true;
            this.btnAddSound.Click += new System.EventHandler(this.addAndRemov);
            // 
            // btnAddDirectory
            // 
            this.btnAddDirectory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDirectory.BackgroundImage")));
            this.btnAddDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddDirectory.Location = new System.Drawing.Point(587, 406);
            this.btnAddDirectory.Name = "btnAddDirectory";
            this.btnAddDirectory.Size = new System.Drawing.Size(84, 59);
            this.btnAddDirectory.TabIndex = 4;
            this.btnAddDirectory.UseVisualStyleBackColor = true;
            this.btnAddDirectory.Click += new System.EventHandler(this.addAndRemov);
            // 
            // lblMini
            // 
            this.lblMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMini.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMini.Location = new System.Drawing.Point(545, 0);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(64, 57);
            this.lblMini.TabIndex = 3;
            this.lblMini.Text = "-";
            this.lblMini.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMini.Click += new System.EventHandler(this.minimise);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.Location = new System.Drawing.Point(233, 406);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 59);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnControler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(678, 488);
            this.Controls.Add(this.btnAddDirectory);
            this.Controls.Add(this.btnAddSound);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.lblMini);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstAhang);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox lstAhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAddSound;
        private System.Windows.Forms.Button btnAddDirectory;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

