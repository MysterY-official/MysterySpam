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
            this.SuspendLayout();
            // 
            // InfoButton
            // 
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
            // 
            // StartStopLabel
            // 
            this.StartStopLabel.AutoSize = true;
            this.StartStopLabel.Depth = 0;
            this.StartStopLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.StartStopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StartStopLabel.Location = new System.Drawing.Point(12, 360);
            this.StartStopLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartStopLabel.Name = "StartStopLabel";
            this.StartStopLabel.Size = new System.Drawing.Size(194, 19);
            this.StartStopLabel.TabIndex = 2;
            this.StartStopLabel.Text = "Press F8 to start/F9 to stop";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.StartStopLabel);
            this.Controls.Add(this.SpamText);
            this.Controls.Add(this.InfoButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MysterySpam - V";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton InfoButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField SpamText;
        private MaterialSkin.Controls.MaterialLabel StartStopLabel;
    }
}

