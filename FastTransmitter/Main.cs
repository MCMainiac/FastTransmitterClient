using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTransmitter
{
    public partial class Main : Form
    {
        private TcpClient clientSocket;
        private StreamWriter writer;
        private StreamReader reader;
        private Thread t;

        private Logger logger;

        #region form events
        private Point lastClick;

        public Main()
        {
            InitializeComponent();
        }
        
        private void log(string message, int level = 0)
        {
            logger.log(message, level);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.logger = new Logger(logBox);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (t != null && t.IsAlive) t.Abort();
            if (clientSocket != null && clientSocket.Connected) clientSocket.Close();
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        #endregion

        private void btn_connect_Click(object sender, EventArgs e)
        {
            string host = txtb_connect_host.Text;
            if (string.IsNullOrEmpty(host)) { log("Please specify a host!", 2); return; }
            int port = int.Parse(txtb_connect_port.Text);
            
            log("Connecting to " + host + ":" + port + "...");
            try
            {
                clientSocket = new TcpClient();
                clientSocket.Connect(host, port);
            }
            catch
            {
                log("Make sure you specified the right host and port!", 2);
                return;
            }
            log("Successfully connected to '" + host + ":" + port + "'!");
            log("Waiting for welcome message...");

            writer = new StreamWriter(clientSocket.GetStream(), Encoding.ASCII);
            reader = new StreamReader(clientSocket.GetStream(), Encoding.ASCII);

            t = new Thread(KeepAlive);
            t.Start();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (clientSocket != null && clientSocket.Connected)
                CloseConnection();
            else
                log("You are not connected to a server!", 2);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txtb_command.SelectedItem != null)
                switch (txtb_command.SelectedItem.ToString())
                {
                    case "300 CHECK CONNECTION": CheckConnection(); break;
                    case "400 CLOSE CONNECTION": CloseConnection(); break;
                }
        }

        private void KeepAlive()
        {
            while (true)
            {
                try
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                        this.BeginInvoke((Action)(() =>
                        {
                            log("[<-] " + line);
                            switch (line.Substring(0, 3))
                            {
                                case "301": Username(); break; // 301: login needed
                                case "303": Password(); break; // 303: password needed
                                case "305": CloseConnection(); break; // 305: authentication failed
                                case "200": CheckConnection(); break; // 200: logged in
                            }
                        }));
                }
                catch (IOException)
                {
                    this.BeginInvoke((Action)(() =>
                    {
                        log("IOException occured! (maybe the server shut down)", 2);
                    }));
                    break;
                }
            }
            CloseConnection();
        }

        private void Write(string message)
        {
            if (!clientSocket.Connected) { CloseConnection(); return; }
            writer.WriteLine(message);
            writer.Flush();
            log("[->] " + message);
        }

        private void Write(string message, string actual, string display)
        {
            if (!clientSocket.Connected) { CloseConnection(); return; }
            writer.WriteLine(message.Replace("%", actual));
            writer.Flush();
            log("[->] " + message.Replace("%", display));
        }

        #region FaTP Commands

        private void CheckConnection()
        {
            if (clientSocket != null && clientSocket.Connected)
                Write("300 Check Connection");
            else
                log("Local socket not connected!", 2);
        }

        private void Username()
        {
            if (clientSocket.Connected)
                Write("302 " + txtb_connect_username.Text);
        }

        private void Password()
        {
            if (clientSocket.Connected)
                Write("304 %", txtb_connect_password.Text, "****");
        }

        private void CloseConnection()
        {
            if (t != null) t.Abort();
            if (clientSocket != null)
            {
                Write("400 Disconnect");
                clientSocket.Close();
                log("Disconnected from server!");
            }
        }

        #endregion
    }
}
