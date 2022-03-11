
namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    partial class SignUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.verifiPassText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(65, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(356, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName:";
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(490, 143);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(184, 22);
            this.userNameText.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(490, 228);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(184, 22);
            this.passwordText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(356, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // verifiPassText
            // 
            this.verifiPassText.Location = new System.Drawing.Point(490, 319);
            this.verifiPassText.Name = "verifiPassText";
            this.verifiPassText.PasswordChar = '*';
            this.verifiPassText.Size = new System.Drawing.Size(184, 22);
            this.verifiPassText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(356, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Verify Password:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.MistyRose;
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTitle.Location = new System.Drawing.Point(99, 88);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(139, 17);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Create Your Account";
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.LightCoral;
            this.CreateBtn.Location = new System.Drawing.Point(102, 415);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(131, 38);
            this.CreateBtn.TabIndex = 8;
            this.CreateBtn.Text = "Sign Up";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.Red;
            this.closeBTN.Location = new System.Drawing.Point(434, 415);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(131, 38);
            this.closeBTN.TabIndex = 9;
            this.closeBTN.Text = "Exit";
            this.closeBTN.UseVisualStyleBackColor = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.nen;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.verifiPassText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox verifiPassText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button closeBTN;
    }
}