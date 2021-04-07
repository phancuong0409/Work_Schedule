
namespace Work_Schedule
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.ckbNotify = new System.Windows.Forms.CheckBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.btnMonday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnThursday = new System.Windows.Forms.Button();
            this.btnSaturrday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(287, 27);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(237, 20);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // ckbNotify
            // 
            this.ckbNotify.AutoSize = true;
            this.ckbNotify.BackColor = System.Drawing.Color.Transparent;
            this.ckbNotify.Location = new System.Drawing.Point(161, 27);
            this.ckbNotify.Name = "ckbNotify";
            this.ckbNotify.Size = new System.Drawing.Size(79, 17);
            this.ckbNotify.TabIndex = 1;
            this.ckbNotify.Text = "Notification";
            this.ckbNotify.UseVisualStyleBackColor = false;
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(659, 27);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(68, 22);
            this.btnToday.TabIndex = 3;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.BackColor = System.Drawing.Color.Transparent;
            this.pnlMatrix.Location = new System.Drawing.Point(109, 136);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(561, 284);
            this.pnlMatrix.TabIndex = 4;
            // 
            // btnMonday
            // 
            this.btnMonday.BackColor = System.Drawing.Color.White;
            this.btnMonday.Location = new System.Drawing.Point(109, 70);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(75, 39);
            this.btnMonday.TabIndex = 5;
            this.btnMonday.Text = "Monday";
            this.btnMonday.UseVisualStyleBackColor = false;
            // 
            // btnTuesday
            // 
            this.btnTuesday.BackColor = System.Drawing.Color.White;
            this.btnTuesday.Location = new System.Drawing.Point(190, 70);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(75, 39);
            this.btnTuesday.TabIndex = 5;
            this.btnTuesday.Text = "Tuesday";
            this.btnTuesday.UseVisualStyleBackColor = false;
            // 
            // btnWednesday
            // 
            this.btnWednesday.BackColor = System.Drawing.Color.White;
            this.btnWednesday.Location = new System.Drawing.Point(271, 70);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(75, 39);
            this.btnWednesday.TabIndex = 5;
            this.btnWednesday.Text = "Wednesday";
            this.btnWednesday.UseVisualStyleBackColor = false;
            // 
            // btnThursday
            // 
            this.btnThursday.BackColor = System.Drawing.Color.White;
            this.btnThursday.Location = new System.Drawing.Point(352, 70);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(75, 39);
            this.btnThursday.TabIndex = 5;
            this.btnThursday.Text = "Thursday";
            this.btnThursday.UseVisualStyleBackColor = false;
            // 
            // btnSaturrday
            // 
            this.btnSaturrday.BackColor = System.Drawing.Color.White;
            this.btnSaturrday.Location = new System.Drawing.Point(514, 70);
            this.btnSaturrday.Name = "btnSaturrday";
            this.btnSaturrday.Size = new System.Drawing.Size(75, 39);
            this.btnSaturrday.TabIndex = 5;
            this.btnSaturrday.Text = "Saturday";
            this.btnSaturrday.UseVisualStyleBackColor = false;
            // 
            // btnFriday
            // 
            this.btnFriday.BackColor = System.Drawing.Color.White;
            this.btnFriday.Location = new System.Drawing.Point(433, 70);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(75, 39);
            this.btnFriday.TabIndex = 5;
            this.btnFriday.Text = "Friday";
            this.btnFriday.UseVisualStyleBackColor = false;
            // 
            // btnSunday
            // 
            this.btnSunday.BackColor = System.Drawing.Color.White;
            this.btnSunday.Location = new System.Drawing.Point(595, 70);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(75, 39);
            this.btnSunday.TabIndex = 5;
            this.btnSunday.Text = "Sunday";
            this.btnSunday.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(16, 117);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 31);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Pre month";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(689, 117);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 31);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next month";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tmNotify
            // 
            this.tmNotify.Enabled = true;
            this.tmNotify.Interval = 60000;
            this.tmNotify.Tick += new System.EventHandler(this.tmNotify_Tick);
            // 
            // Notify
            // 
            this.Notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "Work Schedule";
            this.Notify.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Work_Schedule.Properties.Resources.summer_beach;
            this.ClientSize = new System.Drawing.Size(779, 429);
            this.Controls.Add(this.btnSunday);
            this.Controls.Add(this.btnFriday);
            this.Controls.Add(this.btnThursday);
            this.Controls.Add(this.btnSaturrday);
            this.Controls.Add(this.btnTuesday);
            this.Controls.Add(this.btnWednesday);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnMonday);
            this.Controls.Add(this.pnlMatrix);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.ckbNotify);
            this.Controls.Add(this.dtpkDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Schedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.CheckBox ckbNotify;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnThursday;
        private System.Windows.Forms.Button btnSaturrday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer tmNotify;
        private System.Windows.Forms.NotifyIcon Notify;
    }
}

