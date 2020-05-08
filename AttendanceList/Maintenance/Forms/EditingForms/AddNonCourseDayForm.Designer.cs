namespace Maintenance.Forms.EditingForms
{
    partial class AddNonCourseDayForm
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
            this.dayOffMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.morningCheckBox = new System.Windows.Forms.CheckBox();
            this.afternoonCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dayOffErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dayOffErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dayOffMonthCalendar
            // 
            this.dayOffMonthCalendar.Location = new System.Drawing.Point(18, 12);
            this.dayOffMonthCalendar.Name = "dayOffMonthCalendar";
            this.dayOffMonthCalendar.TabIndex = 0;
            // 
            // morningCheckBox
            // 
            this.morningCheckBox.AutoSize = true;
            this.morningCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morningCheckBox.Location = new System.Drawing.Point(257, 12);
            this.morningCheckBox.Name = "morningCheckBox";
            this.morningCheckBox.Size = new System.Drawing.Size(78, 21);
            this.morningCheckBox.TabIndex = 1;
            this.morningCheckBox.Text = "Morning";
            this.morningCheckBox.UseVisualStyleBackColor = true;
            // 
            // afternoonCheckBox
            // 
            this.afternoonCheckBox.AutoSize = true;
            this.afternoonCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afternoonCheckBox.Location = new System.Drawing.Point(257, 39);
            this.afternoonCheckBox.Name = "afternoonCheckBox";
            this.afternoonCheckBox.Size = new System.Drawing.Size(89, 21);
            this.afternoonCheckBox.TabIndex = 2;
            this.afternoonCheckBox.Text = "Afternoon";
            this.afternoonCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dayOffErrorProvider
            // 
            this.dayOffErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.dayOffErrorProvider.ContainerControl = this;
            // 
            // AddNonCourseDayForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 188);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.afternoonCheckBox);
            this.Controls.Add(this.morningCheckBox);
            this.Controls.Add(this.dayOffMonthCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNonCourseDayForm";
            this.Text = "Add day off";
            ((System.ComponentModel.ISupportInitialize)(this.dayOffErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar dayOffMonthCalendar;
        private System.Windows.Forms.CheckBox morningCheckBox;
        private System.Windows.Forms.CheckBox afternoonCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider dayOffErrorProvider;
    }
}