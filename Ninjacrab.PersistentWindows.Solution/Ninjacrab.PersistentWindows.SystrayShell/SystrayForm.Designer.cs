﻿namespace Ninjacrab.PersistentWindows.SystrayShell
{
    partial class SystrayForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystrayForm));
      this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenuStripSysTray = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.diagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.enabledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStripSysTray.SuspendLayout();
      this.SuspendLayout();
      // 
      // notifyIconMain
      // 
      this.notifyIconMain.ContextMenuStrip = this.contextMenuStripSysTray;
      this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
      this.notifyIconMain.Text = "Persistent Windows";
      this.notifyIconMain.Visible = true;
      // 
      // contextMenuStripSysTray
      // 
      this.contextMenuStripSysTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enabledToolStripMenuItem,
            this.toolStripMenuItem1,
            this.diagnosticsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
      this.contextMenuStripSysTray.Name = "contextMenuStripSysTray";
      this.contextMenuStripSysTray.Size = new System.Drawing.Size(153, 104);
      // 
      // diagnosticsToolStripMenuItem
      // 
      this.diagnosticsToolStripMenuItem.Name = "diagnosticsToolStripMenuItem";
      this.diagnosticsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.diagnosticsToolStripMenuItem.Text = "&Diagnostics";
      this.diagnosticsToolStripMenuItem.Click += new System.EventHandler(this.DiagnosticsToolStripMenuItemClickHandler);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitToolStripMenuItem.Text = "&Shutdown";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClickHandler);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
      // 
      // enabledToolStripMenuItem
      // 
      this.enabledToolStripMenuItem.Checked = true;
      this.enabledToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.enabledToolStripMenuItem.Name = "enabledToolStripMenuItem";
      this.enabledToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.enabledToolStripMenuItem.Text = "&Enabled";
      this.enabledToolStripMenuItem.Click += new System.EventHandler(this.enabledToolStripMenuItem_Click);
      // 
      // SystrayForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "SystrayForm";
      this.Text = "Persistent Windows";
      this.contextMenuStripSysTray.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSysTray;
        private System.Windows.Forms.ToolStripMenuItem diagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem enabledToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
  }
}

