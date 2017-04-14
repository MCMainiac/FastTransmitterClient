using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FastTransmitter
{
    public partial class Main : Form
    {
        private TcpClient _clientSocket;
        private StreamWriter _writer;
        private StreamReader _reader;
        private Thread _t;

        private Logger _logger;

        #region Form Events

        private Point _lastClick;

        public Main()
        {
            InitializeComponent();
        }
        
        private void Log(string message, int level = 0)
        {
            _logger.log(message, level);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _logger = new Logger(logBox);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (_t != null && _t.IsAlive) _t.Abort();
            if (_clientSocket != null && _clientSocket.Connected) _clientSocket.Close();
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            _lastClick = e.Location;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Left += e.X - _lastClick.X;
            Top += e.Y - _lastClick.Y;
        }

        #endregion

        private void btn_connect_Click(object sender, EventArgs e)
        {
            var host = txtb_connect_host.Text;

            if (string.IsNullOrEmpty(host)) { Log("Please specify a host!", 2); return; }

            var port = int.Parse(txtb_connect_port.Text);
            
            Log($"Connecting to {host}:{port}...");
            try
            {
                _clientSocket = new TcpClient();
                _clientSocket.Connect(host, port);
            }
            catch
            {
                Log("Make sure you specified the right host and port!", 2);
                return;
            }
            Log($"Successfully connected to {host}:{port}!");
            Log("Waiting for welcome message...");

            _writer = new StreamWriter(_clientSocket.GetStream(), Encoding.ASCII);
            _reader = new StreamReader(_clientSocket.GetStream(), Encoding.ASCII);

            _t = new Thread(KeepAlive);
            _t.Start();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (_clientSocket != null && _clientSocket.Connected)
                CloseConnection();
            else
                Log("You are not connected to a server!", 2);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txtb_command.SelectedItem == null) return;

            switch (txtb_command.SelectedItem.ToString())
            {
                case "300 CHECK CONNECTION":
                    CheckConnection();
                    break;
                case "400 CLOSE CONNECTION":
                    CloseConnection();
                    break;

                default:
                    return;
            }
        }

        private void KeepAlive()
        {
            while (true)
            {
                try
                {
                    var line = _reader.ReadLine();

                    if (string.IsNullOrEmpty(line)) continue;

                    void ProcessLine()
                    {
                        Log($"[<-] {line}");
                        switch (line.Substring(0, 3))
                        {
                            case "301": // 301: login needed
                                Username();
                                break;
                            case "303": // 303: password needed
                                Password();
                                break;
                            case "305": // 305: authentication failed
                                CloseConnection();
                                break;
                            case "200": // 200: logged in
                                CheckConnection();
                                break;
                            default:
                                return;
                        }
                    }

                    BeginInvoke((Action) ProcessLine);
                }
                catch (IOException)
                {
                    void LogException()
                    {
                        Log("IOException occured! (maybe the server shut down)", 2);
                    }

                    BeginInvoke((Action)(LogException));
                    break;
                }
            }

            CloseConnection();
        }

        private void Write(string message)
        {
            if (!_clientSocket.Connected) { CloseConnection(); return; }
            _writer.WriteLine(message);
            _writer.Flush();
            Log($"[->] {message}");
        }

        private void Write(string message, string actual, string display)
        {
            if (!_clientSocket.Connected) { CloseConnection(); return; }
            _writer.WriteLine(message.Replace("%", actual));
            _writer.Flush();
            Log($"[->] {message.Replace("%", display)}");
        }

        #region FaTP Commands

        private void CheckConnection()
        {
            if (_clientSocket != null && _clientSocket.Connected)
                Write("300 Check Connection");
            else
                Log("Local socket not connected!", 2);
        }

        private void Username()
        {
            if (_clientSocket.Connected)
                Write($"302 {txtb_connect_username.Text}");
        }

        private void Password()
        {
            if (_clientSocket.Connected)
                Write("304 %", txtb_connect_password.Text, "****");
        }

        private void CloseConnection()
        {
            _t?.Abort();

            if (_clientSocket == null) return;

            Write("400 Disconnect");
            _clientSocket.Close();
            Log("Disconnected from server!");
        }

        #endregion
    }
}
