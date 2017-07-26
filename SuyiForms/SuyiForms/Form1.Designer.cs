using System;
using System.Windows.Forms;

namespace SuyiForms
{
    partial class form
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadMenteeSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadMentorSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cb_Quarter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Mentees = new System.Windows.Forms.ListBox();
            this.lb_Matches = new System.Windows.Forms.CheckedListBox();
            this.tb_Details = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadMenteeSpreadsheetToolStripMenuItem,
            this.uploadMentorSpreadsheetToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uploadMenteeSpreadsheetToolStripMenuItem
            // 
            this.uploadMenteeSpreadsheetToolStripMenuItem.Name = "uploadMenteeSpreadsheetToolStripMenuItem";
            this.uploadMenteeSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.uploadMenteeSpreadsheetToolStripMenuItem.Text = "Upload Mentee Spreadsheet";
            // 
            // uploadMentorSpreadsheetToolStripMenuItem
            // 
            this.uploadMentorSpreadsheetToolStripMenuItem.Name = "uploadMentorSpreadsheetToolStripMenuItem";
            this.uploadMentorSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.uploadMentorSpreadsheetToolStripMenuItem.Text = "Upload Mentor Spreadsheet";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.exitToolStripMenuItem.Text = "Upload Teacher Spreadsheet";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(224, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // cb_Quarter
            // 
            this.cb_Quarter.FormattingEnabled = true;
            this.cb_Quarter.Location = new System.Drawing.Point(12, 46);
            this.cb_Quarter.Name = "cb_Quarter";
            this.cb_Quarter.Size = new System.Drawing.Size(121, 21);
            this.cb_Quarter.TabIndex = 1;
            this.cb_Quarter.SelectedIndexChanged += new System.EventHandler(this.cb_Quarter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Quarter:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Mentees
            // 
            this.lb_Mentees.FormattingEnabled = true;
            this.lb_Mentees.Items.AddRange(new object[] {
            "Harry Potter",
            "Albus Dumbledore",
            "Hagrid"});
            this.lb_Mentees.Location = new System.Drawing.Point(13, 73);
            this.lb_Mentees.Name = "lb_Mentees";
            this.lb_Mentees.Size = new System.Drawing.Size(120, 199);
            this.lb_Mentees.TabIndex = 3;
            // 
            // lb_Matches
            // 
            this.lb_Matches.FormattingEnabled = true;
            this.lb_Matches.Items.AddRange(new object[] {
            "Day of the Week\tPeriod\t\tTeacher\t\tSuggested Mentor",
            "Monday \t\t1\t\tFlitwick\t\tBob",
            "Monday\t\t\t1\t\tFlitwick\t\tJohn",
            "Monday\t\t\t1\t\tFlitwick\t\tGeorge(already assigned to 1 other)",
            "Monday\t\t\t1\t\tFlitwick\t\tPercy",
            "Monday\t\t\t2\t\tSnape\t\tEric",
            "\t\t\t\tLucy",
            "\t\t\t\tAlison"});
            this.lb_Matches.Location = new System.Drawing.Point(166, 74);
            this.lb_Matches.Name = "lb_Matches";
            this.lb_Matches.Size = new System.Drawing.Size(471, 274);
            this.lb_Matches.TabIndex = 4;
            this.lb_Matches.SelectedIndexChanged += new System.EventHandler(this.lb_Matches_SelectedIndexChanged);

            this.lb_Matches.ItemCheck += new ItemCheckEventHandler(this.lb_Matches_ItemCheck);

            // 
            // tb_Details
            // 
            this.tb_Details.Location = new System.Drawing.Point(652, 74);
            this.tb_Details.Multiline = true;
            this.tb_Details.Name = "tb_Details";
            this.tb_Details.Size = new System.Drawing.Size(278, 274);
            this.tb_Details.TabIndex = 5;
            this.tb_Details.Text = "Bob\r\nAvailability: 1st period, Monday/Tuesday/Thursday\r\nLanguages: French, German" +
    "\r\nMajor: Computer science\r\nComments: I want to tutor a kid in math";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 439);
            this.Controls.Add(this.tb_Details);
            this.Controls.Add(this.lb_Matches);
            this.Controls.Add(this.lb_Mentees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Quarter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form";
            this.Text = "SUYI Schedule Matcher v1.0";
            this.Load += new System.EventHandler(this.form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadMenteeSpreadsheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadMentorSpreadsheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cb_Quarter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_Mentees;
        private System.Windows.Forms.CheckedListBox lb_Matches;
        private System.Windows.Forms.TextBox tb_Details;
    }
}

