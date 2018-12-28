namespace ReChat
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.password_text = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.Label();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.button1 = new System.Windows.Forms.Button();
            this.user_name_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // password_text
            // 
            this.password_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.password_text.Location = new System.Drawing.Point(233, 241);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '*';
            this.password_text.Size = new System.Drawing.Size(196, 25);
            this.password_text.TabIndex = 2;
            // 
            // login
            // 
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.Location = new System.Drawing.Point(129, 285);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(300, 38);
            this.login.TabIndex = 3;
            this.login.Text = "登      录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(125, 198);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(72, 27);
            this.name.TabIndex = 4;
            this.name.Text = "用户名";
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pw.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pw.Location = new System.Drawing.Point(125, 244);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(52, 27);
            this.pw.TabIndex = 5;
            this.pw.Text = "密码";
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(-9, -45);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(561, 402);
            this.axShockwaveFlash1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(508, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_name_text
            // 
            this.user_name_text.Location = new System.Drawing.Point(233, 198);
            this.user_name_text.Name = "user_name_text";
            this.user_name_text.Size = new System.Drawing.Size(196, 25);
            this.user_name_text.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(545, 348);
            this.Controls.Add(this.user_name_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.name);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReChat";
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label pw;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox user_name_text;
    }
}

