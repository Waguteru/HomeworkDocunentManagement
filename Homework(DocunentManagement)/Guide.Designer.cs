﻿namespace Homework_DocunentManagement_
{
    partial class Guide
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
            panel1 = new Panel();
            button3 = new Button();
            loginLabel = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            addBut = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(loginLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 100);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveCaption;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(30, 26);
            button3.TabIndex = 4;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BorderStyle = BorderStyle.FixedSingle;
            loginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(203, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(47, 23);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(113, 26);
            label1.Name = "label1";
            label1.Size = new Size(200, 45);
            label1.TabIndex = 0;
            label1.Text = "Справочник";
            // 
            // button1
            // 
            button1.Location = new Point(72, 162);
            button1.Name = "button1";
            button1.Size = new Size(124, 48);
            button1.TabIndex = 1;
            button1.Text = "Физическое лицо";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(253, 162);
            button2.Name = "button2";
            button2.Size = new Size(124, 48);
            button2.TabIndex = 2;
            button2.Text = "Образовательная программа";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // addBut
            // 
            addBut.Location = new Point(351, 118);
            addBut.Name = "addBut";
            addBut.Size = new Size(96, 24);
            addBut.TabIndex = 3;
            addBut.Text = "Админная";
            addBut.UseVisualStyleBackColor = true;
            // 
            // Guide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(470, 261);
            Controls.Add(addBut);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Guide";
            Text = "Guide";
            Load += Guide_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label loginLabel;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button addBut;
        private Button button3;
    }
}