namespace Beta_Loader
{
    partial class Register
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
            this.rregister = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Token = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Redeem = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rregister
            // 
            this.rregister.Location = new System.Drawing.Point(60, 189);
            this.rregister.Name = "rregister";
            this.rregister.Size = new System.Drawing.Size(153, 39);
            this.rregister.TabIndex = 0;
            this.rregister.Text = "Register";
            this.rregister.UseVisualStyleBackColor = true;
            this.rregister.Click += new System.EventHandler(this.rregister_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(12, 26);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(250, 20);
            this.Username.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 64);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(250, 20);
            this.Password.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(12, 104);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(250, 20);
            this.Email.TabIndex = 3;
            // 
            // Token
            // 
            this.Token.Location = new System.Drawing.Point(14, 143);
            this.Token.Name = "Token";
            this.Token.Size = new System.Drawing.Size(248, 20);
            this.Token.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Token : ";
            // 
            // Redeem
            // 
            this.Redeem.AutoSize = true;
            this.Redeem.Location = new System.Drawing.Point(12, 166);
            this.Redeem.Name = "Redeem";
            this.Redeem.Size = new System.Drawing.Size(100, 17);
            this.Redeem.TabIndex = 9;
            this.Redeem.Text = "Redeem Token";
            this.Redeem.UseVisualStyleBackColor = true;
            this.Redeem.CheckedChanged += new System.EventHandler(this.Redeem_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 240);
            this.Controls.Add(this.Redeem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Token);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.rregister);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rregister;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Redeem;
    }
}