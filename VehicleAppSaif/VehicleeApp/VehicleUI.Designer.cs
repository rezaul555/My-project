namespace VehicleeApp
{
    partial class VehicleUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxspeedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vehiclenameTextBox = new System.Windows.Forms.TextBox();
            this.registrationnoTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.maxspeedTextBox = new System.Windows.Forms.TextBox();
            this.minspeedTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.averagespeedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registration No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kilo/hour";
            // 
            // maxspeedLabel
            // 
            this.maxspeedLabel.AutoSize = true;
            this.maxspeedLabel.Location = new System.Drawing.Point(46, 174);
            this.maxspeedLabel.Name = "maxspeedLabel";
            this.maxspeedLabel.Size = new System.Drawing.Size(61, 13);
            this.maxspeedLabel.TabIndex = 4;
            this.maxspeedLabel.Text = "Max Speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Min Speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Average Speed";
            // 
            // vehiclenameTextBox
            // 
            this.vehiclenameTextBox.Location = new System.Drawing.Point(117, 25);
            this.vehiclenameTextBox.Name = "vehiclenameTextBox";
            this.vehiclenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehiclenameTextBox.TabIndex = 0;
            // 
            // registrationnoTextBox
            // 
            this.registrationnoTextBox.Location = new System.Drawing.Point(117, 52);
            this.registrationnoTextBox.Name = "registrationnoTextBox";
            this.registrationnoTextBox.Size = new System.Drawing.Size(100, 20);
            this.registrationnoTextBox.TabIndex = 1;
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(117, 118);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(93, 20);
            this.speedTextBox.TabIndex = 3;
            // 
            // maxspeedTextBox
            // 
            this.maxspeedTextBox.Location = new System.Drawing.Point(117, 171);
            this.maxspeedTextBox.Name = "maxspeedTextBox";
            this.maxspeedTextBox.Size = new System.Drawing.Size(93, 20);
            this.maxspeedTextBox.TabIndex = 5;
            // 
            // minspeedTextBox
            // 
            this.minspeedTextBox.Location = new System.Drawing.Point(117, 211);
            this.minspeedTextBox.Name = "minspeedTextBox";
            this.minspeedTextBox.Size = new System.Drawing.Size(93, 20);
            this.minspeedTextBox.TabIndex = 6;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(282, 45);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(298, 121);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(298, 266);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // averagespeedTextBox
            // 
            this.averagespeedTextBox.Location = new System.Drawing.Point(117, 266);
            this.averagespeedTextBox.Name = "averagespeedTextBox";
            this.averagespeedTextBox.Size = new System.Drawing.Size(93, 20);
            this.averagespeedTextBox.TabIndex = 7;
            // 
            // VehicleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 336);
            this.Controls.Add(this.averagespeedTextBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.minspeedTextBox);
            this.Controls.Add(this.maxspeedTextBox);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.registrationnoTextBox);
            this.Controls.Add(this.vehiclenameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxspeedLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VehicleUI";
            this.Text = "VehicleUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label maxspeedLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vehiclenameTextBox;
        private System.Windows.Forms.TextBox registrationnoTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox maxspeedTextBox;
        private System.Windows.Forms.TextBox minspeedTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox averagespeedTextBox;
    }
}

