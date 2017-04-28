namespace FileTransfer_Client
{
    partial class FileTransfer_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileTransfer_Client));
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Main2 = new System.Windows.Forms.Panel();
            this.btn_IPConnectionOk = new System.Windows.Forms.Button();
            this.maskedTextBox_IPconnection = new System.Windows.Forms.MaskedTextBox();
            this.pb_ipConnection = new System.Windows.Forms.PictureBox();
            this.pnl_MainSeparador = new System.Windows.Forms.Panel();
            this.pb_ShutdownButton = new System.Windows.Forms.PictureBox();
            this.pb_InfoButton = new System.Windows.Forms.PictureBox();
            this.pb_UploadButton = new System.Windows.Forms.PictureBox();
            this.lbl_MainTitle = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            this.pnl_Main2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ipConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShutdownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_InfoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UploadButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.Firebrick;
            this.pnl_Main.Controls.Add(this.pnl_Main2);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(365, 278);
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_Main2
            // 
            this.pnl_Main2.BackColor = System.Drawing.Color.SeaGreen;
            this.pnl_Main2.Controls.Add(this.btn_IPConnectionOk);
            this.pnl_Main2.Controls.Add(this.maskedTextBox_IPconnection);
            this.pnl_Main2.Controls.Add(this.pb_ipConnection);
            this.pnl_Main2.Controls.Add(this.pnl_MainSeparador);
            this.pnl_Main2.Controls.Add(this.pb_ShutdownButton);
            this.pnl_Main2.Controls.Add(this.pb_InfoButton);
            this.pnl_Main2.Controls.Add(this.pb_UploadButton);
            this.pnl_Main2.Controls.Add(this.lbl_MainTitle);
            this.pnl_Main2.Location = new System.Drawing.Point(4, 4);
            this.pnl_Main2.Name = "pnl_Main2";
            this.pnl_Main2.Size = new System.Drawing.Size(357, 270);
            this.pnl_Main2.TabIndex = 0;
            // 
            // btn_IPConnectionOk
            // 
            this.btn_IPConnectionOk.Location = new System.Drawing.Point(250, 234);
            this.btn_IPConnectionOk.Name = "btn_IPConnectionOk";
            this.btn_IPConnectionOk.Size = new System.Drawing.Size(34, 23);
            this.btn_IPConnectionOk.TabIndex = 8;
            this.btn_IPConnectionOk.Text = "OK";
            this.btn_IPConnectionOk.UseVisualStyleBackColor = true;
            this.btn_IPConnectionOk.Click += new System.EventHandler(this.btn_IPConnectionOk_Click);
            // 
            // maskedTextBox_IPconnection
            // 
            this.maskedTextBox_IPconnection.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_IPconnection.Location = new System.Drawing.Point(108, 232);
            this.maskedTextBox_IPconnection.Mask = "###,###,###,###";
            this.maskedTextBox_IPconnection.Name = "maskedTextBox_IPconnection";
            this.maskedTextBox_IPconnection.ResetOnSpace = false;
            this.maskedTextBox_IPconnection.Size = new System.Drawing.Size(141, 26);
            this.maskedTextBox_IPconnection.TabIndex = 7;
            this.maskedTextBox_IPconnection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb_ipConnection
            // 
            this.pb_ipConnection.Image = global::FileTransfer_Client.Properties.Resources.Network_Internet_Connection_icon;
            this.pb_ipConnection.Location = new System.Drawing.Point(59, 222);
            this.pb_ipConnection.Name = "pb_ipConnection";
            this.pb_ipConnection.Size = new System.Drawing.Size(48, 48);
            this.pb_ipConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_ipConnection.TabIndex = 6;
            this.pb_ipConnection.TabStop = false;
            // 
            // pnl_MainSeparador
            // 
            this.pnl_MainSeparador.BackColor = System.Drawing.Color.Firebrick;
            this.pnl_MainSeparador.Location = new System.Drawing.Point(0, 217);
            this.pnl_MainSeparador.Name = "pnl_MainSeparador";
            this.pnl_MainSeparador.Size = new System.Drawing.Size(357, 5);
            this.pnl_MainSeparador.TabIndex = 4;
            // 
            // pb_ShutdownButton
            // 
            this.pb_ShutdownButton.Image = global::FileTransfer_Client.Properties.Resources.power_2_icon__1_;
            this.pb_ShutdownButton.Location = new System.Drawing.Point(330, 3);
            this.pb_ShutdownButton.Name = "pb_ShutdownButton";
            this.pb_ShutdownButton.Size = new System.Drawing.Size(24, 24);
            this.pb_ShutdownButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_ShutdownButton.TabIndex = 3;
            this.pb_ShutdownButton.TabStop = false;
            this.pb_ShutdownButton.Click += new System.EventHandler(this.pb_ShutdownButton_Click);
            this.pb_ShutdownButton.MouseHover += new System.EventHandler(this.pb_ShutdownButton_MouseHover);
            // 
            // pb_InfoButton
            // 
            this.pb_InfoButton.Image = global::FileTransfer_Client.Properties.Resources.problem_4_icon;
            this.pb_InfoButton.Location = new System.Drawing.Point(291, 163);
            this.pb_InfoButton.Name = "pb_InfoButton";
            this.pb_InfoButton.Size = new System.Drawing.Size(48, 48);
            this.pb_InfoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_InfoButton.TabIndex = 2;
            this.pb_InfoButton.TabStop = false;
            this.pb_InfoButton.Click += new System.EventHandler(this.pb_InfoButton_Click);
            this.pb_InfoButton.MouseHover += new System.EventHandler(this.pb_InfoButton_MouseHover);
            // 
            // pb_UploadButton
            // 
            this.pb_UploadButton.Image = global::FileTransfer_Client.Properties.Resources.upload_3_icon;
            this.pb_UploadButton.Location = new System.Drawing.Point(130, 88);
            this.pb_UploadButton.Name = "pb_UploadButton";
            this.pb_UploadButton.Size = new System.Drawing.Size(96, 96);
            this.pb_UploadButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_UploadButton.TabIndex = 1;
            this.pb_UploadButton.TabStop = false;
            this.pb_UploadButton.Click += new System.EventHandler(this.pb_UploadButton_Click);
            this.pb_UploadButton.MouseHover += new System.EventHandler(this.pb_UploadButton_MouseHover);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.AutoSize = true;
            this.lbl_MainTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MainTitle.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_MainTitle.Location = new System.Drawing.Point(55, 16);
            this.lbl_MainTitle.Name = "lbl_MainTitle";
            this.lbl_MainTitle.Size = new System.Drawing.Size(246, 34);
            this.lbl_MainTitle.TabIndex = 0;
            this.lbl_MainTitle.Text = "File Transfer Tool";
            // 
            // FileTransfer_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 278);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileTransfer_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Transfer Tool - Client";
            this.Load += new System.EventHandler(this.FileTransfer_Client_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main2.ResumeLayout(false);
            this.pnl_Main2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ipConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ShutdownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_InfoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_UploadButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Main2;
        private System.Windows.Forms.PictureBox pb_UploadButton;
        private System.Windows.Forms.Label lbl_MainTitle;
        private System.Windows.Forms.PictureBox pb_InfoButton;
        private System.Windows.Forms.PictureBox pb_ShutdownButton;
        private System.Windows.Forms.PictureBox pb_ipConnection;
        private System.Windows.Forms.Panel pnl_MainSeparador;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_IPconnection;
        private System.Windows.Forms.Button btn_IPConnectionOk;
    }
}

