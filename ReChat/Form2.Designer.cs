namespace ReChat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.welcom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seek_id_text = new System.Windows.Forms.TextBox();
            this.add_friend = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Friend_IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Is_Online = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_List = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.del_friend = new System.Windows.Forms.ToolStripMenuItem();
            this.start_chat = new System.Windows.Forms.ToolStripMenuItem();
            this.start_grop_chat = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcom
            // 
            this.welcom.AutoSize = true;
            this.welcom.BackColor = System.Drawing.SystemColors.Window;
            this.welcom.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcom.Location = new System.Drawing.Point(21, 13);
            this.welcom.Name = "welcom";
            this.welcom.Size = new System.Drawing.Size(101, 37);
            this.welcom.TabIndex = 1;
            this.welcom.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_friend);
            this.groupBox1.Controls.Add(this.seek_id_text);
            this.groupBox1.Location = new System.Drawing.Point(21, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜素并添加好友";
            // 
            // seek_id_text
            // 
            this.seek_id_text.Location = new System.Drawing.Point(22, 24);
            this.seek_id_text.Name = "seek_id_text";
            this.seek_id_text.Size = new System.Drawing.Size(290, 25);
            this.seek_id_text.TabIndex = 0;
            // 
            // add_friend
            // 
            this.add_friend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_friend.BackgroundImage")));
            this.add_friend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_friend.FlatAppearance.BorderSize = 0;
            this.add_friend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_friend.Location = new System.Drawing.Point(318, 18);
            this.add_friend.Name = "add_friend";
            this.add_friend.Size = new System.Drawing.Size(51, 44);
            this.add_friend.TabIndex = 1;
            this.add_friend.UseVisualStyleBackColor = true;
            this.add_friend.Click += new System.EventHandler(this.add_friend_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_List,
            this.Friend_IP,
            this.Is_Online});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(21, 154);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(375, 418);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Friend_IP
            // 
            this.Friend_IP.Text = "IP地址";
            this.Friend_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Friend_IP.Width = 100;
            // 
            // Is_Online
            // 
            this.Is_Online.Text = "在线状态";
            this.Is_Online.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Is_Online.Width = 80;
            // 
            // ID_List
            // 
            this.ID_List.Text = "好友ID";
            this.ID_List.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID_List.Width = 80;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.del_friend,
            this.start_chat,
            this.start_grop_chat});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 104);
            // 
            // del_friend
            // 
            this.del_friend.Name = "del_friend";
            this.del_friend.Size = new System.Drawing.Size(175, 24);
            this.del_friend.Text = "删除好友";
            this.del_friend.Click += new System.EventHandler(this.del_friend_Click);
            // 
            // start_chat
            // 
            this.start_chat.Name = "start_chat";
            this.start_chat.Size = new System.Drawing.Size(175, 24);
            this.start_chat.Text = "发起会话";
            this.start_chat.Click += new System.EventHandler(this.start_chat_Click);
            // 
            // start_grop_chat
            // 
            this.start_grop_chat.Name = "start_grop_chat";
            this.start_grop_chat.Size = new System.Drawing.Size(175, 24);
            this.start_grop_chat.Text = "发起群聊";
            this.start_grop_chat.Click += new System.EventHandler(this.start_grop_chat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 623);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.welcom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add_friend;
        private System.Windows.Forms.TextBox seek_id_text;
        internal System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID_List;
        private System.Windows.Forms.ColumnHeader Friend_IP;
        private System.Windows.Forms.ColumnHeader Is_Online;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem del_friend;
        private System.Windows.Forms.ToolStripMenuItem start_chat;
        private System.Windows.Forms.ToolStripMenuItem start_grop_chat;
    }
}