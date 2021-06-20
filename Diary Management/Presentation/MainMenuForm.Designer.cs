namespace Diary_Management.Presentation
{
    partial class MainMenuForm
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
            this.personsButton = new System.Windows.Forms.Button();
            this.teamsButton = new System.Windows.Forms.Button();
            this.schedulesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personsButton
            // 
            this.personsButton.Location = new System.Drawing.Point(84, 13);
            this.personsButton.Name = "personsButton";
            this.personsButton.Size = new System.Drawing.Size(75, 23);
            this.personsButton.TabIndex = 0;
            this.personsButton.Text = "Persons";
            this.personsButton.UseVisualStyleBackColor = true;
            this.personsButton.Click += new System.EventHandler(this.personsButton_Click);
            // 
            // teamsButton
            // 
            this.teamsButton.Location = new System.Drawing.Point(84, 56);
            this.teamsButton.Name = "teamsButton";
            this.teamsButton.Size = new System.Drawing.Size(75, 23);
            this.teamsButton.TabIndex = 1;
            this.teamsButton.Text = "Teams";
            this.teamsButton.UseVisualStyleBackColor = true;
            this.teamsButton.Click += new System.EventHandler(this.teamsButton_Click);
            // 
            // schedulesButton
            // 
            this.schedulesButton.Location = new System.Drawing.Point(84, 99);
            this.schedulesButton.Name = "schedulesButton";
            this.schedulesButton.Size = new System.Drawing.Size(75, 23);
            this.schedulesButton.TabIndex = 2;
            this.schedulesButton.Text = "Schedules";
            this.schedulesButton.UseVisualStyleBackColor = true;
            this.schedulesButton.Click += new System.EventHandler(this.schedulesButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 140);
            this.Controls.Add(this.schedulesButton);
            this.Controls.Add(this.teamsButton);
            this.Controls.Add(this.personsButton);
            this.Name = "MainMenuForm";
            this.Text = "Diary Maintenance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personsButton;
        private System.Windows.Forms.Button teamsButton;
        private System.Windows.Forms.Button schedulesButton;
    }
}