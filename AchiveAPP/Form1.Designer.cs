namespace AchiveAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(389, 299);
            button1.Name = "button1";
            button1.Size = new Size(274, 69);
            button1.TabIndex = 0;
            button1.Text = "log in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(341, 88);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(397, 39);
            usernameBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(341, 206);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(397, 39);
            passwordBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 88);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 3;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 213);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 4;
            label2.Text = "password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 660);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label label1;
        private Label label2;
    }
}
