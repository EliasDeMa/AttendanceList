namespace Maintenance.Forms.MenuForms
{
    partial class DaysOffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaysOffForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.daysOffLabel = new System.Windows.Forms.Label();
            this.daysOffListBox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addDayOffButton = new System.Windows.Forms.Button();
            this.nonCourseDayErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nonCourseDayErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.daysOffLabel);
            this.splitContainer1.Panel1.Controls.Add(this.daysOffListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.deleteButton);
            this.splitContainer1.Panel2.Controls.Add(this.addDayOffButton);
            this.splitContainer1.Size = new System.Drawing.Size(495, 405);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 4;
            // 
            // daysOffLabel
            // 
            this.daysOffLabel.AutoSize = true;
            this.daysOffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysOffLabel.Location = new System.Drawing.Point(5, 14);
            this.daysOffLabel.Name = "daysOffLabel";
            this.daysOffLabel.Size = new System.Drawing.Size(157, 39);
            this.daysOffLabel.TabIndex = 1;
            this.daysOffLabel.Text = "Days Off:";
            // 
            // daysOffListBox
            // 
            this.daysOffListBox.FormattingEnabled = true;
            this.daysOffListBox.Location = new System.Drawing.Point(12, 56);
            this.daysOffListBox.Name = "daysOffListBox";
            this.daysOffListBox.Size = new System.Drawing.Size(220, 303);
            this.daysOffListBox.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(22, 125);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 49);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addDayOffButton
            // 
            this.addDayOffButton.Location = new System.Drawing.Point(22, 56);
            this.addDayOffButton.Name = "addDayOffButton";
            this.addDayOffButton.Size = new System.Drawing.Size(132, 49);
            this.addDayOffButton.TabIndex = 2;
            this.addDayOffButton.Text = "Add";
            this.addDayOffButton.UseVisualStyleBackColor = true;
            this.addDayOffButton.Click += new System.EventHandler(this.addDayOffButton_Click);
            // 
            // nonCourseDayErrorProvider
            // 
            this.nonCourseDayErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.nonCourseDayErrorProvider.ContainerControl = this;
            // 
            // DaysOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 429);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DaysOffForm";
            this.Text = "DaysOffForm";
            this.Load += new System.EventHandler(this.DaysOffForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nonCourseDayErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label daysOffLabel;
        private System.Windows.Forms.ListBox daysOffListBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addDayOffButton;
        private System.Windows.Forms.ErrorProvider nonCourseDayErrorProvider;
    }
}