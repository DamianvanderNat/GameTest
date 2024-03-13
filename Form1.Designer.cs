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
            legendaPictureBox2 = new System.Windows.Forms.PictureBox();
            legendaPictureBox1 = new System.Windows.Forms.PictureBox();
            legendaHolder1 = new System.Windows.Forms.PictureBox();
            mapQuestLogBox = new System.Windows.Forms.RichTextBox();
            InputBoxMap1 = new System.Windows.Forms.TextBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            tabControl1.SuspendLayout();
            MenuTab1.SuspendLayout();
            Game1.SuspendLayout();
            Map1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)legendaPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)legendaPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)legendaHolder1).BeginInit();
            SuspendLayout();
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblStart.ForeColor = System.Drawing.SystemColors.Control;
            lblStart.Location = new System.Drawing.Point(44, 28);
            lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            lblSettings.Location = new System.Drawing.Point(44, 129);
            lblSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            lblQuit.Location = new System.Drawing.Point(44, 234);
            lblQuit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblQuit.Name = "lblQuit";
            lblQuit.Size = new System.Drawing.Size(116, 67);
            lblQuit.TabIndex = 2;
            lblQuit.Text = "Quit";
            lblQuit.Click += lblQuit_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(MenuTab1);
            tabControl1.Controls.Add(Game1);
            tabControl1.Controls.Add(Map1);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1028, 638);
            tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            tabControl1.TabIndex = 4;
            tabControl1.TabStop = false;
            // 
            // MenuTab1
            // 
            MenuTab1.BackColor = System.Drawing.Color.Black;
            MenuTab1.Controls.Add(lblQuit);
            MenuTab1.Controls.Add(lblStart);
            MenuTab1.Controls.Add(lblSettings);
            MenuTab1.Location = new System.Drawing.Point(4, 5);
            MenuTab1.Margin = new System.Windows.Forms.Padding(4);
            MenuTab1.Name = "MenuTab1";
            MenuTab1.Padding = new System.Windows.Forms.Padding(4);
            MenuTab1.Size = new System.Drawing.Size(1020, 629);
            MenuTab1.TabIndex = 0;
            MenuTab1.Text = "start menu";
            // 
            // Game1
            // 
            Game1.BackColor = System.Drawing.Color.Black;
            Game1.Controls.Add(TextLog);
            Game1.Controls.Add(InputBox1);
            Game1.Location = new System.Drawing.Point(4, 5);
            Game1.Margin = new System.Windows.Forms.Padding(4);
            Game1.Name = "Game1";
            Game1.Padding = new System.Windows.Forms.Padding(4);
            Game1.Size = new System.Drawing.Size(1020, 629);
            Game1.TabIndex = 1;
            Game1.Text = "game console";
            // 
            // InputBox1
            // 
            InputBox1.Location = new System.Drawing.Point(17, 459);
            InputBox1.Margin = new System.Windows.Forms.Padding(4);
            InputBox1.Name = "InputBox1";
            InputBox1.Size = new System.Drawing.Size(965, 31);
            InputBox1.TabIndex = 0;
            InputBox1.KeyPress += InputBoxMap1_KeyPress;
            // 
            // Map1
            // 
            Map1.BackColor = System.Drawing.Color.Black;
            Map1.Controls.Add(legendaPictureBox2);
            Map1.Controls.Add(legendaPictureBox1);
            Map1.Controls.Add(legendaHolder1);
            Map1.Controls.Add(mapQuestLogBox);
            Map1.Controls.Add(InputBoxMap1);
            Map1.Controls.Add(flowLayoutPanel1);
            Map1.Location = new System.Drawing.Point(4, 5);
            Map1.Margin = new System.Windows.Forms.Padding(4);
            Map1.Name = "Map1";
            Map1.Padding = new System.Windows.Forms.Padding(4);
            Map1.Size = new System.Drawing.Size(1020, 629);
            Map1.TabIndex = 2;
            Map1.Text = "map";
            // 
            // legendaPictureBox2
            // 
            legendaPictureBox2.Location = new System.Drawing.Point(582, 7);
            legendaPictureBox2.Name = "legendaPictureBox2";
            legendaPictureBox2.Size = new System.Drawing.Size(26, 170);
            legendaPictureBox2.TabIndex = 0;
            legendaPictureBox2.TabStop = false;
            // 
            // legendaPictureBox1
            // 
            legendaPictureBox1.Location = new System.Drawing.Point(384, 7);
            legendaPictureBox1.Name = "legendaPictureBox1";
            legendaPictureBox1.Size = new System.Drawing.Size(26, 170);
            legendaPictureBox1.TabIndex = 0;
            legendaPictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(25, 560);
            textBox1.Margin = new System.Windows.Forms.Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(965, 31);
            textBox1.TabIndex = 7;
            // 
            // mapQuestLogBox
            // 
            mapQuestLogBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            mapQuestLogBox.Location = new System.Drawing.Point(372, 243);
            mapQuestLogBox.Name = "mapQuestLogBox";
            mapQuestLogBox.Size = new System.Drawing.Size(436, 187);
            mapQuestLogBox.TabIndex = 8;
            mapQuestLogBox.Text = "";
            // 
            // InputBoxMap1
            // 
            InputBoxMap1.Location = new System.Drawing.Point(20, 448);
            InputBoxMap1.Name = "InputBoxMap1";
            InputBoxMap1.Size = new System.Drawing.Size(773, 27);
            InputBoxMap1.TabIndex = 7;
            InputBoxMap1.KeyPress += InputBoxMap1_KeyPress;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel1.MinimumSize = new System.Drawing.Size(24, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(366, 427);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(1028, 638);
            Controls.Add(tabControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            Name = "GameForm";
            Text = "StartWindow";
            Load += Form1_Load;
            KeyDown += GameForm_KeyDown;
            tabControl1.ResumeLayout(false);
            MenuTab1.ResumeLayout(false);
            MenuTab1.PerformLayout();
            Game1.ResumeLayout(false);
            Game1.PerformLayout();
            Map1.ResumeLayout(false);
            Map1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)legendaPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)legendaPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)legendaHolder1).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox legendaHolder1;
        private System.Windows.Forms.RichTextBox mapQuestLogBox;
        private System.Windows.Forms.TextBox InputBoxMap1;
        private System.Windows.Forms.PictureBox legendaPictureBox2;
        private System.Windows.Forms.PictureBox legendaPictureBox1;
        private System.Windows.Forms.RichTextBox TextLog;
    }
}

