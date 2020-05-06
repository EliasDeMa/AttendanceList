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
            this.dateFilterTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationsListBox
            // 
            this.registrationsListBox.FormattingEnabled = true;
            this.registrationsListBox.Location = new System.Drawing.Point(12, 69);
            this.registrationsListBox.Name = "registrationsListBox";
            this.registrationsListBox.Size = new System.Drawing.Size(245, 355);
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
            // dateFilterTimePicker
            // 
            this.dateFilterTimePicker.Location = new System.Drawing.Point(62, 43);
            this.dateFilterTimePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateFilterTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateFilterTimePicker.Name = "dateFilterTimePicker";
            this.dateFilterTimePicker.ShowCheckBox = true;
            this.dateFilterTimePicker.Size = new System.Drawing.Size(195, 20);
            this.dateFilterTimePicker.TabIndex = 2;
            this.dateFilterTimePicker.ValueChanged += new System.EventHandler(this.dateFilterTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter:";
            // 
            // RegistrationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFilterTimePicker);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.registrationsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationsForm";
            this.Load += new System.EventHandler(this.RegistrationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox registrationsListBox;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.DateTimePicker dateFilterTimePicker;
        private System.Windows.Forms.Label label1;
    }
}