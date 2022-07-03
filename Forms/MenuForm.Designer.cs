
namespace Sticky_Notes.Forms
{
    partial class MenuForm
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
            this.NoteslistView = new System.Windows.Forms.ListView();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewNoteButton = new System.Windows.Forms.ToolStripButton();
            this.SettingButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteslistView
            // 
            this.NoteslistView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NoteslistView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteslistView.HideSelection = false;
            this.NoteslistView.Location = new System.Drawing.Point(32, 200);
            this.NoteslistView.Name = "NoteslistView";
            this.NoteslistView.Size = new System.Drawing.Size(907, 798);
            this.NoteslistView.TabIndex = 0;
            this.NoteslistView.UseCompatibleStateImageBehavior = false;
            this.NoteslistView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NoteslistView_MouseDoubleClick);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(32, 111);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(907, 47);
            this.SearchTxtBox.TabIndex = 1;
            this.SearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewNoteButton,
            this.SettingButton,
            this.DeleteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(976, 51);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewNoteButton.Image = global::Sticky_Notes.Properties.Resources._4115237_add_plus_icon;
            this.NewNoteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(58, 44);
            this.NewNoteButton.Text = "New Note";
            this.NewNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingButton.Image = global::Sticky_Notes.Properties.Resources._2849830_multimedia_options_setting_settings_gear_icon;
            this.SettingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(58, 44);
            this.SettingButton.Text = "toolStripButton2";
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = global::Sticky_Notes.Properties.Resources._185090_delete_garbage_icon;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(58, 44);
            this.DeleteButton.Text = "DeleteButton";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 1024);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.NoteslistView);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewNoteButton;
        private System.Windows.Forms.ToolStripButton SettingButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        public System.Windows.Forms.ListView NoteslistView;
    }
}