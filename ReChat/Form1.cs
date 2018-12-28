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

namespace ReChat
{
    public partial class Form1 : Form
    {
        int skin_num=5;
        string sys_dir = System.Environment.CurrentDirectory;//当前路径
        public Form1()
        {
            InitializeComponent();
            //axShockwaveFlash1.SendToBack();
            axShockwaveFlash1.Movie = sys_dir + "\\WeatherSkin\\5.swf"; //显示动态背景
            user_name_text.Text = "2016011487";
            password_text.Text = "net2018";
            Thread show_bg = new Thread(() => axShockwaveFlash1.Play()); //显示动态背景
            show_bg.Start();
        }
        Socket client;
        private void login_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Stop();
            IPAddress serverIP = IPAddress.Parse("166.111.140.14");//将IP地址字符串转换为IPAddress实例
            IPEndPoint server_ep = new IPEndPoint(serverIP, 8000);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);//建立套接字
            try
            {
                client.Connect(server_ep);
            }
            catch (SocketException)//异常处理
            {
                MessageBox.Show(this, "无法连接到服务器，请检查你的网络连接", "网络错误",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = user_name_text.Text;
            string password = password_text.Text;
            string login_str = username + "_" + password;//用户名+密码
            byte[] login_meg = Encoding.ASCII.GetBytes(login_str);//把字符串按照简体中文的编码方式，编码成 Bytes类型的字节流数组
            client.Send(login_meg);    //发送登录信息
            byte[] re_msg = new byte[1024];//服务器返回字节流
            int re_msg_len = client.Receive(re_msg);
            string re_str = System.Text.Encoding.ASCII.GetString(re_msg, 0, re_msg_len);
            if (re_str == "lol")
            {
                MessageBox.Show(this, "登录成功", "信息提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "用户名或密码错误", "信息提示",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;    //返回，等待用户重新登录
            }
            Thread Thread_Main = new Thread(() => Application.Run(new Form2(username, client)));
            // 如果登录成功，新建一个线程，打开主界面
            Thread_Main.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (skin_num > 1) skin_num--;
            else skin_num = 5;
            axShockwaveFlash1.Movie = sys_dir + "\\WeatherSkin\\" + skin_num.ToString() + ".swf";
        }
    }
}
