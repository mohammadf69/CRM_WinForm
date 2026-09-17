namespace CRM.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripMenuItem();
            نمایشToolStripMenuItem = new ToolStripMenuItem();
            ثبتویرایشToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(856, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.DropDownItems.AddRange(new ToolStripItem[] { نمایشToolStripMenuItem, ثبتویرایشToolStripMenuItem });
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(76, 24);
            toolStripTextBox1.Text = "مشتریان";
            // 
            // نمایشToolStripMenuItem
            // 
            نمایشToolStripMenuItem.Name = "نمایشToolStripMenuItem";
            نمایشToolStripMenuItem.Size = new Size(224, 26);
            نمایشToolStripMenuItem.Text = "نمایش";
            نمایشToolStripMenuItem.Click += نمایشToolStripMenuItem_Click;
            // 
            // ثبتویرایشToolStripMenuItem
            // 
            ثبتویرایشToolStripMenuItem.Name = "ثبتویرایشToolStripMenuItem";
            ثبتویرایشToolStripMenuItem.Size = new Size(224, 26);
            ثبتویرایشToolStripMenuItem.Text = "ثبت - ویرایش";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 511);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "داشبورد سیستم";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripTextBox1;
        private ToolStripMenuItem نمایشToolStripMenuItem;
        private ToolStripMenuItem ثبتویرایشToolStripMenuItem;
    }
}
