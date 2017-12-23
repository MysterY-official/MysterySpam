namespace MysterySpam
{
    partial class InfoGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoGUI));
            this.infoText = new MaterialSkin.Controls.MaterialLabel();
            this.YTButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SkinButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // infoText
            // 
            this.infoText.Depth = 0;
            this.infoText.Font = new System.Drawing.Font("Roboto", 11F);
            this.infoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoText.Location = new System.Drawing.Point(12, 82);
            this.infoText.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(306, 114);
            this.infoText.TabIndex = 0;
            this.infoText.Text = "MysterySpam is currently\r\ndeveloped by MysterY.\r\n\r\nThe goal of this program is to" +
    " be a\r\ncustomizable, open source chat spam\r\ntool with a nice looking GUI.";
            this.infoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YTButton
            // 
            this.YTButton.AutoSize = true;
            this.YTButton.Depth = 0;
            this.YTButton.Icon = null;
            this.YTButton.Location = new System.Drawing.Point(12, 213);
            this.YTButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.YTButton.Name = "YTButton";
            this.YTButton.Primary = true;
            this.YTButton.Size = new System.Drawing.Size(127, 36);
            this.YTButton.TabIndex = 1;
            this.YTButton.Text = "MysterY on YT";
            this.YTButton.UseVisualStyleBackColor = true;
            this.YTButton.Click += new System.EventHandler(this.YTButton_Click);
            // 
            // SkinButton
            // 
            this.SkinButton.AutoSize = true;
            this.SkinButton.Depth = 0;
            this.SkinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkinButton.Icon = null;
            this.SkinButton.Location = new System.Drawing.Point(157, 213);
            this.SkinButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SkinButton.Name = "SkinButton";
            this.SkinButton.Primary = true;
            this.SkinButton.Size = new System.Drawing.Size(161, 36);
            this.SkinButton.TabIndex = 2;
            this.SkinButton.Text = "Skin by IgnaceMaes";
            this.SkinButton.UseVisualStyleBackColor = true;
            this.SkinButton.Click += new System.EventHandler(this.SkinButton_Click);
            // 
            // InfoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 261);
            this.Controls.Add(this.SkinButton);
            this.Controls.Add(this.YTButton);
            this.Controls.Add(this.infoText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoGUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InfoGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel infoText;
        private MaterialSkin.Controls.MaterialRaisedButton YTButton;
        private MaterialSkin.Controls.MaterialRaisedButton SkinButton;
    }
}