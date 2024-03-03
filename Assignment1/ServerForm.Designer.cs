namespace Assignment1
{
    partial class ServerForm
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
            pictureBox1 = new PictureBox();
            listBoxServer = new ListBox();
            BtnStart = new Button();
            panelMoveCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMoveCharacter
            // 
            panelMoveCharacter.Controls.Add(BtnStart);
            panelMoveCharacter.Controls.Add(pictureBox1);
            panelMoveCharacter.Controls.Add(listBoxServer);
            panelMoveCharacter.Location = new Point(0, 1);
            panelMoveCharacter.Name = "panelMoveCharacter";
            panelMoveCharacter.Size = new Size(798, 445);
            panelMoveCharacter.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(244, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(544, 349);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listBoxServer
            // 
            listBoxServer.FormattingEnabled = true;
            listBoxServer.ItemHeight = 15;
            listBoxServer.Location = new Point(12, 40);
            listBoxServer.Name = "listBoxServer";
            listBoxServer.Size = new Size(226, 349);
            listBoxServer.TabIndex = 1;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(297, 6);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(76, 28);
            BtnStart.TabIndex = 3;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMoveCharacter);
            Name = "ServerForm";
            Text = "ServerForm";
            panelMoveCharacter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMoveCharacter;
        private PictureBox pictureBox1;
        private ListBox listBoxServer;
        private Button BtnStart;
    }
}