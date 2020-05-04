namespace Maintenance
{
    partial class MainMenu
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
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.courseTitlesLabel = new System.Windows.Forms.Label();
            this.courseInfoButton = new System.Windows.Forms.Button();
            this.mainErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.attendersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainErrorProvider)).BeginInit();
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
            // courseInfoButton
            // 
            this.courseInfoButton.Location = new System.Drawing.Point(382, 42);
            this.courseInfoButton.Name = "courseInfoButton";
            this.courseInfoButton.Size = new System.Drawing.Size(195, 47);
            this.courseInfoButton.TabIndex = 3;
            this.courseInfoButton.Text = "Course info";
            this.courseInfoButton.UseVisualStyleBackColor = true;
            this.courseInfoButton.Click += new System.EventHandler(this.courseInfoButton_Click);
            // 
            // mainErrorProvider
            // 
            this.mainErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.mainErrorProvider.ContainerControl = this;
            // 
            // attendersButton
            // 
            this.attendersButton.Location = new System.Drawing.Point(382, 95);
            this.attendersButton.Name = "attendersButton";
            this.attendersButton.Size = new System.Drawing.Size(195, 47);
            this.attendersButton.TabIndex = 4;
            this.attendersButton.Text = "Attenders";
            this.attendersButton.UseVisualStyleBackColor = true;
            this.attendersButton.Click += new System.EventHandler(this.attendersButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.attendersButton);
            this.Controls.Add(this.courseInfoButton);
            this.Controls.Add(this.courseTitlesLabel);
            this.Controls.Add(this.coursesListBox);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox coursesListBox;
        private System.Windows.Forms.Label courseTitlesLabel;
        private System.Windows.Forms.Button courseInfoButton;
        private System.Windows.Forms.ErrorProvider mainErrorProvider;
        private System.Windows.Forms.Button attendersButton;
    }
}

