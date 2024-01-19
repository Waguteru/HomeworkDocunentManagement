namespace Homework_DocunentManagement_
{
    partial class addEducation
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
            label2 = new Label();
            loginLabel = new Label();
            label1 = new Label();
            button2 = new Button();
            addPerson_btn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(loginLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 77);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(287, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 2;
            label2.Text = "login";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BorderStyle = BorderStyle.FixedSingle;
            loginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(621, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(47, 23);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(18, 23);
            label1.Name = "label1";
            label1.Size = new Size(487, 32);
            label1.TabIndex = 0;
            label1.Text = "Добавление образовательной программы";
            // 
            // button2
            // 
            button2.Location = new Point(12, 380);
            button2.Name = "button2";
            button2.Size = new Size(121, 31);
            button2.TabIndex = 33;
            button2.Text = "вернуться назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // addPerson_btn
            // 
            addPerson_btn.Location = new Point(196, 351);
            addPerson_btn.Name = "addPerson_btn";
            addPerson_btn.Size = new Size(172, 23);
            addPerson_btn.TabIndex = 32;
            addPerson_btn.Text = "добавить";
            addPerson_btn.UseVisualStyleBackColor = true;
            addPerson_btn.Click += addPerson_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 291);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 31;
            label6.Text = "стоимость обучения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 234);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 30;
            label5.Text = "квалификация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 176);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 29;
            label4.Text = "срок обучения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 109);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 28;
            label3.Text = "название";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(196, 309);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 27;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(196, 252);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 24;
            // 
            // addEducation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(547, 424);
            Controls.Add(button2);
            Controls.Add(addPerson_btn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "addEducation";
            Text = "addEducation";
            Load += addEducation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label loginLabel;
        private Label label1;
        private Button button2;
        private Button addPerson_btn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}