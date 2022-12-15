namespace Ision
{
    partial class Start_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_form));
            this.button_enter = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(126, 99);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(59, 25);
            this.button_enter.TabIndex = 9;
            this.button_enter.Text = "Вход";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.Button_enter_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_password.Location = new System.Drawing.Point(103, 60);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '●';
            this.textBox_password.Size = new System.Drawing.Size(104, 23);
            this.textBox_password.TabIndex = 8;
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_password_KeyDown);
            // 
            // textBox_login
            // 
            this.textBox_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_login.Location = new System.Drawing.Point(103, 20);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(104, 23);
            this.textBox_login.TabIndex = 7;
            this.textBox_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_login_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(48, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // Start_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 175);
            this.MinimumSize = new System.Drawing.Size(300, 175);
            this.Name = "Start_form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_enter;
        private TextBox textBox_password;
        private TextBox textBox_login;
        private Label label2;
        private Label label1;
    }
}