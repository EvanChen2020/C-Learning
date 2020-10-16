namespace P21_4
{
    partial class myForm
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
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.myButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myTextBox
            // 
            this.myTextBox.Location = new System.Drawing.Point(12, 12);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(344, 20);
            this.myTextBox.TabIndex = 0;
            // 
            // myButton
            // 
            this.myButton.Location = new System.Drawing.Point(13, 57);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(343, 23);
            this.myButton.TabIndex = 1;
            this.myButton.Text = "Say Hello";
            this.myButton.UseVisualStyleBackColor = true;
         //   this.myButton.Click += new System.EventHandler(this.MyButton_Click);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myButton);
            this.Controls.Add(this.myTextBox);
            this.Name = "myForm";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myTextBox;
        private System.Windows.Forms.Button myButton;
    }
}

