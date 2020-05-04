namespace Maintenance
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
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.courseTitlesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coursesListBox
            // 
            this.coursesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesListBox.FormattingEnabled = true;
            this.coursesListBox.ItemHeight = 25;
            this.coursesListBox.Location = new System.Drawing.Point(19, 42);
            this.coursesListBox.Name = "coursesListBox";
            this.coursesListBox.Size = new System.Drawing.Size(344, 229);
            this.coursesListBox.TabIndex = 1;
            // 
            // courseTitlesLabel
            // 
            this.courseTitlesLabel.AutoSize = true;
            this.courseTitlesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTitlesLabel.Location = new System.Drawing.Point(13, 8);
            this.courseTitlesLabel.Name = "courseTitlesLabel";
            this.courseTitlesLabel.Size = new System.Drawing.Size(124, 31);
            this.courseTitlesLabel.TabIndex = 2;
            this.courseTitlesLabel.Text = "Courses:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courseTitlesLabel);
            this.Controls.Add(this.coursesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox coursesListBox;
        private System.Windows.Forms.Label courseTitlesLabel;
    }
}

