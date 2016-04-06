namespace IKRPGCharGen
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.HelpButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileButton,
            this.AboutButton,
            this.HelpButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(838, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileButton
            // 
            this.FileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem,
            this.loadCharacterToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.FileButton.Image = ((System.Drawing.Image)(resources.GetObject("FileButton.Image")));
            this.FileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(56, 29);
            this.FileButton.Text = "File";
            this.FileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.newCharacterToolStripMenuItem.Text = "New Character";
            // 
            // loadCharacterToolStripMenuItem
            // 
            this.loadCharacterToolStripMenuItem.Name = "loadCharacterToolStripMenuItem";
            this.loadCharacterToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.loadCharacterToolStripMenuItem.Text = "Load Character";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(66, 29);
            this.AboutButton.Text = "About";
            this.AboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpButton.Image")));
            this.HelpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(53, 29);
            this.HelpButton.Text = "Help";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IKRPGCharGen.Properties.Resources.bgImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 439);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "IKRPG Char Gen";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileButton;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AboutButton;
        private System.Windows.Forms.ToolStripButton HelpButton;
    }
}

