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

namespace server
{
    public partial class sever : Form
    {
        public sever()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            connect();
        }



        IPEndPoint ipe;
        Socket Client;
        Stream stream;
        TcpListener tcplisten;


        private void button1_Click(object sender, EventArgs e)
        {
            send(Client);
        }
        void connect()
        {
            ipe = new IPEndPoint(IPAddress.Any, 9999);
           tcplisten = new TcpListener(ipe);

           
               
                Thread thread = new Thread
                    (() =>
                    {
                        while (true)
                        {
                            tcplisten.Start();
                            Client = tcplisten.AcceptSocket();
                            Thread rec = new Thread(receive);
                            rec.IsBackground = true;
                            rec.Start(Client);
                        }



                    }

                    );

                thread.IsBackground = true;
                thread.Start();




           

           




        }








        void send(Socket client)
        {
            byte[] data = Encoding.UTF8.GetBytes(textBox1.Text);
            client.Send(data);
            Addmessage("Server :" + textBox1.Text);
            textBox1.Clear();





        }

        void receive(object obj)
        {
            while (true) 
            {
                Socket client = obj as Socket;
                byte[] recv = new byte[1024];
                client.Receive(recv);
                string s = Encoding.UTF8.GetString(recv);

                Addmessage("Client : " + s);

            }
           


        }

        void Addmessage(string mess)
        {
            listView1.Items.Add(new ListViewItem() { Text=mess});

        }

        
    }
}
