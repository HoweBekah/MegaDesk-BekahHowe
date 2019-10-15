namespace MegaDesk_BekahHowe
{
    partial class ViewAllQuotes
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
            this.mainmenuBtn.Location = new System.Drawing.Point(12, 12);
            this.mainmenuBtn.Name = "mainmenuBtn";
            this.mainmenuBtn.Size = new System.Drawing.Size(75, 23);
            this.mainmenuBtn.TabIndex = 0;
            this.mainmenuBtn.Text = "Main Menu";
            this.mainmenuBtn.UseVisualStyleBackColor = true;
            this.mainmenuBtn.Click += new System.EventHandler(this.MainmenuBtn_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mainmenuBtn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainmenuBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainmenuBtn;
    }
}