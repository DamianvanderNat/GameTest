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
            tabControl1 = new System.Windows.Forms.TabControl();
            MenuTab1 = new System.Windows.Forms.TabPage();
            Game1 = new System.Windows.Forms.TabPage();
            InputBox1 = new System.Windows.Forms.TextBox();
            Map1 = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            MenuTab1.SuspendLayout();
            Game1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblStart.ForeColor = System.Drawing.SystemColors.Control;
            lblStart.Location = new System.Drawing.Point(35, 22);
            lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblStart.Name = "lblStart";
            lblStart.Size = new System.Drawing.Size(106, 56);
            lblStart.TabIndex = 0;
            lblStart.Text = "Start";
            lblStart.Click += lblStart_Click;
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblSettings.ForeColor = System.Drawing.SystemColors.Control;
            lblSettings.Location = new System.Drawing.Point(35, 103);
            lblSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new System.Drawing.Size(150, 56);
            lblSettings.TabIndex = 1;
            lblSettings.Text = "Settings";
            lblSettings.Click += lblSettings_Click;
            // 
            // lblQuit
            // 
            lblQuit.AutoSize = true;
            lblQuit.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblQuit.ForeColor = System.Drawing.SystemColors.Control;
            lblQuit.Location = new System.Drawing.Point(35, 187);
            lblQuit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblQuit.Name = "lblQuit";
            lblQuit.Size = new System.Drawing.Size(98, 56);
            lblQuit.TabIndex = 2;
            lblQuit.Text = "Quit";
            lblQuit.Click += lblQuit_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(MenuTab1);
            tabControl1.Controls.Add(Game1);
            tabControl1.Controls.Add(Map1);
            tabControl1.Location = new System.Drawing.Point(-19, -42);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(664, 520);
            tabControl1.TabIndex = 4;
            // 
            // MenuTab1
            // 
            MenuTab1.BackColor = System.Drawing.Color.Black;
            MenuTab1.Controls.Add(lblQuit);
            MenuTab1.Controls.Add(lblStart);
            MenuTab1.Controls.Add(lblSettings);
            MenuTab1.Location = new System.Drawing.Point(4, 29);
            MenuTab1.Name = "MenuTab1";
            MenuTab1.Padding = new System.Windows.Forms.Padding(3);
            MenuTab1.Size = new System.Drawing.Size(656, 487);
            MenuTab1.TabIndex = 0;
            MenuTab1.Text = "tabPage1";
            // 
            // Game1
            // 
            Game1.BackColor = System.Drawing.Color.Black;
            Game1.Controls.Add(InputBox1);
            Game1.Location = new System.Drawing.Point(4, 29);
            Game1.Name = "Game1";
            Game1.Padding = new System.Windows.Forms.Padding(3);
            Game1.Size = new System.Drawing.Size(656, 487);
            Game1.TabIndex = 1;
            Game1.Text = "tabPage2";
            // 
            // InputBox1
            // 
            InputBox1.Location = new System.Drawing.Point(27, 369);
            InputBox1.Name = "InputBox1";
            InputBox1.Size = new System.Drawing.Size(609, 27);
            InputBox1.TabIndex = 0;
            InputBox1.TextChanged += InputBox1_TextChanged;
            InputBox1.Enter += InputBox1_Enter;
            // 
            // Map1
            // 
            Map1.BackColor = System.Drawing.Color.Black;
            Map1.Location = new System.Drawing.Point(4, 29);
            Map1.Name = "Map1";
            Map1.Padding = new System.Windows.Forms.Padding(3);
            Map1.Size = new System.Drawing.Size(656, 487);
            Map1.TabIndex = 2;
            Map1.Text = "tabPage3";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(633, 461);
            Controls.Add(tabControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "GameForm";
            Text = "StartWindow";
            Load += Form1_Load;
            KeyDown += GameForm_KeyDown;
            tabControl1.ResumeLayout(false);
            MenuTab1.ResumeLayout(false);
            MenuTab1.PerformLayout();
            Game1.ResumeLayout(false);
            Game1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MenuTab1;
        private System.Windows.Forms.TabPage Game1;
        private System.Windows.Forms.TabPage Map1;
        private System.Windows.Forms.TextBox InputBox1;
    }
}

