namespace GameTest
{
    partial class GameForm
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
            lblStart = new System.Windows.Forms.Label();
            lblSettings = new System.Windows.Forms.Label();
            lblQuit = new System.Windows.Forms.Label();
            StartPanel = new System.Windows.Forms.Panel();
            StartPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblStart.ForeColor = System.Drawing.SystemColors.Control;
            lblStart.Location = new System.Drawing.Point(3, 24);
            lblStart.Name = "lblStart";
            lblStart.Size = new System.Drawing.Size(124, 67);
            lblStart.TabIndex = 0;
            lblStart.Text = "Start";
            lblStart.Click += lblStart_Click;
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblSettings.ForeColor = System.Drawing.SystemColors.Control;
            lblSettings.Location = new System.Drawing.Point(0, 79);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new System.Drawing.Size(176, 67);
            lblSettings.TabIndex = 1;
            lblSettings.Text = "Settings";
            lblSettings.Click += lblSettings_Click;
            // 
            // lblQuit
            // 
            lblQuit.AutoSize = true;
            lblQuit.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblQuit.ForeColor = System.Drawing.SystemColors.Control;
            lblQuit.Location = new System.Drawing.Point(0, 234);
            lblQuit.Name = "lblQuit";
            lblQuit.Size = new System.Drawing.Size(116, 67);
            lblQuit.TabIndex = 2;
            lblQuit.Text = "Quit";
            lblQuit.Click += lblQuit_Click;
            // 
            // StartPanel
            // 
            StartPanel.Controls.Add(lblQuit);
            StartPanel.Controls.Add(lblSettings);
            StartPanel.Location = new System.Drawing.Point(3, 94);
            StartPanel.Name = "StartPanel";
            StartPanel.Size = new System.Drawing.Size(300, 346);
            StartPanel.TabIndex = 3;
            StartPanel.Paint += StartPanel_Paint;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(791, 576);
            Controls.Add(lblStart);
            Controls.Add(StartPanel);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "GameForm";
            Text = "StartWindow";
            Load += Form1_Load;
            KeyDown += GameForm_KeyDown;
            StartPanel.ResumeLayout(false);
            StartPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Panel StartPanel;
    }
}

