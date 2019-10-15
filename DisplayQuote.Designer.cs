namespace MegaDesk_BekahHowe
{
    partial class DisplayQuote
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
            this.mainmenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainmenuBtn
            // 
            this.mainmenuBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainmenuBtn.Location = new System.Drawing.Point(12, 12);
            this.mainmenuBtn.Name = "mainmenuBtn";
            this.mainmenuBtn.Size = new System.Drawing.Size(75, 23);
            this.mainmenuBtn.TabIndex = 2;
            this.mainmenuBtn.Text = "Main Menu";
            this.mainmenuBtn.UseVisualStyleBackColor = true;
            this.mainmenuBtn.Click += new System.EventHandler(this.MainmenuBtn_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainmenuBtn);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainmenuBtn;
    }
}