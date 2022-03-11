
namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    partial class MainForm01
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem,
            this.cOURSEToolStripMenuItem,
            this.sCORESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.studentListToolStripMenuItem,
            this.staticsToolStripMenuItem,
            this.editRemoveToolStripMenuItem,
            this.manageStudentFormToolStripMenuItem,
            this.printToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addNewStudentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Menu;
            this.addNewStudentToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.addNewStudentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.studentListToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.studentListToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.studentListToolStripMenuItem.Text = "Student  List";
            // 
            // staticsToolStripMenuItem
            // 
            this.staticsToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.staticsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.staticsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.staticsToolStripMenuItem.Text = "Statics";
            // 
            // editRemoveToolStripMenuItem
            // 
            this.editRemoveToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.editRemoveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.editRemoveToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            this.editRemoveToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.editRemoveToolStripMenuItem.Text = "Edit / Remove";
            // 
            // manageStudentFormToolStripMenuItem
            // 
            this.manageStudentFormToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.manageStudentFormToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.manageStudentFormToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.manageStudentFormToolStripMenuItem.Name = "manageStudentFormToolStripMenuItem";
            this.manageStudentFormToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.manageStudentFormToolStripMenuItem.Text = "Manage Student Form";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.printToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // cOURSEToolStripMenuItem
            // 
            this.cOURSEToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cOURSEToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            this.cOURSEToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.cOURSEToolStripMenuItem.Text = "COURSES";
            this.cOURSEToolStripMenuItem.Click += new System.EventHandler(this.cOURSEToolStripMenuItem_Click);
            // 
            // sCORESToolStripMenuItem
            // 
            this.sCORESToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sCORESToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.sCORESToolStripMenuItem.Name = "sCORESToolStripMenuItem";
            this.sCORESToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.sCORESToolStripMenuItem.Text = "SCORES";
            // 
            // MainForm01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm01";
            this.Text = "MainForm01";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}