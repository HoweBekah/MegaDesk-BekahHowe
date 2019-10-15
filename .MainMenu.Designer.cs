namespace MegaDesk_BekahHowe
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.viewquoteBtn = new System.Windows.Forms.Button();
            this.newQuoteBtn = new System.Windows.Forms.Button();
            this.searchQuotesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.MegaDesk1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MegaDesk1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewquoteBtn
            // 
            this.viewquoteBtn.Location = new System.Drawing.Point(89, 84);
            this.viewquoteBtn.Name = "viewquoteBtn";
            this.viewquoteBtn.Size = new System.Drawing.Size(100, 60);
            this.viewquoteBtn.TabIndex = 2;
            this.viewquoteBtn.Text = "View Quotes";
            this.viewquoteBtn.UseVisualStyleBackColor = true;
            this.viewquoteBtn.Click += new System.EventHandler(this.ViewquoteBtn_Click);
            // 
            // newQuoteBtn
            // 
            this.newQuoteBtn.Location = new System.Drawing.Point(89, 18);
            this.newQuoteBtn.Name = "newQuoteBtn";
            this.newQuoteBtn.Size = new System.Drawing.Size(100, 60);
            this.newQuoteBtn.TabIndex = 1;
            this.newQuoteBtn.Text = "New Quote";
            this.newQuoteBtn.UseVisualStyleBackColor = true;
            this.newQuoteBtn.Click += new System.EventHandler(this.NewQuoteBtn_Click);
            // 
            // searchQuotesBtn
            // 
            this.searchQuotesBtn.Location = new System.Drawing.Point(89, 150);
            this.searchQuotesBtn.Name = "searchQuotesBtn";
            this.searchQuotesBtn.Size = new System.Drawing.Size(100, 60);
            this.searchQuotesBtn.TabIndex = 3;
            this.searchQuotesBtn.Text = "Search Quotes";
            this.searchQuotesBtn.UseVisualStyleBackColor = true;
            this.searchQuotesBtn.Click += new System.EventHandler(this.SearchQuotesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(89, 216);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 60);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MegaDesk1
            // 
            this.MegaDesk1.Image = global::MegaDesk_BekahHowe.Properties.Resources._1megadeskicon;
            this.MegaDesk1.InitialImage = ((System.Drawing.Image)(resources.GetObject("MegaDesk1.InitialImage")));
            this.MegaDesk1.Location = new System.Drawing.Point(239, 24);
            this.MegaDesk1.Name = "MegaDesk1";
            this.MegaDesk1.Size = new System.Drawing.Size(250, 250);
            this.MegaDesk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MegaDesk1.TabIndex = 5;
            this.MegaDesk1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 294);
            this.Controls.Add(this.MegaDesk1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchQuotesBtn);
            this.Controls.Add(this.newQuoteBtn);
            this.Controls.Add(this.viewquoteBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MegaDesk1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewquoteBtn;
        private System.Windows.Forms.Button newQuoteBtn;
        private System.Windows.Forms.Button searchQuotesBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox MegaDesk1;
    }
}

