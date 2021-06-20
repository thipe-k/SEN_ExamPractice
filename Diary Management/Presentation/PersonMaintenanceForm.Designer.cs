namespace Diary_Management.Presentation
{
    partial class PersonMaintenanceForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.otherNamesLabel = new System.Windows.Forms.Label();
            this.otherNamesField = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.suffixField = new System.Windows.Forms.TextBox();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.idNumberField = new System.Windows.Forms.TextBox();
            this.sexGroupBox = new System.Windows.Forms.GroupBox();
            this.maleOption = new System.Windows.Forms.RadioButton();
            this.femaleOption = new System.Windows.Forms.RadioButton();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobField = new System.Windows.Forms.DateTimePicker();
            this.workingHoursLabel = new System.Windows.Forms.Label();
            this.workingHoursField = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.rolesButton = new System.Windows.Forms.Button();
            this.diaryButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleField = new System.Windows.Forms.ComboBox();
            this.sexGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(36, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(36, 63);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameField
            // 
            this.firstNameField.Location = new System.Drawing.Point(127, 59);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(230, 20);
            this.firstNameField.TabIndex = 3;
            // 
            // otherNamesLabel
            // 
            this.otherNamesLabel.AutoSize = true;
            this.otherNamesLabel.Location = new System.Drawing.Point(36, 107);
            this.otherNamesLabel.Name = "otherNamesLabel";
            this.otherNamesLabel.Size = new System.Drawing.Size(69, 13);
            this.otherNamesLabel.TabIndex = 4;
            this.otherNamesLabel.Text = "Other Names";
            // 
            // otherNamesField
            // 
            this.otherNamesField.Location = new System.Drawing.Point(127, 103);
            this.otherNamesField.Name = "otherNamesField";
            this.otherNamesField.Size = new System.Drawing.Size(230, 20);
            this.otherNamesField.TabIndex = 5;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(36, 151);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 6;
            this.surnameLabel.Text = "Surname";
            // 
            // surnameField
            // 
            this.surnameField.Location = new System.Drawing.Point(127, 147);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(230, 20);
            this.surnameField.TabIndex = 7;
            // 
            // suffixLabel
            // 
            this.suffixLabel.AutoSize = true;
            this.suffixLabel.Location = new System.Drawing.Point(36, 195);
            this.suffixLabel.Name = "suffixLabel";
            this.suffixLabel.Size = new System.Drawing.Size(33, 13);
            this.suffixLabel.TabIndex = 8;
            this.suffixLabel.Text = "Suffix";
            // 
            // suffixField
            // 
            this.suffixField.Location = new System.Drawing.Point(127, 191);
            this.suffixField.Name = "suffixField";
            this.suffixField.Size = new System.Drawing.Size(120, 20);
            this.suffixField.TabIndex = 9;
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.Location = new System.Drawing.Point(36, 239);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(56, 13);
            this.idNumberLabel.TabIndex = 10;
            this.idNumberLabel.Text = "ID number";
            // 
            // idNumberField
            // 
            this.idNumberField.Location = new System.Drawing.Point(127, 240);
            this.idNumberField.Name = "idNumberField";
            this.idNumberField.Size = new System.Drawing.Size(230, 20);
            this.idNumberField.TabIndex = 11;
            // 
            // sexGroupBox
            // 
            this.sexGroupBox.Controls.Add(this.maleOption);
            this.sexGroupBox.Controls.Add(this.femaleOption);
            this.sexGroupBox.Location = new System.Drawing.Point(422, 7);
            this.sexGroupBox.Name = "sexGroupBox";
            this.sexGroupBox.Size = new System.Drawing.Size(176, 35);
            this.sexGroupBox.TabIndex = 12;
            this.sexGroupBox.TabStop = false;
            // 
            // maleOption
            // 
            this.maleOption.AutoSize = true;
            this.maleOption.Location = new System.Drawing.Point(107, 12);
            this.maleOption.Name = "maleOption";
            this.maleOption.Size = new System.Drawing.Size(48, 17);
            this.maleOption.TabIndex = 1;
            this.maleOption.TabStop = true;
            this.maleOption.Text = "Male";
            this.maleOption.UseVisualStyleBackColor = true;
            // 
            // femaleOption
            // 
            this.femaleOption.AutoSize = true;
            this.femaleOption.Location = new System.Drawing.Point(21, 12);
            this.femaleOption.Name = "femaleOption";
            this.femaleOption.Size = new System.Drawing.Size(59, 17);
            this.femaleOption.TabIndex = 0;
            this.femaleOption.TabStop = true;
            this.femaleOption.Text = "Female";
            this.femaleOption.UseVisualStyleBackColor = true;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(422, 88);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(65, 13);
            this.dobLabel.TabIndex = 13;
            this.dobLabel.Text = "Date of birth";
            // 
            // dobField
            // 
            this.dobField.Location = new System.Drawing.Point(422, 103);
            this.dobField.Name = "dobField";
            this.dobField.Size = new System.Drawing.Size(173, 20);
            this.dobField.TabIndex = 14;
            this.dobField.Value = new System.DateTime(2021, 5, 12, 0, 0, 0, 0);
            // 
            // workingHoursLabel
            // 
            this.workingHoursLabel.AutoSize = true;
            this.workingHoursLabel.Location = new System.Drawing.Point(422, 132);
            this.workingHoursLabel.Name = "workingHoursLabel";
            this.workingHoursLabel.Size = new System.Drawing.Size(78, 13);
            this.workingHoursLabel.TabIndex = 15;
            this.workingHoursLabel.Text = "Working Hours";
            // 
            // workingHoursField
            // 
            this.workingHoursField.FormattingEnabled = true;
            this.workingHoursField.Location = new System.Drawing.Point(422, 147);
            this.workingHoursField.Name = "workingHoursField";
            this.workingHoursField.Size = new System.Drawing.Size(176, 21);
            this.workingHoursField.TabIndex = 17;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(282, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // rolesButton
            // 
            this.rolesButton.Location = new System.Drawing.Point(422, 190);
            this.rolesButton.Name = "rolesButton";
            this.rolesButton.Size = new System.Drawing.Size(75, 23);
            this.rolesButton.TabIndex = 19;
            this.rolesButton.Text = "Roles";
            this.rolesButton.UseVisualStyleBackColor = true;
            // 
            // diaryButton
            // 
            this.diaryButton.Location = new System.Drawing.Point(523, 190);
            this.diaryButton.Name = "diaryButton";
            this.diaryButton.Size = new System.Drawing.Size(75, 23);
            this.diaryButton.TabIndex = 20;
            this.diaryButton.Text = "Diary";
            this.diaryButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(422, 239);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 21;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(523, 239);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // titleField
            // 
            this.titleField.FormattingEnabled = true;
            this.titleField.Location = new System.Drawing.Point(127, 14);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(120, 21);
            this.titleField.TabIndex = 23;
            // 
            // PersonMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 278);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.diaryButton);
            this.Controls.Add(this.rolesButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.workingHoursField);
            this.Controls.Add(this.workingHoursLabel);
            this.Controls.Add(this.dobField);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.sexGroupBox);
            this.Controls.Add(this.idNumberField);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.suffixField);
            this.Controls.Add(this.suffixLabel);
            this.Controls.Add(this.surnameField);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.otherNamesField);
            this.Controls.Add(this.otherNamesLabel);
            this.Controls.Add(this.firstNameField);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "PersonMaintenanceForm";
            this.Load += new System.EventHandler(this.PersonMaintenanceForm_Load);
            this.sexGroupBox.ResumeLayout(false);
            this.sexGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.Label otherNamesLabel;
        private System.Windows.Forms.TextBox otherNamesField;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.Label suffixLabel;
        private System.Windows.Forms.TextBox suffixField;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.TextBox idNumberField;
        private System.Windows.Forms.GroupBox sexGroupBox;
        private System.Windows.Forms.RadioButton maleOption;
        private System.Windows.Forms.RadioButton femaleOption;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker dobField;
        private System.Windows.Forms.Label workingHoursLabel;
        private System.Windows.Forms.ComboBox workingHoursField;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button rolesButton;
        private System.Windows.Forms.Button diaryButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox titleField;
    }
}