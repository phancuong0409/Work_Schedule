
namespace Work_Schedule
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ckbDone = new System.Windows.Forms.CheckBox();
            this.txbJob = new System.Windows.Forms.TextBox();
            this.nmFromHours = new System.Windows.Forms.NumericUpDown();
            this.nmFromMinute = new System.Windows.Forms.NumericUpDown();
            this.nmToHours = new System.Windows.Forms.NumericUpDown();
            this.nmToMinute = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbDone
            // 
            this.ckbDone.AutoSize = true;
            this.ckbDone.Location = new System.Drawing.Point(3, 7);
            this.ckbDone.Name = "ckbDone";
            this.ckbDone.Size = new System.Drawing.Size(15, 14);
            this.ckbDone.TabIndex = 0;
            this.ckbDone.UseVisualStyleBackColor = true;
            this.ckbDone.CheckedChanged += new System.EventHandler(this.ckbDone_CheckedChanged);
            // 
            // txbJob
            // 
            this.txbJob.Location = new System.Drawing.Point(23, 4);
            this.txbJob.Name = "txbJob";
            this.txbJob.Size = new System.Drawing.Size(190, 20);
            this.txbJob.TabIndex = 1;
            // 
            // nmFromHours
            // 
            this.nmFromHours.Location = new System.Drawing.Point(230, 4);
            this.nmFromHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nmFromHours.Name = "nmFromHours";
            this.nmFromHours.Size = new System.Drawing.Size(44, 20);
            this.nmFromHours.TabIndex = 2;
            this.nmFromHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmFromMinute
            // 
            this.nmFromMinute.Location = new System.Drawing.Point(275, 4);
            this.nmFromMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nmFromMinute.Name = "nmFromMinute";
            this.nmFromMinute.Size = new System.Drawing.Size(44, 20);
            this.nmFromMinute.TabIndex = 2;
            this.nmFromMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmToHours
            // 
            this.nmToHours.Location = new System.Drawing.Point(362, 4);
            this.nmToHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nmToHours.Name = "nmToHours";
            this.nmToHours.Size = new System.Drawing.Size(44, 20);
            this.nmToHours.TabIndex = 2;
            this.nmToHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmToMinute
            // 
            this.nmToMinute.Location = new System.Drawing.Point(407, 4);
            this.nmToMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nmToMinute.Name = "nmToMinute";
            this.nmToMinute.Size = new System.Drawing.Size(44, 20);
            this.nmToMinute.TabIndex = 2;
            this.nmToMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "To";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(457, 3);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(156, 21);
            this.cbStatus.TabIndex = 4;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(626, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 24);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmToMinute);
            this.Controls.Add(this.nmFromMinute);
            this.Controls.Add(this.nmToHours);
            this.Controls.Add(this.nmFromHours);
            this.Controls.Add(this.txbJob);
            this.Controls.Add(this.ckbDone);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(683, 29);
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbDone;
        private System.Windows.Forms.TextBox txbJob;
        private System.Windows.Forms.NumericUpDown nmFromHours;
        private System.Windows.Forms.NumericUpDown nmFromMinute;
        private System.Windows.Forms.NumericUpDown nmToHours;
        private System.Windows.Forms.NumericUpDown nmToMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnDelete;
    }
}
