namespace Homework_DocunentManagement_
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            login_TB = new TextBox();
            password_TB = new TextBox();
            button1 = new Button();
            button2 = new Button();
            passAgainBut = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(17, 29);
            label1.Name = "label1";
            label1.Size = new Size(212, 45);
            label1.TabIndex = 1;
            label1.Text = "Авторизация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 137);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 210);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            // 
            // login_TB
            // 
            login_TB.Location = new Point(60, 155);
            login_TB.Name = "login_TB";
            login_TB.Size = new Size(125, 23);
            login_TB.TabIndex = 4;
            // 
            // password_TB
            // 
            password_TB.Location = new Point(60, 228);
            password_TB.Name = "password_TB";
            password_TB.PasswordChar = '*';
            password_TB.Size = new Size(125, 23);
            password_TB.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(60, 306);
            button1.Name = "button1";
            button1.Size = new Size(125, 31);
            button1.TabIndex = 6;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(40, 354);
            button2.Name = "button2";
            button2.Size = new Size(174, 31);
            button2.TabIndex = 7;
            button2.Text = "зарегистрироваться";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // passAgainBut
            // 
            passAgainBut.BackColor = SystemColors.InactiveCaption;
            passAgainBut.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passAgainBut.Location = new Point(120, 257);
            passAgainBut.Name = "passAgainBut";
            passAgainBut.Size = new Size(112, 25);
            passAgainBut.TabIndex = 8;
            passAgainBut.Text = "сбросить пароль";
            passAgainBut.UseVisualStyleBackColor = false;
            passAgainBut.Click += passAgainBut_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(267, 394);
            Controls.Add(passAgainBut);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(password_TB);
            Controls.Add(login_TB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox login_TB;
        private TextBox password_TB;
        private Button button1;
        private Button button2;
        private Button passAgainBut;
    }
}
