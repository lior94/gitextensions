﻿namespace GitUI.CommandsDialogs.BrowseDialog
{
    partial class FormOpenDirectory
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
            this.label1 = new System.Windows.Forms.Label();
            this._NO_TRANSLATE_Directory = new System.Windows.Forms.ComboBox();
            this.Load = new System.Windows.Forms.Button();
            this.folderBrowserButton1 = new GitUI.UserControls.FolderBrowserButton();
            this.folderGoUpbutton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory";
            // 
            // _NO_TRANSLATE_Directory
            // 
            this._NO_TRANSLATE_Directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._NO_TRANSLATE_Directory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._NO_TRANSLATE_Directory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this._NO_TRANSLATE_Directory.FormattingEnabled = true;
            this._NO_TRANSLATE_Directory.Location = new System.Drawing.Point(85, 10);
            this._NO_TRANSLATE_Directory.Name = "_NO_TRANSLATE_Directory";
            this._NO_TRANSLATE_Directory.Size = new System.Drawing.Size(360, 21);
            this._NO_TRANSLATE_Directory.TabIndex = 1;
            this._NO_TRANSLATE_Directory.TextChanged += new System.EventHandler(this._NO_TRANSLATE_Directory_TextChanged);
            this._NO_TRANSLATE_Directory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DirectoryKeyPress);
            // 
            // Load
            // 
            this.Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load.Image = global::GitUI.Properties.Resources.IconRepoOpen;
            this.Load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Load.Location = new System.Drawing.Point(448, 45);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(144, 25);
            this.Load.TabIndex = 3;
            this.Load.Text = "Open";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.LoadClick);
            // 
            // folderBrowserButton1
            // 
            this.folderBrowserButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderBrowserButton1.AutoSize = true;
            this.folderBrowserButton1.Location = new System.Drawing.Point(477, 10);
            this.folderBrowserButton1.Name = "folderBrowserButton1";
            this.folderBrowserButton1.PathShowingControl = this._NO_TRANSLATE_Directory;
            this.folderBrowserButton1.Size = new System.Drawing.Size(115, 25);
            this.folderBrowserButton1.TabIndex = 4;
            // 
            // folderGoUpbutton
            // 
            this.folderGoUpbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderGoUpbutton.Image = global::GitUI.Properties.Resources.levelUp;
            this.folderGoUpbutton.Location = new System.Drawing.Point(448, 10);
            this.folderGoUpbutton.Name = "folderGoUpbutton";
            this.folderGoUpbutton.Size = new System.Drawing.Size(26, 25);
            this.folderGoUpbutton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.folderGoUpbutton, "Go to parent directory...");
            this.folderGoUpbutton.UseVisualStyleBackColor = true;
            this.folderGoUpbutton.Click += new System.EventHandler(this.folderGoUpbutton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // FormOpenDirectory
            // 
            this.AcceptButton = this.Load;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(595, 81);
            this.Controls.Add(this.folderGoUpbutton);
            this.Controls.Add(this.folderBrowserButton1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this._NO_TRANSLATE_Directory);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 120);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 120);
            this.Name = "FormOpenDirectory";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open local repository";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _NO_TRANSLATE_Directory;
        private new System.Windows.Forms.Button Load;
        private UserControls.FolderBrowserButton folderBrowserButton1;
        private System.Windows.Forms.Button folderGoUpbutton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}