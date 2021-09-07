using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace client_server
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            connect();
        }


        IPEndPoint ipe;
       
        Stream stream;
        TcpClient tcpClient;

       


        private void button1_Click(object sender, EventArgs e)
        {
            send();
        }

        void connect() 
        {

            ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"),9999);
            tcpClient = new TcpClient();
            tcpClient.Connect(ipe);
            stream = tcpClient.GetStream();
            Thread recv = new Thread(receive);
            recv.IsBackground = true;
            recv.Start();
            
        
        }

        void send() 
        {
            byte[] data = Encoding.UTF8.GetBytes(textBox1.Text);
            stream.Write(data,0,data.Length);
            Addmessage("Client :"+ textBox1.Text);
            textBox1.Clear();


        
        
        
        }

        void receive() 
        { 
        while (true) 
            
            {

                byte[] recv = new byte[1024];
                stream.Read(recv, 0, recv.Length);
                string s = Encoding.UTF8.GetString(recv);
                Addmessage("server: " + s);



            
            
            
            }
        
        
        
        }

        void Addmessage(string mess) 
        {
            listView1.Items.Add(new ListViewItem() { Text=mess});
        
        }



      
    }
}
