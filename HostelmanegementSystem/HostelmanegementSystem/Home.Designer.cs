namespace HostelmanegementSystem
{
    partial class Home
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
            this.HederLabel1 = new System.Windows.Forms.Label();
            this.hederLabel2 = new System.Windows.Forms.Label();
            this.LogingButton = new System.Windows.Forms.Button();
            this.ParalLabel1 = new System.Windows.Forms.Label();
            this.ParaLabel2 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.SignupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // HederLabel1
            // 
            this.HederLabel1.AutoSize = true;
            this.HederLabel1.BackColor = System.Drawing.Color.Transparent;
            this.HederLabel1.Font = new System.Drawing.Font("Righteous", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HederLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.HederLabel1.Location = new System.Drawing.Point(277, 200);
            this.HederLabel1.Name = "HederLabel1";
            this.HederLabel1.Size = new System.Drawing.Size(686, 81);
            this.HederLabel1.TabIndex = 0;
            this.HederLabel1.Text = "Welcome to UB Hostel";
            // 
            // hederLabel2
            // 
            this.hederLabel2.AutoSize = true;
            this.hederLabel2.BackColor = System.Drawing.Color.Transparent;
            this.hederLabel2.Font = new System.Drawing.Font("Righteous", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hederLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.hederLabel2.Location = new System.Drawing.Point(401, 273);
            this.hederLabel2.Name = "hederLabel2";
            this.hederLabel2.Size = new System.Drawing.Size(480, 81);
            this.hederLabel2.TabIndex = 1;
            this.hederLabel2.Text = "Student Portal";
            // 
            // LogingButton
            // 
            this.LogingButton.BackColor = System.Drawing.Color.Black;
            this.LogingButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.LogingButton.FlatAppearance.BorderSize = 4;
            this.LogingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogingButton.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogingButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LogingButton.Location = new System.Drawing.Point(454, 505);
            this.LogingButton.Name = "LogingButton";
            this.LogingButton.Size = new System.Drawing.Size(125, 45);
            this.LogingButton.TabIndex = 2;
            this.LogingButton.Text = "Student";
            this.LogingButton.UseVisualStyleBackColor = false;
            this.LogingButton.Click += new System.EventHandler(this.LogingButton_Click);
            // 
            // ParalLabel1
            // 
            this.ParalLabel1.AutoSize = true;
            this.ParalLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ParalLabel1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParalLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.ParalLabel1.Location = new System.Drawing.Point(334, 392);
            this.ParalLabel1.Name = "ParalLabel1";
            this.ParalLabel1.Size = new System.Drawing.Size(609, 23);
            this.ParalLabel1.TabIndex = 3;
            this.ParalLabel1.Text = "It has always been utmost desire of the Hostel Management";
            // 
            // ParaLabel2
            // 
            this.ParaLabel2.AutoSize = true;
            this.ParaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ParaLabel2.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParaLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.ParaLabel2.Location = new System.Drawing.Point(208, 425);
            this.ParaLabel2.Name = "ParaLabel2";
            this.ParaLabel2.Size = new System.Drawing.Size(841, 24);
            this.ParaLabel2.TabIndex = 4;
            this.ParaLabel2.Text = "to facilitate and help out the boarders while staying in the University Hostels.";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::HostelmanegementSystem.Properties.Resources.ub_hostel_high_resolution_logo_white_on_transparent_background;
            this.logo.Location = new System.Drawing.Point(507, 16);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(192, 189);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // SignupButton
            // 
            this.SignupButton.BackColor = System.Drawing.Color.Black;
            this.SignupButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.SignupButton.FlatAppearance.BorderSize = 4;
            this.SignupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupButton.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.ForeColor = System.Drawing.Color.White;
            this.SignupButton.Location = new System.Drawing.Point(649, 505);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(148, 48);
            this.SignupButton.TabIndex = 6;
            this.SignupButton.Text = "Warden";
            this.SignupButton.UseVisualStyleBackColor = false;
            this.SignupButton.Click += new System.EventHandler(this.SigninButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HostelmanegementSystem.Properties.Resources.wall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 744);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.ParaLabel2);
            this.Controls.Add(this.ParalLabel1);
            this.Controls.Add(this.LogingButton);
            this.Controls.Add(this.hederLabel2);
            this.Controls.Add(this.HederLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1289, 783);
            this.MinimumSize = new System.Drawing.Size(1289, 783);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HederLabel1;
        private System.Windows.Forms.Label hederLabel2;
        private System.Windows.Forms.Button LogingButton;
        private System.Windows.Forms.Label ParalLabel1;
        private System.Windows.Forms.Label ParaLabel2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button SignupButton;
    }
}

