namespace BadgingSystem
{
    partial class BadgingForm
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
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.timeShowTimer = new System.Windows.Forms.Timer(this.components);
            this.coursesComboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ccTextBox = new System.Windows.Forms.TextBox();
            this.oeNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressRefTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.trainingInstitutionTextBox = new System.Windows.Forms.TextBox();
            this.courseCodeLabel = new System.Windows.Forms.Label();
            this.oeNumberLabel = new System.Windows.Forms.Label();
            this.refAddressLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.trainingInstitutionLabel = new System.Windows.Forms.Label();
            this.attendersLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeTextBox
            // 
            this.timeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeTextBox.Enabled = false;
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextBox.Location = new System.Drawing.Point(807, 5);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(212, 24);
            this.timeTextBox.TabIndex = 0;
            this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timeShowTimer
            // 
            this.timeShowTimer.Enabled = true;
            this.timeShowTimer.Interval = 1000;
            this.timeShowTimer.Tick += new System.EventHandler(this.timeShowTimer_Tick);
            // 
            // coursesComboBox
            // 
            this.coursesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coursesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesComboBox.FormattingEnabled = true;
            this.coursesComboBox.Location = new System.Drawing.Point(128, 3);
            this.coursesComboBox.Name = "coursesComboBox";
            this.coursesComboBox.Size = new System.Drawing.Size(243, 26);
            this.coursesComboBox.TabIndex = 1;
            this.coursesComboBox.SelectedIndexChanged += new System.EventHandler(this.coursesComboBox_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.coursesComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.timeTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ccTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.oeNumberTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.addressRefTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.addressTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.contactTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.courseTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.trainingInstitutionTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.courseCodeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.oeNumberLabel);
            this.splitContainer1.Panel2.Controls.Add(this.refAddressLabel);
            this.splitContainer1.Panel2.Controls.Add(this.addressLabel);
            this.splitContainer1.Panel2.Controls.Add(this.contactLabel);
            this.splitContainer1.Panel2.Controls.Add(this.courseLabel);
            this.splitContainer1.Panel2.Controls.Add(this.trainingInstitutionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.attendersLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1026, 575);
            this.splitContainer1.SplitterDistance = 38;
            this.splitContainer1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(751, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time:";
            // 
            // ccTextBox
            // 
            this.ccTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ccTextBox.Enabled = false;
            this.ccTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccTextBox.Location = new System.Drawing.Point(728, 79);
            this.ccTextBox.Name = "ccTextBox";
            this.ccTextBox.Size = new System.Drawing.Size(295, 23);
            this.ccTextBox.TabIndex = 18;
            this.ccTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // oeNumberTextBox
            // 
            this.oeNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oeNumberTextBox.Enabled = false;
            this.oeNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oeNumberTextBox.Location = new System.Drawing.Point(728, 45);
            this.oeNumberTextBox.Name = "oeNumberTextBox";
            this.oeNumberTextBox.Size = new System.Drawing.Size(295, 23);
            this.oeNumberTextBox.TabIndex = 17;
            this.oeNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addressRefTextBox
            // 
            this.addressRefTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressRefTextBox.Enabled = false;
            this.addressRefTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressRefTextBox.Location = new System.Drawing.Point(728, 11);
            this.addressRefTextBox.Name = "addressRefTextBox";
            this.addressRefTextBox.Size = new System.Drawing.Size(295, 23);
            this.addressRefTextBox.TabIndex = 16;
            this.addressRefTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Enabled = false;
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(211, 117);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(295, 23);
            this.addressTextBox.TabIndex = 15;
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Enabled = false;
            this.contactTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTextBox.Location = new System.Drawing.Point(211, 79);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(295, 23);
            this.contactTextBox.TabIndex = 14;
            this.contactTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // courseTextBox
            // 
            this.courseTextBox.Enabled = false;
            this.courseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTextBox.Location = new System.Drawing.Point(211, 44);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(295, 23);
            this.courseTextBox.TabIndex = 13;
            this.courseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trainingInstitutionTextBox
            // 
            this.trainingInstitutionTextBox.Enabled = false;
            this.trainingInstitutionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingInstitutionTextBox.Location = new System.Drawing.Point(211, 11);
            this.trainingInstitutionTextBox.Name = "trainingInstitutionTextBox";
            this.trainingInstitutionTextBox.Size = new System.Drawing.Size(295, 23);
            this.trainingInstitutionTextBox.TabIndex = 12;
            this.trainingInstitutionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // courseCodeLabel
            // 
            this.courseCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.courseCodeLabel.AutoSize = true;
            this.courseCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCodeLabel.Location = new System.Drawing.Point(529, 79);
            this.courseCodeLabel.Name = "courseCodeLabel";
            this.courseCodeLabel.Size = new System.Drawing.Size(142, 25);
            this.courseCodeLabel.TabIndex = 11;
            this.courseCodeLabel.Text = "Course code:";
            // 
            // oeNumberLabel
            // 
            this.oeNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oeNumberLabel.AutoSize = true;
            this.oeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oeNumberLabel.Location = new System.Drawing.Point(529, 45);
            this.oeNumberLabel.Name = "oeNumberLabel";
            this.oeNumberLabel.Size = new System.Drawing.Size(133, 25);
            this.oeNumberLabel.TabIndex = 10;
            this.oeNumberLabel.Text = "OE-Number:";
            // 
            // refAddressLabel
            // 
            this.refAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refAddressLabel.AutoSize = true;
            this.refAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refAddressLabel.Location = new System.Drawing.Point(529, 11);
            this.refAddressLabel.Name = "refAddressLabel";
            this.refAddressLabel.Size = new System.Drawing.Size(196, 25);
            this.refAddressLabel.TabIndex = 9;
            this.refAddressLabel.Text = "Address reference:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(3, 117);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(99, 25);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(3, 79);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(94, 25);
            this.contactLabel.TabIndex = 7;
            this.contactLabel.Text = "Contact:";
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.Location = new System.Drawing.Point(3, 45);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(89, 25);
            this.courseLabel.TabIndex = 6;
            this.courseLabel.Text = "Course:";
            // 
            // trainingInstitutionLabel
            // 
            this.trainingInstitutionLabel.AutoSize = true;
            this.trainingInstitutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingInstitutionLabel.Location = new System.Drawing.Point(3, 11);
            this.trainingInstitutionLabel.Name = "trainingInstitutionLabel";
            this.trainingInstitutionLabel.Size = new System.Drawing.Size(196, 25);
            this.trainingInstitutionLabel.TabIndex = 5;
            this.trainingInstitutionLabel.Text = "Training institution:";
            // 
            // attendersLayoutPanel
            // 
            this.attendersLayoutPanel.Location = new System.Drawing.Point(3, 159);
            this.attendersLayoutPanel.Name = "attendersLayoutPanel";
            this.attendersLayoutPanel.Size = new System.Drawing.Size(1056, 371);
            this.attendersLayoutPanel.TabIndex = 0;
            // 
            // BadgingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 599);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BadgingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Badging System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Timer timeShowTimer;
        private System.Windows.Forms.ComboBox coursesComboBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel attendersLayoutPanel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label trainingInstitutionLabel;
        private System.Windows.Forms.Label courseCodeLabel;
        private System.Windows.Forms.Label oeNumberLabel;
        private System.Windows.Forms.Label refAddressLabel;
        private System.Windows.Forms.TextBox ccTextBox;
        private System.Windows.Forms.TextBox oeNumberTextBox;
        private System.Windows.Forms.TextBox addressRefTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.TextBox trainingInstitutionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

