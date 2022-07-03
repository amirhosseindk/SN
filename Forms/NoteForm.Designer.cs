
namespace Sticky_Notes.Forms
{
    partial class NoteForm
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
            this.NoteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentenceCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitalizeEachWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Bold = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoteSub = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteRichTextBox
            // 
            this.NoteRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NoteRichTextBox.Location = new System.Drawing.Point(0, 75);
            this.NoteRichTextBox.Name = "NoteRichTextBox";
            this.NoteRichTextBox.Size = new System.Drawing.Size(792, 472);
            this.NoteRichTextBox.TabIndex = 0;
            this.NoteRichTextBox.Text = "";
            this.NoteRichTextBox.BackColorChanged += new System.EventHandler(this.NoteRichTextBox_BackColorChanged);
            this.NoteRichTextBox.TextChanged += new System.EventHandler(this.NoteRichTextBox_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 51);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aaToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.toolStripButton3.Image = global::Sticky_Notes.Properties.Resources.png_transparent_computer_icons_dots_three_buttons_text_monochrome_black_thumbnail;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(66, 44);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(445, 6);
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowercaseToolStripMenuItem,
            this.uppercaseToolStripMenuItem,
            this.sentenceCaseToolStripMenuItem,
            this.capitalizeEachWordToolStripMenuItem,
            this.toggleCaseToolStripMenuItem});
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.aaToolStripMenuItem.Text = "Aa";
            // 
            // lowercaseToolStripMenuItem
            // 
            this.lowercaseToolStripMenuItem.Name = "lowercaseToolStripMenuItem";
            this.lowercaseToolStripMenuItem.Size = new System.Drawing.Size(462, 54);
            this.lowercaseToolStripMenuItem.Text = "lowercase";
            this.lowercaseToolStripMenuItem.Click += new System.EventHandler(this.lowercaseToolStripMenuItem_Click);
            // 
            // uppercaseToolStripMenuItem
            // 
            this.uppercaseToolStripMenuItem.Name = "uppercaseToolStripMenuItem";
            this.uppercaseToolStripMenuItem.Size = new System.Drawing.Size(462, 54);
            this.uppercaseToolStripMenuItem.Text = "Uppercase";
            this.uppercaseToolStripMenuItem.Click += new System.EventHandler(this.uppercaseToolStripMenuItem_Click);
            // 
            // sentenceCaseToolStripMenuItem
            // 
            this.sentenceCaseToolStripMenuItem.Name = "sentenceCaseToolStripMenuItem";
            this.sentenceCaseToolStripMenuItem.Size = new System.Drawing.Size(462, 54);
            this.sentenceCaseToolStripMenuItem.Text = "Sentence case";
            this.sentenceCaseToolStripMenuItem.Click += new System.EventHandler(this.sentenceCaseToolStripMenuItem_Click);
            // 
            // capitalizeEachWordToolStripMenuItem
            // 
            this.capitalizeEachWordToolStripMenuItem.Name = "capitalizeEachWordToolStripMenuItem";
            this.capitalizeEachWordToolStripMenuItem.Size = new System.Drawing.Size(462, 54);
            this.capitalizeEachWordToolStripMenuItem.Text = "Capitalize Each Word";
            this.capitalizeEachWordToolStripMenuItem.Click += new System.EventHandler(this.capitalizeEachWordToolStripMenuItem_Click);
            // 
            // toggleCaseToolStripMenuItem
            // 
            this.toggleCaseToolStripMenuItem.Name = "toggleCaseToolStripMenuItem";
            this.toggleCaseToolStripMenuItem.Size = new System.Drawing.Size(462, 54);
            this.toggleCaseToolStripMenuItem.Text = "Toggle Case";
            this.toggleCaseToolStripMenuItem.Click += new System.EventHandler(this.toggleCaseToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bold,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 710);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 54);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Bold
            // 
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(35, 41);
            this.Bold.Text = "B";
            this.Bold.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(26, 41);
            this.toolStripStatusLabel2.Text = "I";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(39, 41);
            this.toolStripStatusLabel3.Text = "U";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(51, 41);
            this.toolStripStatusLabel4.Text = "ab";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackgroundImage = global::Sticky_Notes.Properties.Resources._211677_image_icon;
            this.toolStripStatusLabel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(34, 41);
            this.toolStripStatusLabel5.Text = "  ";
            this.toolStripStatusLabel5.Click += new System.EventHandler(this.toolStripStatusLabel5_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(0, 608);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(792, 99);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NoteSub);
            this.panel1.Controls.Add(this.NoteRichTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 547);
            this.panel1.TabIndex = 4;
            // 
            // NoteSub
            // 
            this.NoteSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoteSub.Font = new System.Drawing.Font("Verdana", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoteSub.Location = new System.Drawing.Point(0, 0);
            this.NoteSub.Multiline = true;
            this.NoteSub.Name = "NoteSub";
            this.NoteSub.Size = new System.Drawing.Size(792, 76);
            this.NoteSub.TabIndex = 1;
            this.NoteSub.TextChanged += new System.EventHandler(this.NoteSub_TextChanged_1);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 764);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "NoteForm";
            this.Text = "NoteForm";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox NoteRichTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Bold;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NoteSub;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowercaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uppercaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentenceCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitalizeEachWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleCaseToolStripMenuItem;
    }
}