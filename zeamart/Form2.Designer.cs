namespace zeamart
{
    partial class Form2
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
            btn_login = new Button();
            tb_password = new TextBox();
            label2 = new Label();
            tb_username = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaption;
            btn_login.Location = new Point(596, 208);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(112, 34);
            btn_login.TabIndex = 17;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(376, 140);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(332, 31);
            tb_password.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 143);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(376, 68);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(332, 31);
            tb_username.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 71);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 13;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Welcome_cuate;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 283);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Controls.Add(label2);
            Controls.Add(tb_username);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox tb_password;
        private Label label2;
        private TextBox tb_username;
        private Label label1;
        private PictureBox pictureBox1;
    }
}