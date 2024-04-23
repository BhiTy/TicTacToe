namespace TicTacToe
{
    partial class ClientServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientServer));
            this.Client = new System.Windows.Forms.Button();
            this.Server = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Local = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ipAdress = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Client
            // 
            this.Client.Location = new System.Drawing.Point(98, 46);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(75, 23);
            this.Client.TabIndex = 1;
            this.Client.Text = "Клиент";
            this.Client.UseVisualStyleBackColor = true;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(17, 46);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(75, 23);
            this.Server.TabIndex = 0;
            this.Server.Text = "Сервер";
            this.Server.UseVisualStyleBackColor = true;
            this.Server.Click += new System.EventHandler(this.Server_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберете кто вы клиент или сервер";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Local
            // 
            this.Local.Location = new System.Drawing.Point(179, 46);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(75, 23);
            this.Local.TabIndex = 5;
            this.Local.Text = "Локально";
            this.Local.UseVisualStyleBackColor = true;
            this.Local.Click += new System.EventHandler(this.Local_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(260, 46);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 6;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(337, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 17);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // ipAdress
            // 
            this.ipAdress.AutoSize = true;
            this.ipAdress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.ipAdress.ForeColor = System.Drawing.Color.Goldenrod;
            this.ipAdress.Location = new System.Drawing.Point(12, 15);
            this.ipAdress.Name = "ipAdress";
            this.ipAdress.Size = new System.Drawing.Size(72, 16);
            this.ipAdress.TabIndex = 8;
            this.ipAdress.Text = "IP Адрес:";
            this.ipAdress.Visible = false;
            // 
            // ipBox
            // 
            this.ipBox.BackColor = System.Drawing.Color.White;
            this.ipBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.ipBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.ipBox.Location = new System.Drawing.Point(91, 8);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(100, 23);
            this.ipBox.TabIndex = 9;
            this.ipBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipBox.Visible = false;
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.port.ForeColor = System.Drawing.Color.Goldenrod;
            this.port.Location = new System.Drawing.Point(14, 53);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(45, 16);
            this.port.TabIndex = 10;
            this.port.Text = "Порт:";
            this.port.Visible = false;
            // 
            // portBox
            // 
            this.portBox.BackColor = System.Drawing.Color.White;
            this.portBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.portBox.ForeColor = System.Drawing.Color.Goldenrod;
            this.portBox.Location = new System.Drawing.Point(91, 50);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(100, 23);
            this.portBox.TabIndex = 11;
            this.portBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.portBox.Visible = false;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(233, 9);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 12;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Visible = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(233, 8);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(83, 23);
            this.Connect.TabIndex = 13;
            this.Connect.Text = "Подключится";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Visible = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // ClientServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(354, 94);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.ipAdress);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Local);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientServer";
            this.Text = "Selecting a client or server";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientServer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientServer_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Client;
        private System.Windows.Forms.Button Server;
        private System.Windows.Forms.Button Local;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label ipAdress;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Button Create;
        public System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Button Connect;
    }
}