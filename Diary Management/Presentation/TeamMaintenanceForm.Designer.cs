namespace Diary_Management.Presentation
{
    partial class TeamMaintenanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.teamIdLabel = new System.Windows.Forms.Label();
            this.teamIdField = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameField = new System.Windows.Forms.TextBox();
            this.workingHoursLabel = new System.Windows.Forms.Label();
            this.workingHoursField = new System.Windows.Forms.ComboBox();
            this.teamMembersLabel = new System.Windows.Forms.Label();
            this.memberGrid = new System.Windows.Forms.DataGridView();
            this.teamMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.memberGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // teamIdLabel
            // 
            this.teamIdLabel.AutoSize = true;
            this.teamIdLabel.Location = new System.Drawing.Point(32, 23);
            this.teamIdLabel.Name = "teamIdLabel";
            this.teamIdLabel.Size = new System.Drawing.Size(47, 13);
            this.teamIdLabel.TabIndex = 0;
            this.teamIdLabel.Text = "Identifier";
            // 
            // teamIdField
            // 
            this.teamIdField.Location = new System.Drawing.Point(32, 40);
            this.teamIdField.Name = "teamIdField";
            this.teamIdField.Size = new System.Drawing.Size(100, 20);
            this.teamIdField.TabIndex = 1;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(184, 23);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(35, 13);
            this.teamNameLabel.TabIndex = 2;
            this.teamNameLabel.Text = "Name";
            // 
            // teamNameField
            // 
            this.teamNameField.Location = new System.Drawing.Point(184, 39);
            this.teamNameField.Name = "teamNameField";
            this.teamNameField.Size = new System.Drawing.Size(247, 20);
            this.teamNameField.TabIndex = 3;
            // 
            // workingHoursLabel
            // 
            this.workingHoursLabel.AutoSize = true;
            this.workingHoursLabel.Location = new System.Drawing.Point(184, 74);
            this.workingHoursLabel.Name = "workingHoursLabel";
            this.workingHoursLabel.Size = new System.Drawing.Size(76, 13);
            this.workingHoursLabel.TabIndex = 4;
            this.workingHoursLabel.Text = "Working hours";
            // 
            // workingHoursField
            // 
            this.workingHoursField.FormattingEnabled = true;
            this.workingHoursField.Location = new System.Drawing.Point(295, 70);
            this.workingHoursField.Name = "workingHoursField";
            this.workingHoursField.Size = new System.Drawing.Size(136, 21);
            this.workingHoursField.TabIndex = 5;
            // 
            // teamMembersLabel
            // 
            this.teamMembersLabel.AutoSize = true;
            this.teamMembersLabel.Location = new System.Drawing.Point(32, 100);
            this.teamMembersLabel.Name = "teamMembersLabel";
            this.teamMembersLabel.Size = new System.Drawing.Size(50, 13);
            this.teamMembersLabel.TabIndex = 6;
            this.teamMembersLabel.Text = "Members";
            // 
            // memberGrid
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.memberGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.memberGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memberGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamMember,
            this.role});
            this.memberGrid.Location = new System.Drawing.Point(32, 120);
            this.memberGrid.Name = "memberGrid";
            this.memberGrid.Size = new System.Drawing.Size(399, 162);
            this.memberGrid.TabIndex = 7;
            // 
            // teamMember
            // 
            this.teamMember.HeaderText = "Member";
            this.teamMember.Name = "teamMember";
            // 
            // role
            // 
            this.role.FillWeight = 60F;
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(457, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(457, 120);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(457, 150);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(457, 227);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(457, 259);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // TeamMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 303);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.memberGrid);
            this.Controls.Add(this.teamMembersLabel);
            this.Controls.Add(this.workingHoursField);
            this.Controls.Add(this.workingHoursLabel);
            this.Controls.Add(this.teamNameField);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.teamIdField);
            this.Controls.Add(this.teamIdLabel);
            this.Name = "TeamMaintenanceForm";
            this.Text = "Team:";
            this.Load += new System.EventHandler(this.TeamMaintenanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teamIdLabel;
        private System.Windows.Forms.TextBox teamIdField;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox teamNameField;
        private System.Windows.Forms.Label workingHoursLabel;
        private System.Windows.Forms.ComboBox workingHoursField;
        private System.Windows.Forms.Label teamMembersLabel;
        private System.Windows.Forms.DataGridView memberGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}