namespace Beta_Loader
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.llogin = new System.Windows.Forms.Button();
            this.OpenRegister = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llogin
            // 
            this.llogin.Location = new System.Drawing.Point(12, 100);
            this.llogin.Name = "llogin";
            this.llogin.Size = new System.Drawing.Size(111, 42);
            this.llogin.TabIndex = 0;
            this.llogin.Text = "Login";
            this.llogin.UseVisualStyleBackColor = true;
            this.llogin.Click += new System.EventHandler(this.llogin_Click);
            // 
            // OpenRegister
            // 
            this.OpenRegister.Location = new System.Drawing.Point(129, 100);
            this.OpenRegister.Name = "OpenRegister";
            this.OpenRegister.Size = new System.Drawing.Size(114, 42);
            this.OpenRegister.TabIndex = 1;
            this.OpenRegister.Text = "Register";
            this.OpenRegister.UseVisualStyleBackColor = true;
            this.OpenRegister.Click += new System.EventHandler(this.OpenRegister_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(12, 27);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(231, 20);
            this.Username.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 64);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(231, 20);
            this.Password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password :";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 157);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.OpenRegister);
            this.Controls.Add(this.llogin);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button llogin;
        private System.Windows.Forms.Button OpenRegister;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

