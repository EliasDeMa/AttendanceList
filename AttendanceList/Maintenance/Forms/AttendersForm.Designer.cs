namespace Maintenance
{
    partial class AttendersForm
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
            this.attendersListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addAttenderButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendersListBox
            // 
            this.attendersListBox.FormattingEnabled = true;
            this.attendersListBox.Location = new System.Drawing.Point(12, 56);
            this.attendersListBox.Name = "attendersListBox";
            this.attendersListBox.Size = new System.Drawing.Size(220, 303);
            this.attendersListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attenders:";
            // 
            // addAttenderButton
            // 
            this.addAttenderButton.Location = new System.Drawing.Point(22, 56);
            this.addAttenderButton.Name = "addAttenderButton";
            this.addAttenderButton.Size = new System.Drawing.Size(132, 49);
            this.addAttenderButton.TabIndex = 2;
            this.addAttenderButton.Text = "Add";
            this.addAttenderButton.UseVisualStyleBackColor = true;
            this.addAttenderButton.Click += new System.EventHandler(this.addAttenderButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 9);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.attendersListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.addAttenderButton);
            this.splitContainer1.Size = new System.Drawing.Size(452, 380);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 3;
            // 
            // AttendersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 388);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AttendersForm";
            this.Text = "AttendersForm";
            this.Load += new System.EventHandler(this.AttendersForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox attendersListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAttenderButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}