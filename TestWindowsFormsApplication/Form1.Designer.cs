namespace TestWindowsFormsApplication
{
    partial class MainForm
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
            this.WorkButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // WorkButton
            // 
            this.WorkButton.Location = new System.Drawing.Point(13, 466);
            this.WorkButton.Name = "WorkButton";
            this.WorkButton.Size = new System.Drawing.Size(75, 23);
            this.WorkButton.TabIndex = 0;
            this.WorkButton.Text = "Test!";
            this.WorkButton.UseVisualStyleBackColor = true;
            this.WorkButton.Click += new System.EventHandler(this.WorkButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(13, 13);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(447, 447);
            this.logTextBox.TabIndex = 1;
            this.logTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(497, 491);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.WorkButton);
            this.Name = "MainForm";
            this.Text = "TestWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WorkButton;
        private System.Windows.Forms.RichTextBox logTextBox;
    }
}

