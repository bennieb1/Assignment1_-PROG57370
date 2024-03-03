namespace Assignment1
{
    partial class ClientForm
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
            panelMoveCharacter = new Panel();
            BtnExit = new Button();
            BtnConnect = new Button();
            pictureBox1 = new PictureBox();
            listBoxClient = new ListBox();
            panelMoveCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMoveCharacter
            // 
            panelMoveCharacter.Controls.Add(BtnExit);
            panelMoveCharacter.Controls.Add(BtnConnect);
            panelMoveCharacter.Controls.Add(pictureBox1);
            panelMoveCharacter.Controls.Add(listBoxClient);
            panelMoveCharacter.Location = new Point(-3, -1);
            panelMoveCharacter.Name = "panelMoveCharacter";
            panelMoveCharacter.Size = new Size(803, 449);
            panelMoveCharacter.TabIndex = 0;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(455, 13);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(130, 39);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnConnect
            // 
            BtnConnect.Location = new Point(259, 13);
            BtnConnect.Name = "BtnConnect";
            BtnConnect.Size = new Size(141, 39);
            BtnConnect.TabIndex = 2;
            BtnConnect.Text = "Connect";
            BtnConnect.UseVisualStyleBackColor = true;
            BtnConnect.Click += BtnConnect_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(259, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(523, 360);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // listBoxClient
            // 
            listBoxClient.FormattingEnabled = true;
            listBoxClient.ItemHeight = 15;
            listBoxClient.Location = new Point(15, 66);
            listBoxClient.Name = "listBoxClient";
            listBoxClient.Size = new Size(226, 349);
            listBoxClient.TabIndex = 0;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMoveCharacter);
            Name = "ClientForm";
            Text = "ClientForm";
            panelMoveCharacter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMoveCharacter;
        private Button BtnExit;
        private Button BtnConnect;
        private PictureBox pictureBox1;
        private ListBox listBoxClient;
    }
}