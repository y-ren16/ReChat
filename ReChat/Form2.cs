using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace ReChat
{
    public partial class Form2 : Form
    {
        string sys_dir = System.Environment.CurrentDirectory;
        Socket main_socket;
        int friend_num;
        string[] friend_id_list = new string[1000];
        public Form2(string username, Socket client)
        {
            InitializeComponent();
            this.Text= username;

            welcom.Text = "Welcom    "+username;
            main_socket = client;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            string logout_str = "logout" + this.Text;
            byte[] logout_msg = Encoding.ASCII.GetBytes(logout_str);
            main_socket.Send(logout_msg);    //发送下线信息
            byte[] re_msg = new byte[1024];//服务器返回字节流
            int re_msg_len = main_socket.Receive(re_msg);
            string re_str = System.Text.Encoding.ASCII.GetString(re_msg, 0, re_msg_len);
            if (re_str == "loo")
            {
                MessageBox.Show(this, "下线成功", "信息提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "下线失败", "警告",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private string seek(string ID)
        {
            ID = "q" + ID;
            byte[] seek_msg = Encoding.ASCII.GetBytes(ID);
            main_socket.BeginSend(seek_msg, 0, seek_msg.Length, 0,new AsyncCallback(seek_Callback), main_socket);    //异步发送查询信息
            byte[] bytes = new byte[1024];
            int re_length = main_socket.Receive(bytes);
            string re_str = System.Text.Encoding.ASCII.GetString(bytes, 0, re_length);
            return re_str;
        }
        void seek_Callback(IAsyncResult iar)//异步回调函数
        {
            try
            {
                main_socket = (Socket)iar.AsyncState;
                main_socket.EndSend(iar);
            }
            catch (SocketException e)
            {
                MessageBox.Show(this, e.ToString(), "查询出现异常",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void add_friend_Click(object sender, EventArgs e)
        {
            string receive_string = seek(seek_id_text.Text);
            if ("n" == receive_string)
            {
                foreach (ListViewItem lvi in this.listView1.Items)
                {
                    if (seek_id_text.Text == lvi.SubItems[0].Text)
                    {
                        MessageBox.Show(this, "用户处于离线状态，已在好友列表中", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lvi.SubItems[1].Text = "";
                        lvi.SubItems[2].Text = "offline";
                        return;
                    }
                }
                MessageBox.Show(this, "用户处于离线状态，已添加该用户为好友", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string[] new_friend = new string[4];
                new_friend[0] = seek_id_text.Text;
                new_friend[1] = "";
                new_friend[2] = "offline";
                ListViewItem itm_new = new ListViewItem(new_friend);
                listView1.Items.Add(itm_new);
                string user_dir = sys_dir + "\\" + this.Text;
                if (Directory.Exists(user_dir) == false)//如果不存在就创建file文件夹
                {
                    Directory.CreateDirectory(user_dir);
                }
                FileStream fsw = new FileStream(user_dir + "\\frirnd_id_list.txt", FileMode.Append);
                byte[] data = System.Text.Encoding.Default.GetBytes(seek_id_text.Text);
                fsw.Write(data, 0, data.Length);
                fsw.Flush();
                fsw.Close();
            }
            else if ("Please send the correct message."== receive_string)
            {
                MessageBox.Show(this, "输入错误，不存在该用户", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (ListViewItem lvi in this.listView1.Items)
                {
                    if (seek_id_text.Text == lvi.SubItems[0].Text)
                    {
                        MessageBox.Show(this, "用户处于在线状态，已在好友列表中", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lvi.SubItems[1].Text = receive_string;
                        lvi.SubItems[2].Text = "online";
                        return;
                    }
                }
                MessageBox.Show(this, "用户在线，已添加该用户为好友", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string[] new_friend = new string[4];
                new_friend[0] = seek_id_text.Text;
                new_friend[1] = receive_string;
                new_friend[2] = "online";
                ListViewItem itm_new = new ListViewItem(new_friend);
                listView1.Items.Add(itm_new);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void del_friend_Click(object sender, EventArgs e)
        {

        }

        private void start_chat_Click(object sender, EventArgs e)
        {

        }

        private void start_grop_chat_Click(object sender, EventArgs e)
        {

        }
    }
}
