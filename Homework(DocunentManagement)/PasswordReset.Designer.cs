namespace Homework_DocunentManagement_
{
    partial class PasswordReset
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
            login_TB = new TextBox();
            password_TB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // login_TB
            // 
            login_TB.Location = new Point(89, 34);
            login_TB.Name = "login_TB";
            login_TB.Size = new Size(137, 23);
            login_TB.TabIndex = 0;
            // 
            // password_TB
            // 
            password_TB.Location = new Point(89, 72);
            password_TB.Name = "password_TB";
            password_TB.Size = new Size(137, 23);
            password_TB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 34);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 80);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // button1
            // 
            button1.Location = new Point(89, 113);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 4;
            button1.Text = "Подтвердить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(117, 142);
            button2.Name = "button2";
            button2.Size = new Size(69, 23);
            button2.TabIndex = 5;
            button2.Text = "вернуться";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PasswordReset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(287, 177);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_TB);
            Controls.Add(login_TB);
            Name = "PasswordReset";
            Text = "Сброс пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login_TB;
        private TextBox password_TB;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}