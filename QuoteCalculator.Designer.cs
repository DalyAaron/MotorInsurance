namespace MotorInsuranceCalculation
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
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.driverDetailsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.occupationLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.occupationList = new System.Windows.Forms.ListBox();
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.addClaimButton = new System.Windows.Forms.Button();
            this.claimDetailsLabel = new System.Windows.Forms.Label();
            this.claimDateLabel = new System.Windows.Forms.Label();
            this.claimDatePicker = new System.Windows.Forms.DateTimePicker();
            this.driversLabel = new System.Windows.Forms.Label();
            this.policyDetailsLabel = new System.Windows.Forms.Label();
            this.driverList = new System.Windows.Forms.ListView();
            this.additionalDriverButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(53, 130);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 30);
            this.startDatePicker.TabIndex = 0;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(48, 98);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(212, 25);
            this.startDateLabel.TabIndex = 1;
            this.startDateLabel.Text = "Start Date of Policy *";
            this.startDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // driverDetailsLabel
            // 
            this.driverDetailsLabel.AutoSize = true;
            this.driverDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverDetailsLabel.Location = new System.Drawing.Point(442, 48);
            this.driverDetailsLabel.Name = "driverDetailsLabel";
            this.driverDetailsLabel.Size = new System.Drawing.Size(171, 29);
            this.driverDetailsLabel.TabIndex = 2;
            this.driverDetailsLabel.Text = "Driver Details";
            this.driverDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(442, 88);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 25);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name *";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // occupationLabel
            // 
            this.occupationLabel.AutoSize = true;
            this.occupationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupationLabel.Location = new System.Drawing.Point(442, 130);
            this.occupationLabel.Name = "occupationLabel";
            this.occupationLabel.Size = new System.Drawing.Size(137, 25);
            this.occupationLabel.TabIndex = 4;
            this.occupationLabel.Text = "Occupation *";
            this.occupationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(442, 170);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(146, 25);
            this.dobLabel.TabIndex = 5;
            this.dobLabel.Text = "Date of Birth *";
            this.dobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dobPicker
            // 
            this.dobPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Location = new System.Drawing.Point(594, 170);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(200, 30);
            this.dobPicker.TabIndex = 6;
            // 
            // occupationList
            // 
            this.occupationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupationList.FormattingEnabled = true;
            this.occupationList.ItemHeight = 25;
            this.occupationList.Location = new System.Drawing.Point(594, 130);
            this.occupationList.Name = "occupationList";
            this.occupationList.Size = new System.Drawing.Size(202, 29);
            this.occupationList.TabIndex = 7;
            // 
            // nameTBox
            // 
            this.nameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTBox.Location = new System.Drawing.Point(594, 85);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(200, 30);
            this.nameTBox.TabIndex = 8;
            // 
            // addClaimButton
            // 
            this.addClaimButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClaimButton.Location = new System.Drawing.Point(447, 213);
            this.addClaimButton.Name = "addClaimButton";
            this.addClaimButton.Size = new System.Drawing.Size(132, 30);
            this.addClaimButton.TabIndex = 9;
            this.addClaimButton.Text = "Add Claim";
            this.addClaimButton.UseVisualStyleBackColor = true;
            // 
            // claimDetailsLabel
            // 
            this.claimDetailsLabel.AutoSize = true;
            this.claimDetailsLabel.Enabled = false;
            this.claimDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimDetailsLabel.Location = new System.Drawing.Point(440, 261);
            this.claimDetailsLabel.Name = "claimDetailsLabel";
            this.claimDetailsLabel.Size = new System.Drawing.Size(168, 29);
            this.claimDetailsLabel.TabIndex = 10;
            this.claimDetailsLabel.Text = "Claim Details";
            this.claimDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.claimDetailsLabel.Visible = false;
            // 
            // claimDateLabel
            // 
            this.claimDateLabel.AutoSize = true;
            this.claimDateLabel.Enabled = false;
            this.claimDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimDateLabel.Location = new System.Drawing.Point(440, 301);
            this.claimDateLabel.Name = "claimDateLabel";
            this.claimDateLabel.Size = new System.Drawing.Size(142, 25);
            this.claimDateLabel.TabIndex = 11;
            this.claimDateLabel.Text = "Date of Claim";
            this.claimDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.claimDateLabel.Visible = false;
            // 
            // claimDatePicker
            // 
            this.claimDatePicker.Enabled = false;
            this.claimDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimDatePicker.Location = new System.Drawing.Point(594, 301);
            this.claimDatePicker.Name = "claimDatePicker";
            this.claimDatePicker.Size = new System.Drawing.Size(200, 30);
            this.claimDatePicker.TabIndex = 12;
            this.claimDatePicker.Visible = false;
            // 
            // driversLabel
            // 
            this.driversLabel.AutoSize = true;
            this.driversLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversLabel.Location = new System.Drawing.Point(48, 184);
            this.driversLabel.Name = "driversLabel";
            this.driversLabel.Size = new System.Drawing.Size(80, 25);
            this.driversLabel.TabIndex = 13;
            this.driversLabel.Text = "Drivers";
            this.driversLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // policyDetailsLabel
            // 
            this.policyDetailsLabel.AutoSize = true;
            this.policyDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policyDetailsLabel.Location = new System.Drawing.Point(48, 48);
            this.policyDetailsLabel.Name = "policyDetailsLabel";
            this.policyDetailsLabel.Size = new System.Drawing.Size(172, 29);
            this.policyDetailsLabel.TabIndex = 14;
            this.policyDetailsLabel.Text = "Policy Details";
            this.policyDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // driverList
            // 
            this.driverList.Location = new System.Drawing.Point(53, 248);
            this.driverList.Name = "driverList";
            this.driverList.Size = new System.Drawing.Size(248, 134);
            this.driverList.TabIndex = 15;
            this.driverList.UseCompatibleStateImageBehavior = false;
            // 
            // additionalDriverButton
            // 
            this.additionalDriverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalDriverButton.Location = new System.Drawing.Point(53, 212);
            this.additionalDriverButton.Name = "additionalDriverButton";
            this.additionalDriverButton.Size = new System.Drawing.Size(208, 30);
            this.additionalDriverButton.TabIndex = 16;
            this.additionalDriverButton.Text = "Add Additional Driver";
            this.additionalDriverButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(618, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Get Premium";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fields marked with (*) are required";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.additionalDriverButton);
            this.Controls.Add(this.driverList);
            this.Controls.Add(this.policyDetailsLabel);
            this.Controls.Add(this.driversLabel);
            this.Controls.Add(this.claimDatePicker);
            this.Controls.Add(this.claimDateLabel);
            this.Controls.Add(this.claimDetailsLabel);
            this.Controls.Add(this.addClaimButton);
            this.Controls.Add(this.nameTBox);
            this.Controls.Add(this.occupationList);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.occupationLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.driverDetailsLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.startDatePicker);
            this.Name = "Form1";
            this.Text = "Motor Insurance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label driverDetailsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label occupationLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.ListBox occupationList;
        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.Button addClaimButton;
        private System.Windows.Forms.Label claimDetailsLabel;
        private System.Windows.Forms.Label claimDateLabel;
        private System.Windows.Forms.DateTimePicker claimDatePicker;
        private System.Windows.Forms.Label driversLabel;
        private System.Windows.Forms.Label policyDetailsLabel;
        private System.Windows.Forms.ListView driverList;
        private System.Windows.Forms.Button additionalDriverButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

