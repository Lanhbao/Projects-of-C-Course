namespace SearchAString
{
    partial class FormSearchAString
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
            this.searchStringTextBox = new System.Windows.Forms.TextBox();
            this.textBoxToSearchFrom = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.fromFileCheckBox = new System.Windows.Forms.CheckBox();
            this.fromMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.fromDatabaseCheckBox = new System.Windows.Forms.CheckBox();
            this.pathOfFileTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your search string: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "From database:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "From a message";
            // 
            // searchStringTextBox
            // 
            this.searchStringTextBox.Location = new System.Drawing.Point(176, 9);
            this.searchStringTextBox.Name = "searchStringTextBox";
            this.searchStringTextBox.Size = new System.Drawing.Size(200, 20);
            this.searchStringTextBox.TabIndex = 4;
            // 
            // textBoxToSearchFrom
            // 
            this.textBoxToSearchFrom.Location = new System.Drawing.Point(176, 137);
            this.textBoxToSearchFrom.Multiline = true;
            this.textBoxToSearchFrom.Name = "textBoxToSearchFrom";
            this.textBoxToSearchFrom.Size = new System.Drawing.Size(200, 152);
            this.textBoxToSearchFrom.TabIndex = 5;
            this.textBoxToSearchFrom.TextChanged += new System.EventHandler(this.textBoxToSearchFrom_TextChanged);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(176, 64);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(66, 23);
            this.selectButton.TabIndex = 6;
            this.selectButton.Text = "Select file";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(433, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(66, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // fromFileCheckBox
            // 
            this.fromFileCheckBox.AutoSize = true;
            this.fromFileCheckBox.Location = new System.Drawing.Point(433, 64);
            this.fromFileCheckBox.Name = "fromFileCheckBox";
            this.fromFileCheckBox.Size = new System.Drawing.Size(65, 17);
            this.fromFileCheckBox.TabIndex = 8;
            this.fromFileCheckBox.Text = "From file";
            this.fromFileCheckBox.UseVisualStyleBackColor = true;
            this.fromFileCheckBox.CheckedChanged += new System.EventHandler(this.isChecked);
            // 
            // fromMessageCheckBox
            // 
            this.fromMessageCheckBox.AutoSize = true;
            this.fromMessageCheckBox.Location = new System.Drawing.Point(433, 137);
            this.fromMessageCheckBox.Name = "fromMessageCheckBox";
            this.fromMessageCheckBox.Size = new System.Drawing.Size(103, 17);
            this.fromMessageCheckBox.TabIndex = 9;
            this.fromMessageCheckBox.Text = "From a message";
            this.fromMessageCheckBox.UseVisualStyleBackColor = true;
            this.fromMessageCheckBox.CheckedChanged += new System.EventHandler(this.checkStateChangeOfFromAMessageCheckBox);
            // 
            // fromDatabaseCheckBox
            // 
            this.fromDatabaseCheckBox.AutoSize = true;
            this.fromDatabaseCheckBox.Location = new System.Drawing.Point(431, 292);
            this.fromDatabaseCheckBox.Name = "fromDatabaseCheckBox";
            this.fromDatabaseCheckBox.Size = new System.Drawing.Size(105, 17);
            this.fromDatabaseCheckBox.TabIndex = 10;
            this.fromDatabaseCheckBox.Text = "From a database";
            this.fromDatabaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // pathOfFileTextBox
            // 
            this.pathOfFileTextBox.Location = new System.Drawing.Point(176, 100);
            this.pathOfFileTextBox.Name = "pathOfFileTextBox";
            this.pathOfFileTextBox.ReadOnly = true;
            this.pathOfFileTextBox.Size = new System.Drawing.Size(200, 20);
            this.pathOfFileTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Path of file choose:";
            // 
            // FormSearchAString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 369);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pathOfFileTextBox);
            this.Controls.Add(this.fromDatabaseCheckBox);
            this.Controls.Add(this.fromMessageCheckBox);
            this.Controls.Add(this.fromFileCheckBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.textBoxToSearchFrom);
            this.Controls.Add(this.searchStringTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSearchAString";
            this.Text = "Form Search A String";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchStringTextBox;
        private System.Windows.Forms.TextBox textBoxToSearchFrom;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox fromFileCheckBox;
        private System.Windows.Forms.CheckBox fromMessageCheckBox;
        private System.Windows.Forms.CheckBox fromDatabaseCheckBox;
        private System.Windows.Forms.TextBox pathOfFileTextBox;
        private System.Windows.Forms.Label label5;
    }
}

