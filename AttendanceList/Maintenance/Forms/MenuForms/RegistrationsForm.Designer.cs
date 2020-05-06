namespace Maintenance.Forms.MenuForms
{
    partial class RegistrationsForm
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
            this.registrationsListBox = new System.Windows.Forms.ListBox();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationsListBox
            // 
            this.registrationsListBox.FormattingEnabled = true;
            this.registrationsListBox.Location = new System.Drawing.Point(12, 43);
            this.registrationsListBox.Name = "registrationsListBox";
            this.registrationsListBox.Size = new System.Drawing.Size(270, 381);
            this.registrationsListBox.TabIndex = 0;
            this.registrationsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.registrationsListBox_MouseDoubleClick);
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.registrationLabel.Location = new System.Drawing.Point(6, 9);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(182, 31);
            this.registrationLabel.TabIndex = 1;
            this.registrationLabel.Text = "Registrations:";
            // 
            // RegistrationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.registrationsListBox);
            this.Name = "RegistrationsForm";
            this.Text = "RegistrationsForm";
            this.Load += new System.EventHandler(this.RegistrationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox registrationsListBox;
        private System.Windows.Forms.Label registrationLabel;
    }
}