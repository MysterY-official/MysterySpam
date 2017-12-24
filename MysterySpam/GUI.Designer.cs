namespace MysterySpam
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.InfoButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SpamText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.StartStopLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.SpeedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ModeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CopyPasteModeButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.SimulateModeButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoButton
            // 
            this.InfoButton.AutoSize = true;
            this.InfoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InfoButton.Depth = 0;
            this.InfoButton.Icon = null;
            this.InfoButton.Location = new System.Drawing.Point(536, 352);
            this.InfoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Primary = true;
            this.InfoButton.Size = new System.Drawing.Size(52, 36);
            this.InfoButton.TabIndex = 0;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // SpamText
            // 
            this.SpamText.Depth = 0;
            this.SpamText.Hint = "Text to spam";
            this.SpamText.Location = new System.Drawing.Point(12, 80);
            this.SpamText.MaxLength = 100;
            this.SpamText.MouseState = MaterialSkin.MouseState.HOVER;
            this.SpamText.Name = "SpamText";
            this.SpamText.PasswordChar = '\0';
            this.SpamText.SelectedText = "";
            this.SpamText.SelectionLength = 0;
            this.SpamText.SelectionStart = 0;
            this.SpamText.Size = new System.Drawing.Size(576, 23);
            this.SpamText.TabIndex = 1;
            this.SpamText.TabStop = false;
            this.SpamText.UseSystemPasswordChar = false;
            this.SpamText.TextChanged += new System.EventHandler(this.SpamText_Change);
            // 
            // StartStopLabel
            // 
            this.StartStopLabel.AutoSize = true;
            this.StartStopLabel.Depth = 0;
            this.StartStopLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.StartStopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StartStopLabel.Location = new System.Drawing.Point(13, 369);
            this.StartStopLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartStopLabel.Name = "StartStopLabel";
            this.StartStopLabel.Size = new System.Drawing.Size(194, 19);
            this.StartStopLabel.TabIndex = 2;
            this.StartStopLabel.Text = "Press F8 to start/F9 to stop";
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.LargeChange = 50;
            this.SpeedTrackBar.Location = new System.Drawing.Point(12, 110);
            this.SpeedTrackBar.Maximum = 1000;
            this.SpeedTrackBar.Minimum = 100;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SpeedTrackBar.Size = new System.Drawing.Size(576, 45);
            this.SpeedTrackBar.SmallChange = 10;
            this.SpeedTrackBar.TabIndex = 3;
            this.SpeedTrackBar.TickFrequency = 2500;
            this.SpeedTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SpeedTrackBar.Value = 250;
            this.SpeedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBar_Scroll);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Depth = 0;
            this.SpeedLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.SpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SpeedLabel.Location = new System.Drawing.Point(249, 158);
            this.SpeedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(103, 19);
            this.SpeedLabel.TabIndex = 4;
            this.SpeedLabel.Text = "Speed: 250ms";
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Depth = 0;
            this.ModeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ModeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ModeLabel.Location = new System.Drawing.Point(8, 271);
            this.ModeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(47, 19);
            this.ModeLabel.TabIndex = 5;
            this.ModeLabel.Text = "Mode";
            // 
            // CopyPasteModeButton
            // 
            this.CopyPasteModeButton.AutoSize = true;
            this.CopyPasteModeButton.Checked = true;
            this.CopyPasteModeButton.Depth = 0;
            this.CopyPasteModeButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.CopyPasteModeButton.Location = new System.Drawing.Point(12, 290);
            this.CopyPasteModeButton.Margin = new System.Windows.Forms.Padding(0);
            this.CopyPasteModeButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CopyPasteModeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CopyPasteModeButton.Name = "CopyPasteModeButton";
            this.CopyPasteModeButton.Ripple = true;
            this.CopyPasteModeButton.Size = new System.Drawing.Size(195, 30);
            this.CopyPasteModeButton.TabIndex = 6;
            this.CopyPasteModeButton.TabStop = true;
            this.CopyPasteModeButton.Text = "Copy/Paste Mode (fastest)";
            this.CopyPasteModeButton.UseVisualStyleBackColor = true;
            this.CopyPasteModeButton.CheckedChanged += new System.EventHandler(this.CopyPasteModeButton_CheckedChanged);
            // 
            // SimulateModeButton
            // 
            this.SimulateModeButton.AutoSize = true;
            this.SimulateModeButton.Depth = 0;
            this.SimulateModeButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.SimulateModeButton.Location = new System.Drawing.Point(12, 320);
            this.SimulateModeButton.Margin = new System.Windows.Forms.Padding(0);
            this.SimulateModeButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.SimulateModeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SimulateModeButton.Name = "SimulateModeButton";
            this.SimulateModeButton.Ripple = true;
            this.SimulateModeButton.Size = new System.Drawing.Size(369, 30);
            this.SimulateModeButton.TabIndex = 7;
            this.SimulateModeButton.Text = "Simulate Mode (slower, but should work in every game)";
            this.SimulateModeButton.UseVisualStyleBackColor = true;
            this.SimulateModeButton.CheckedChanged += new System.EventHandler(this.SimulateModeButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.SimulateModeButton);
            this.Controls.Add(this.CopyPasteModeButton);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.SpeedTrackBar);
            this.Controls.Add(this.StartStopLabel);
            this.Controls.Add(this.SpamText);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MysterySpam - V";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton InfoButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField SpamText;
        private MaterialSkin.Controls.MaterialLabel StartStopLabel;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private MaterialSkin.Controls.MaterialLabel SpeedLabel;
        private MaterialSkin.Controls.MaterialLabel ModeLabel;
        private MaterialSkin.Controls.MaterialRadioButton CopyPasteModeButton;
        private MaterialSkin.Controls.MaterialRadioButton SimulateModeButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

