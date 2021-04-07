
namespace Work_Schedule
{
    partial class DailyPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyPlan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addJobToolStripMenuItem,
            this.todayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addJobToolStripMenuItem
            // 
            this.addJobToolStripMenuItem.Name = "addJobToolStripMenuItem";
            this.addJobToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.addJobToolStripMenuItem.Text = "Add Job";
            this.addJobToolStripMenuItem.Click += new System.EventHandler(this.addJobToolStripMenuItem_Click);
            // 
            // todayToolStripMenuItem
            // 
            this.todayToolStripMenuItem.Name = "todayToolStripMenuItem";
            this.todayToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.todayToolStripMenuItem.Text = "Today";
            this.todayToolStripMenuItem.Click += new System.EventHandler(this.todayToolStripMenuItem_Click);
            // 
            // pnlJob
            // 
            this.pnlJob.BackColor = System.Drawing.Color.Transparent;
            this.pnlJob.Location = new System.Drawing.Point(12, 71);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(688, 367);
            this.pnlJob.TabIndex = 1;
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(241, 38);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(247, 20);
            this.dtpkDate.TabIndex = 2;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // btnYesterday
            // 
            this.btnYesterday.BackColor = System.Drawing.Color.White;
            this.btnYesterday.Location = new System.Drawing.Point(12, 32);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(76, 26);
            this.btnYesterday.TabIndex = 3;
            this.btnYesterday.Text = "Yesterday";
            this.btnYesterday.UseVisualStyleBackColor = false;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.BackColor = System.Drawing.Color.White;
            this.btnTomorrow.Location = new System.Drawing.Point(624, 38);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(76, 26);
            this.btnTomorrow.TabIndex = 3;
            this.btnTomorrow.Text = "Tomorrow";
            this.btnTomorrow.UseVisualStyleBackColor = false;
            this.btnTomorrow.Click += new System.EventHandler(this.btnTomorrow_Click);
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Work_Schedule.Properties.Resources.pngtree_summer_blue_seaside_cosmetics_psd_layered_master_map_background_material_image_154532;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.btnTomorrow);
            this.Controls.Add(this.btnYesterday);
            this.Controls.Add(this.dtpkDate);
            this.Controls.Add(this.pnlJob);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DailyPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DailyPlan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todayToolStripMenuItem;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.Button btnTomorrow;
    }
}