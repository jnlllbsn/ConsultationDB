namespace Consultation.App2
{
    partial class LoginForm
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
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonSignIn = new Button();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(88, 87);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(371, 27);
            textBoxEmail.TabIndex = 0;
            textBoxEmail.Text = "Enter Email";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(88, 64);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(144, 20);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "UMindanao Account";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(88, 151);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(88, 174);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(371, 27);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Text = "Enter Password";
            // 
            // buttonSignIn
            // 
            buttonSignIn.Location = new Point(208, 258);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(94, 29);
            buttonSignIn.TabIndex = 4;
            buttonSignIn.Text = "Sign In";
            buttonSignIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 373);
            Controls.Add(buttonSignIn);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonSignIn;
    }
}
