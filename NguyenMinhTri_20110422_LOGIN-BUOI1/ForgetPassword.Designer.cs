
namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    partial class ForgetPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewPassText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPassText = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(210, 57);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset Your Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(274, 141);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(182, 22);
            this.userNameText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(107, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(107, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Password:";
            // 
            // NewPassText
            // 
            this.NewPassText.Location = new System.Drawing.Point(274, 203);
            this.NewPassText.Name = "NewPassText";
            this.NewPassText.PasswordChar = '*';
            this.NewPassText.Size = new System.Drawing.Size(182, 22);
            this.NewPassText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCoral;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(107, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password:";
            // 
            // ConfirmPassText
            // 
            this.ConfirmPassText.Location = new System.Drawing.Point(274, 261);
            this.ConfirmPassText.Name = "ConfirmPassText";
            this.ConfirmPassText.PasswordChar = '*';
            this.ConfirmPassText.Size = new System.Drawing.Size(182, 22);
            this.ConfirmPassText.TabIndex = 5;
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitBtn.Location = new System.Drawing.Point(363, 352);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 17);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.AutoSize = true;
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(145, 352);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(45, 17);
            this.ResetBtn.TabIndex = 8;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::NguyenMinhTri_20110422_LOGIN_BUOI1.Properties.Resources.nen3;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(566, 421);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmPassText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPassText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.label1);
            this.Name = "ForgetPassword";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPassText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfirmPassText;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Label ResetBtn;
    }
}