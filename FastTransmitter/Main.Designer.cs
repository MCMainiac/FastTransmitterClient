namespace FastTransmitter
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_credit = new System.Windows.Forms.Label();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.gb_connect = new System.Windows.Forms.GroupBox();
            this.txtb_connect_password = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txtb_connect_username = new System.Windows.Forms.TextBox();
            this.txtb_connect_port = new System.Windows.Forms.NumericUpDown();
            this.txtb_connect_host = new System.Windows.Forms.TextBox();
            this.lbl_connect_name = new System.Windows.Forms.Label();
            this.lbl_connect_port = new System.Windows.Forms.Label();
            this.lbl_connect_host = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.ListBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txtb_command = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_connect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_connect_port)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 435);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(976, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(48, 24);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.TabStop = false;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_credit
            // 
            this.lbl_credit.AutoSize = true;
            this.lbl_credit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lbl_credit.Location = new System.Drawing.Point(82, 435);
            this.lbl_credit.Name = "lbl_credit";
            this.lbl_credit.Size = new System.Drawing.Size(139, 39);
            this.lbl_credit.TabIndex = 2;
            this.lbl_credit.Text = "FastTransmitter (Client) V1.0\r\nMade by Ricardo Boss\r\nCopyright 2015";
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.Color.White;
            this.lbl_heading.Location = new System.Drawing.Point(7, 9);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(196, 29);
            this.lbl_heading.TabIndex = 3;
            this.lbl_heading.Text = "FastTransmitter";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.SupportMultiDottedExtensions = true;
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(944, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 24);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Text = "_";
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // gb_connect
            // 
            this.gb_connect.Controls.Add(this.txtb_connect_password);
            this.gb_connect.Controls.Add(this.label1);
            this.gb_connect.Controls.Add(this.btn_disconnect);
            this.gb_connect.Controls.Add(this.btn_connect);
            this.gb_connect.Controls.Add(this.txtb_connect_username);
            this.gb_connect.Controls.Add(this.txtb_connect_port);
            this.gb_connect.Controls.Add(this.txtb_connect_host);
            this.gb_connect.Controls.Add(this.lbl_connect_name);
            this.gb_connect.Controls.Add(this.lbl_connect_port);
            this.gb_connect.Controls.Add(this.lbl_connect_host);
            this.gb_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_connect.ForeColor = System.Drawing.Color.White;
            this.gb_connect.Location = new System.Drawing.Point(12, 41);
            this.gb_connect.Name = "gb_connect";
            this.gb_connect.Size = new System.Drawing.Size(327, 132);
            this.gb_connect.TabIndex = 5;
            this.gb_connect.TabStop = false;
            this.gb_connect.Text = "Connect";
            // 
            // txtb_connect_password
            // 
            this.txtb_connect_password.Location = new System.Drawing.Point(110, 97);
            this.txtb_connect_password.Name = "txtb_connect_password";
            this.txtb_connect_password.Size = new System.Drawing.Size(123, 20);
            this.txtb_connect_password.TabIndex = 10;
            this.txtb_connect_password.Text = "password";
            this.txtb_connect_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_disconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_disconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_disconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_disconnect.ForeColor = System.Drawing.Color.White;
            this.btn_disconnect.Location = new System.Drawing.Point(239, 42);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(82, 24);
            this.btn_disconnect.TabIndex = 8;
            this.btn_disconnect.TabStop = false;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_disconnect.UseVisualStyleBackColor = false;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.Color.White;
            this.btn_connect.Location = new System.Drawing.Point(239, 17);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(82, 24);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.TabStop = false;
            this.btn_connect.Text = "Connect";
            this.btn_connect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txtb_connect_username
            // 
            this.txtb_connect_username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtb_connect_username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txtb_connect_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtb_connect_username.Location = new System.Drawing.Point(110, 71);
            this.txtb_connect_username.Name = "txtb_connect_username";
            this.txtb_connect_username.Size = new System.Drawing.Size(123, 20);
            this.txtb_connect_username.TabIndex = 5;
            this.txtb_connect_username.Text = "anonymous";
            // 
            // txtb_connect_port
            // 
            this.txtb_connect_port.Location = new System.Drawing.Point(111, 45);
            this.txtb_connect_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.txtb_connect_port.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.txtb_connect_port.Name = "txtb_connect_port";
            this.txtb_connect_port.Size = new System.Drawing.Size(123, 20);
            this.txtb_connect_port.TabIndex = 4;
            this.txtb_connect_port.Value = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            // 
            // txtb_connect_host
            // 
            this.txtb_connect_host.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtb_connect_host.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txtb_connect_host.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtb_connect_host.Location = new System.Drawing.Point(110, 19);
            this.txtb_connect_host.Name = "txtb_connect_host";
            this.txtb_connect_host.Size = new System.Drawing.Size(123, 20);
            this.txtb_connect_host.TabIndex = 3;
            this.txtb_connect_host.Text = "localhost";
            // 
            // lbl_connect_name
            // 
            this.lbl_connect_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_connect_name.Location = new System.Drawing.Point(7, 72);
            this.lbl_connect_name.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.lbl_connect_name.Name = "lbl_connect_name";
            this.lbl_connect_name.Size = new System.Drawing.Size(90, 18);
            this.lbl_connect_name.TabIndex = 2;
            this.lbl_connect_name.Text = "Username";
            this.lbl_connect_name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_connect_port
            // 
            this.lbl_connect_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_connect_port.Location = new System.Drawing.Point(7, 45);
            this.lbl_connect_port.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.lbl_connect_port.Name = "lbl_connect_port";
            this.lbl_connect_port.Size = new System.Drawing.Size(90, 18);
            this.lbl_connect_port.TabIndex = 1;
            this.lbl_connect_port.Text = "Port";
            this.lbl_connect_port.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_connect_host
            // 
            this.lbl_connect_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_connect_host.Location = new System.Drawing.Point(10, 20);
            this.lbl_connect_host.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.lbl_connect_host.Name = "lbl_connect_host";
            this.lbl_connect_host.Size = new System.Drawing.Size(87, 18);
            this.lbl_connect_host.TabIndex = 0;
            this.lbl_connect_host.Text = "Host";
            this.lbl_connect_host.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.Black;
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logBox.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.logBox.ForeColor = System.Drawing.Color.White;
            this.logBox.FormattingEnabled = true;
            this.logBox.ItemHeight = 15;
            this.logBox.Location = new System.Drawing.Point(345, 32);
            this.logBox.Name = "logBox";
            this.logBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.logBox.Size = new System.Drawing.Size(667, 467);
            this.logBox.TabIndex = 6;
            this.logBox.TabStop = false;
            this.logBox.UseTabStops = false;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_send.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(251, 179);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(82, 24);
            this.btn_send.TabIndex = 8;
            this.btn_send.TabStop = false;
            this.btn_send.Text = "Senden";
            this.btn_send.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txtb_command
            // 
            this.txtb_command.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtb_command.FormattingEnabled = true;
            this.txtb_command.Items.AddRange(new object[] {
            "300 CHECK CONNECTION",
            "400 CLOSE CONNECTION"});
            this.txtb_command.Location = new System.Drawing.Point(12, 181);
            this.txtb_command.Name = "txtb_command";
            this.txtb_command.Size = new System.Drawing.Size(233, 21);
            this.txtb_command.TabIndex = 9;
            this.txtb_command.TabStop = false;
            this.txtb_command.Text = "300 CHECK CONNECTION";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1024, 512);
            this.Controls.Add(this.txtb_command);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.gb_connect);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.lbl_credit);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "FastTransmitterClient";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_connect.ResumeLayout(false);
            this.gb_connect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_connect_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_credit;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.GroupBox gb_connect;
        private System.Windows.Forms.TextBox txtb_connect_host;
        private System.Windows.Forms.Label lbl_connect_name;
        private System.Windows.Forms.Label lbl_connect_port;
        private System.Windows.Forms.Label lbl_connect_host;
        private System.Windows.Forms.TextBox txtb_connect_username;
        private System.Windows.Forms.NumericUpDown txtb_connect_port;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ComboBox txtb_command;
        private System.Windows.Forms.MaskedTextBox txtb_connect_password;
        private System.Windows.Forms.Label label1;
    }
}

