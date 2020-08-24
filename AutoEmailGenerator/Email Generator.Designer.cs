namespace AutoEmailGenerator
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.receiver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER EMAIL ID";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(28, 61);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(70, 15);
            this.Password.TabIndex = 2;
            this.Password.Text = "PASSWORD";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(136, 27);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(121, 20);
            this.username.TabIndex = 3;
            this.username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(136, 58);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(121, 20);
            this.pwd.TabIndex = 4;
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(507, 58);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(121, 20);
            this.subject.TabIndex = 8;
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(507, 20);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(121, 20);
            this.receiver.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(367, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "SUBJECT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "RECEIVER EMAIL ID";
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(50, 131);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(679, 188);
            this.body.TabIndex = 9;
            this.body.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 397);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.body);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "EmailGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox receiver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox body;
        private System.Windows.Forms.Button button2;
    }
}

