namespace MotorInsuranceCalculation
{
    partial class QuoteCalculator
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
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.addClaimButton = new System.Windows.Forms.Button();
            this.claimDetailsLabel = new System.Windows.Forms.Label();
            this.claim1Label = new System.Windows.Forms.Label();
            this.claimDatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.driversLabel = new System.Windows.Forms.Label();
            this.policyDetailsLabel = new System.Windows.Forms.Label();
            this.additionalDriverButton = new System.Windows.Forms.Button();
            this.getPremiumButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.occupationList = new System.Windows.Forms.ComboBox();
            this.driverList = new System.Windows.Forms.ListBox();
            this.claimDatePicker2 = new System.Windows.Forms.DateTimePicker();
            this.claim2Label = new System.Windows.Forms.Label();
            this.claimDatePicker3 = new System.Windows.Forms.DateTimePicker();
            this.claim3Label = new System.Windows.Forms.Label();
            this.claimDatePicker4 = new System.Windows.Forms.DateTimePicker();
            this.claim4Label = new System.Windows.Forms.Label();
            this.claimDatePicker5 = new System.Windows.Forms.DateTimePicker();
            this.claim5Label = new System.Windows.Forms.Label();
            this.numClaimsLabel = new System.Windows.Forms.Label();
            this.numClaimsBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(53, 130);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(228, 30);
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
            this.dobPicker.Location = new System.Drawing.Point(640, 170);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(228, 30);
            this.dobPicker.TabIndex = 6;
            // 
            // nameTBox
            // 
            this.nameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTBox.Location = new System.Drawing.Point(640, 85);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(228, 30);
            this.nameTBox.TabIndex = 8;
            this.nameTBox.TextChanged += new System.EventHandler(this.nameTBox_TextChanged);
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
            this.addClaimButton.Click += new System.EventHandler(this.addClaimButton_Click);
            // 
            // claimDetailsLabel
            // 
            this.claimDetailsLabel.AutoSize = true;
            this.claimDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimDetailsLabel.Location = new System.Drawing.Point(440, 261);
            this.claimDetailsLabel.Name = "claimDetailsLabel";
            this.claimDetailsLabel.Size = new System.Drawing.Size(168, 29);
            this.claimDetailsLabel.TabIndex = 10;
            this.claimDetailsLabel.Text = "Claim Details";
            this.claimDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.claimDetailsLabel.Visible = false;
            // 
            // claim1Label
            // 
            this.claim1Label.AutoSize = true;
            this.claim1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claim1Label.Location = new System.Drawing.Point(440, 333);
            this.claim1Label.Name = "claim1Label";
            this.claim1Label.Size = new System.Drawing.Size(157, 25);
            this.claim1Label.TabIndex = 11;
            this.claim1Label.Text = "Date of Claim *";
            this.claim1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.claim1Label.Visible = false;
            // 
            // claimDatePicker1
            // 
            this.claimDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimDatePicker1.Location = new System.Drawing.Point(640, 333);
            this.claimDatePicker1.Name = "claimDatePicker1";
            this.claimDatePicker1.Size = new System.Drawing.Size(228, 30);
            this.claimDatePicker1.TabIndex = 12;
            this.claimDatePicker1.Visible = false;
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
            // additionalDriverButton
            // 
            this.additionalDriverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalDriverButton.Location = new System.Drawing.Point(53, 212);
            this.additionalDriverButton.Name = "additionalDriverButton";
            this.additionalDriverButton.Size = new System.Drawing.Size(208, 30);
            this.additionalDriverButton.TabIndex = 16;
            this.additionalDriverButton.Text = "Add Additional Driver";
            this.additionalDriverButton.UseVisualStyleBackColor = true;
            this.additionalDriverButton.Click += new System.EventHandler(this.additionalDriverButton_Click);
            // 
            // getPremiumButton
            // 
            this.getPremiumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getPremiumButton.Location = new System.Drawing.Point(640, 554);
            this.getPremiumButton.Name = "getPremiumButton";
            this.getPremiumButton.Size = new System.Drawing.Size(176, 39);
            this.getPremiumButton.TabIndex = 17;
            this.getPremiumButton.Text = "Get Premium";
            this.getPremiumButton.UseVisualStyleBackColor = true;
            this.getPremiumButton.Click += new System.EventHandler(this.getPremiumButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 573);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fields marked with (*) are required";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // occupationList
            // 
            this.occupationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupationList.FormattingEnabled = true;
            this.occupationList.Items.AddRange(new object[] {
            "Chauffeur",
            "Accountant"});
            this.occupationList.Location = new System.Drawing.Point(640, 127);
            this.occupationList.Name = "occupationList";
            this.occupationList.Size = new System.Drawing.Size(228, 33);
            this.occupationList.TabIndex = 19;
            // 
            // driverList
            // 
            this.driverList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverList.FormattingEnabled = true;
            this.driverList.ItemHeight = 20;
            this.driverList.Location = new System.Drawing.Point(53, 261);
            this.driverList.Name = "driverList";
            this.driverList.Size = new System.Drawing.Size(262, 164);
            this.driverList.TabIndex = 21;
            // 
            // claimDatePicker2
            // 
            this.claimDatePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimDatePicker2.Location = new System.Drawing.Point(640, 369);
            this.claimDatePicker2.Name = "claimDatePicker2";
            this.claimDatePicker2.Size = new System.Drawing.Size(228, 30);
            this.claimDatePicker2.TabIndex = 23;
            this.claimDatePicker2.Visible = false;
            // 
            // claim2Label
            // 
            this.claim2Label.AutoSize = true;
            this.claim2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claim2Label.Location = new System.Drawing.Point(440, 369);
            this.claim2Label.Name = "claim2Label";
            this.claim2Label.Size = new System.Drawing.Size(157, 25);
            this.claim2Label.TabIndex = 22;
            this.claim2Label.Text = "Date of Claim *";
            this.claim2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.claim2Label.Visible = false;
            // 
            // claimDatePicker3
            // 
            this.claimDatePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimDatePicker3.Location = new System.Drawing.Point(640, 405);
            this.claimDatePicker3.Name = "claimDatePicker3";
            this.claimDatePicker3.Size = new System.Drawing.Size(228, 30);
            this.claimDatePicker3.TabIndex = 25;
            this.claimDatePicker3.Visible = false;
            // 
            // claim3Label
            // 
            this.claim3Label.AutoSize = true;
            this.claim3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claim3Label.Location = new System.Drawing.Point(440, 405);
            this.claim3Label.Name = "claim3Label";
            this.claim3Label.Size = new System.Drawing.Size(157, 25);
            this.claim3Label.TabIndex = 24;
            this.claim3Label.Text = "Date of Claim *";
            this.claim3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.claim3Label.Visible = false;
            // 
            // claimDatePicker4
            // 
            this.claimDatePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimDatePicker4.Location = new System.Drawing.Point(640, 441);
            this.claimDatePicker4.Name = "claimDatePicker4";
            this.claimDatePicker4.Size = new System.Drawing.Size(228, 30);
            this.claimDatePicker4.TabIndex = 27;
            this.claimDatePicker4.Visible = false;
            // 
            // claim4Label
            // 
            this.claim4Label.AutoSize = true;
            this.claim4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claim4Label.Location = new System.Drawing.Point(440, 441);
            this.claim4Label.Name = "claim4Label";
            this.claim4Label.Size = new System.Drawing.Size(157, 25);
            this.claim4Label.TabIndex = 26;
            this.claim4Label.Text = "Date of Claim *";
            this.claim4Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.claim4Label.Visible = false;
            // 
            // claimDatePicker5
            // 
            this.claimDatePicker5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimDatePicker5.Location = new System.Drawing.Point(640, 477);
            this.claimDatePicker5.Name = "claimDatePicker5";
            this.claimDatePicker5.Size = new System.Drawing.Size(228, 30);
            this.claimDatePicker5.TabIndex = 29;
            this.claimDatePicker5.Visible = false;
            // 
            // claim5Label
            // 
            this.claim5Label.AutoSize = true;
            this.claim5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claim5Label.Location = new System.Drawing.Point(440, 477);
            this.claim5Label.Name = "claim5Label";
            this.claim5Label.Size = new System.Drawing.Size(157, 25);
            this.claim5Label.TabIndex = 28;
            this.claim5Label.Text = "Date of Claim *";
            this.claim5Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.claim5Label.Visible = false;
            // 
            // numClaimsLabel
            // 
            this.numClaimsLabel.AutoSize = true;
            this.numClaimsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numClaimsLabel.Location = new System.Drawing.Point(442, 294);
            this.numClaimsLabel.Name = "numClaimsLabel";
            this.numClaimsLabel.Size = new System.Drawing.Size(183, 25);
            this.numClaimsLabel.TabIndex = 30;
            this.numClaimsLabel.Text = "Number of Claims";
            this.numClaimsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.numClaimsLabel.Visible = false;
            // 
            // numClaimsBox
            // 
            this.numClaimsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numClaimsBox.FormattingEnabled = true;
            this.numClaimsBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.numClaimsBox.Location = new System.Drawing.Point(784, 291);
            this.numClaimsBox.Name = "numClaimsBox";
            this.numClaimsBox.Size = new System.Drawing.Size(84, 33);
            this.numClaimsBox.TabIndex = 31;
            this.numClaimsBox.Visible = false;
            this.numClaimsBox.SelectedIndexChanged += new System.EventHandler(this.numClaimsBox_SelectedIndexChanged);
            // 
            // QuoteCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 617);
            this.Controls.Add(this.numClaimsBox);
            this.Controls.Add(this.numClaimsLabel);
            this.Controls.Add(this.claimDatePicker5);
            this.Controls.Add(this.claim5Label);
            this.Controls.Add(this.claimDatePicker4);
            this.Controls.Add(this.claim4Label);
            this.Controls.Add(this.claimDatePicker3);
            this.Controls.Add(this.claim3Label);
            this.Controls.Add(this.claimDatePicker2);
            this.Controls.Add(this.claim2Label);
            this.Controls.Add(this.driverList);
            this.Controls.Add(this.occupationList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getPremiumButton);
            this.Controls.Add(this.additionalDriverButton);
            this.Controls.Add(this.policyDetailsLabel);
            this.Controls.Add(this.driversLabel);
            this.Controls.Add(this.claimDatePicker1);
            this.Controls.Add(this.claim1Label);
            this.Controls.Add(this.claimDetailsLabel);
            this.Controls.Add(this.addClaimButton);
            this.Controls.Add(this.nameTBox);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.occupationLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.driverDetailsLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.startDatePicker);
            this.Name = "QuoteCalculator";
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
        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.Button addClaimButton;
        private System.Windows.Forms.Label claimDetailsLabel;
        private System.Windows.Forms.Label claim1Label;
        private System.Windows.Forms.DateTimePicker claimDatePicker1;
        private System.Windows.Forms.Label driversLabel;
        private System.Windows.Forms.Label policyDetailsLabel;
        private System.Windows.Forms.Button additionalDriverButton;
        private System.Windows.Forms.Button getPremiumButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox occupationList;
        private System.Windows.Forms.ListBox driverList;
        private System.Windows.Forms.DateTimePicker claimDatePicker2;
        private System.Windows.Forms.Label claim2Label;
        private System.Windows.Forms.DateTimePicker claimDatePicker3;
        private System.Windows.Forms.Label claim3Label;
        private System.Windows.Forms.DateTimePicker claimDatePicker4;
        private System.Windows.Forms.Label claim4Label;
        private System.Windows.Forms.DateTimePicker claimDatePicker5;
        private System.Windows.Forms.Label claim5Label;
        private System.Windows.Forms.Label numClaimsLabel;
        private System.Windows.Forms.ComboBox numClaimsBox;
    }
}

